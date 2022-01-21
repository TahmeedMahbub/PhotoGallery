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
    public partial class Album : Form
    {
        public string userEmail;
        public string userName;
        public string eventName;
        public int photoId;
        public int[] photoIdArray=new int [100];
        public string[] photoStoryArray = new string[100];
        public string[] importanceArray = new string[100];
        public string[] createdDateArray = new string[100];
        int arr=0;
        private List<Image> LoadedImages { get; set; }
        public Album()
        {
            InitializeComponent();
        }
        Account account;
        HomePage homepage;
        UploadPhoto uploadPhoto;
        public Album(Account account)
        {
            InitializeComponent();
            this.account = account;
            userEmail = account.getEmailLabel.Text;
            userName = account.getNameLabel.Text;
        }
        Album album;
        public Album(Album album)
        {
            InitializeComponent();
            this.album = album;
            userEmail = album.userEmail;
            userName = album.userName;
        }
        public Album(HomePage homepage)
        {
            InitializeComponent();
            this.homepage = homepage;
            eventName = homepage.eventName;
            this.userEmail = homepage.userEmail;
            this.userName = homepage.userName;
            eventNameLabel.Text = eventName;
        }
        public Album(UploadPhoto uploadPhoto)
        {
            InitializeComponent();
            this.uploadPhoto = uploadPhoto;
            this.eventName = uploadPhoto.eventName;
            this.userEmail = uploadPhoto.userEmail;
            this.userName = uploadPhoto.userName;
            this.eventNameLabel.Text = eventName;
        }

        private void Event_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void Event_Load_1(object sender, EventArgs e)
        {
            LoadImagesFromFolder();
            ImageList images = new ImageList();
            
            foreach (var image in LoadedImages)
            {
                images.Images.Add(image);
            }
            photoList.LargeImageList = images;
            for (int itemIndex = 1; itemIndex <= LoadedImages.Count; itemIndex++)
                photoList.Items.Add(new ListViewItem($"First Image{itemIndex}", itemIndex - 1));

        }

        private void Album_Load(object sender, EventArgs e)
        {
            LoadImagesFromFolder();
            ImageList images = new ImageList();
            
            foreach (var image in LoadedImages)
            {
                images.Images.Add(image);
            }
            photoList.LargeImageList = images;
            for (int itemIndex = 1; itemIndex <= LoadedImages.Count; itemIndex++)
                photoList.Items.Add(new ListViewItem($"Image {itemIndex}", itemIndex - 1));
        }
        private void LoadImagesFromFolder()
        {
            LoadedImages = new List<Image>();
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            string sql = "SELECT * from Photos Where EventName='"+eventNameLabel.Text+"'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {

                while (reader.Read())
                {
                    var tempLocation=reader["OldPhotoLocation"].ToString();
                    var tempImage = Image.FromFile(tempLocation);
                    LoadedImages.Add(tempImage);
                    photoStoryArray[arr]=reader["PhotoStory"].ToString();
                    importanceArray[arr]=reader["Importance"].ToString();
                    createdDateArray[arr]=reader["CreatedDate"].ToString();
                    photoIdArray[arr]= Convert.ToInt32( reader["PhotoId"]); 
                    arr++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void photoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (photoList.SelectedIndices.Count > 0)
            {
                var selectedIndex = photoList.SelectedIndices[0];
                Image selectedImg = LoadedImages[selectedIndex];
                label2.Text = importanceArray[selectedIndex];
                createdDate.Text = createdDateArray[selectedIndex];
                photoStoryLabel.Text = photoStoryArray[selectedIndex];
                selectedPhoto.Image = selectedImg;
                
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("See you soon " + userName + ". Take care!");
            Account account = new Account();
            this.Hide();
            account.Show();
            
        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            UploadPhoto uploadPhoto = new UploadPhoto(this);
            this.Hide();
            uploadPhoto.Show();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(this);
            this.Hide();
            homePage.Show();
        }

        private void addPhotoButton_Click_1(object sender, EventArgs e)
        {
            eventName = eventNameLabel.Text;
            UploadPhoto uploadPhoto = new UploadPhoto(this);
            this.Hide();
            uploadPhoto.Show();
        }

        private void photoList_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void photoList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            if(photoList.SelectedIndices.Count>0)
            {
                var selectedIndex = photoList.SelectedIndices[0];
                Image selectedImg = LoadedImages[selectedIndex];
                selectedPhoto.Image = selectedImg;
                photoStoryLabel.Text = photoStoryArray[selectedIndex];
                label2.Text = importanceArray[selectedIndex];
                createdDate.Text = createdDateArray[selectedIndex];
                photoId = photoIdArray[selectedIndex];
            }
            

        }

        private void modifyPhotoButton_Click(object sender, EventArgs e)
        {
            eventName = eventNameLabel.Text;
            ModifyPhoto modifyPhoto = new ModifyPhoto(this);
            this.Hide();
            modifyPhoto.Show();
        }

        private void deletePhotoButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql = "DELETE FROM Photos WHERE PhotoId = '"+photoId+"'" ;
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //LoadImagesFromFolder();
                //Album album=new Album();
                Album_Load(sender, e);
                /*Album_Load(sender, e);
                Event_Load_1(sender, e);*/
            }
            catch(Exception ex)
            {

            }
                /*HomePage homePage = new HomePage(this);
                this.Hide();
                homePage.Show();*/
        }
    }
}



