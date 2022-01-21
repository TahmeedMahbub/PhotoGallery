using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo
{
    public partial class UploadPhoto : Form
    {
        public string userEmail;
        public string userName;
        public string eventName;

        public UploadPhoto()
        {
            InitializeComponent();
        }
        Account account;
        Album album;
        HomePage homePage;
        public UploadPhoto(Account account)
        {
            InitializeComponent();
            this.account = account;
            userEmail = account.getEmailLabel.Text;
            userName = account.getNameLabel.Text;

        }
        public UploadPhoto(Album album)
        {
            InitializeComponent();
            this.album = album;
            eventName = album.eventName;
            userEmail = album.userEmail;
            userName = album.userName;
            MessageBox.Show(eventName + "\n" + userEmail +"\n"+ userName);

        }

        private void UploadPhoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            fileLocationLabel.Text = openFileDialog1.FileName;
            photoStoryTextBox.Enabled = true;
            uploadButton.Enabled = true;
            label2.Enabled = true;
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            label1.Visible = true;
            highRadioButton.Visible = true;
            moderateRadioButton.Visible = true;
            lessImportantRadioButton.Visible = true;
            
           
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            if (highRadioButton.Checked)
                imporanceLabel.Text = "High";
            else if (lessImportantRadioButton.Checked)
                imporanceLabel.Text = "Less Important";
            else
                imporanceLabel.Text = "Moderate";

            

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "INSERT INTO Photos(EventName,CreatedDate,OldPhotoLocation, PhotoStory ,Email,Importance)" +
                " VALUES('" + eventName + "','" + createdDateTimePicker.Value + "','" + fileLocationLabel.Text + "','" 
                + photoStoryTextBox.Text + "','" + userEmail + "','" + imporanceLabel.Text + "')";
            
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Photo added to Event: "+eventName);
                Album album = new Album(this);
                this.Hide();
                album.Show();

            }
            else
            {
                MessageBox.Show("Error");
            }
            connection.Close();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("See you soon " + userName + ". Take care!");
            Account account = new Account();
            this.Hide();
            account.Show();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Album album = new Album(this);
            this.Hide();
            album.Show();

        }

        private void moderateRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
