using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo
{
    public partial class ModifyPhoto : Form
    {
        public string userName;
        public string userEmail;
        public int photoId;
        public string importance;
        public string photoStory;
        public string modDate;


        public ModifyPhoto()
        {
            InitializeComponent();
        }
        Album album;
        public ModifyPhoto(Album album)
        {
            this.album = album;
            this.userName = album.userName;
            this.userEmail = album.userEmail;
            this.photoId = album.photoId;
            this.photoStory = album.photoStoryLabel.Text;
            //this.fileLocationLabel.Text = album.file;
            this.importance = album.label2.Text;
            

        }
        private void logOutButton_Click(object sender, EventArgs e)
        {

        }

        private void ModifyPhoto_Load(object sender, EventArgs e)
        {

        }
    }
}
