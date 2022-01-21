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
    public partial class HomePage : Form
    { 
        public string userEmail;
        public string userName;
        public string eventName;
        public HomePage()
        {
            InitializeComponent();
            fillComboBox();
        }
        Account account;
        UploadPhoto uploadPhoto;
        Album album;
         
        public HomePage(Album album)
        {
            InitializeComponent();
           
            this.album = album;
            userEmail = album.userEmail;
            userName = album.userName;
             fillComboBox();
        }
        public HomePage(Account account)
        {
            InitializeComponent();
           
            this.account = account;
            userEmail = account.getEmailLabel.Text;
            userName = account.getNameLabel.Text;
             fillComboBox();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createTextBox.Visible = true;
            createButton.Visible = true;
            existingComboBox.Visible = false;
            goEventButton.Visible = false;
            /*CreateEvent createEvent = new CreateEvent();
            this.Hide();
            createEvent.Show();*/
        }

        private void openExistingEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            existingComboBox.Visible = true;
            goEventButton.Visible = true;
            createTextBox.Visible = false;
            createButton.Visible = false;
            /*ExistingEvent existingEvent = new ExistingEvent();
            this.Hide();
            existingEvent.Show();*/
        }

        private void goEventButton_Click(object sender, EventArgs e)
        {
            eventName = existingComboBox.Text;
            if (existingComboBox.Text=="")
            {
                MessageBox.Show("Enter Any Event Name");
            }
            else
            {
                eventName = existingComboBox.Text;
                MessageBox.Show(eventName + " is your event");
                Album album = new Album(this);
                this.Hide();
                album.Show();
                
            }
            

        }
        
        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("See you soon "+ userName+". Take care!");
            Account account = new Account();
            this.Hide();
            account.Show();
            
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();
                string sql = "INSERT INTO Events(EventName, Email, EventCreated) VALUES('" + createTextBox.Text + "', '" + userEmail + "', '" + createdEventDateTimePicker.Value + "')";
                SqlCommand command = new SqlCommand(sql, connection);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    eventName = createTextBox.Text;

                    MessageBox.Show(eventName + " created successfully!");

                    Album album = new Album(this);
                    this.Hide();
                    album.Show();


                    /*HomePage homePage = new HomePage();
                    this.Hide();
                    homePage.Show();*/

                }
                else
                {
                    MessageBox.Show("Error");
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Event Name");
            }
            
            
        }
        public void fillComboBox()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            string sql = "SELECT * from Events Where Email='"+userEmail+"'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader= command.ExecuteReader();
            try
            {
               
                while(reader.Read())
                {
                    eventName = reader.GetString(1);
                    existingComboBox.Items.Add(eventName);
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void existingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventName = existingComboBox.Text;
           
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
    }
   
