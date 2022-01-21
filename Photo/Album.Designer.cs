
namespace Photo
{
    partial class Album
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addPhotoButton = new System.Windows.Forms.Button();
            this.lastModDateLabel = new System.Windows.Forms.Label();
            this.createdDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.photoStoryLabel = new System.Windows.Forms.Label();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.photoList = new System.Windows.Forms.ListView();
            this.selectedPhoto = new System.Windows.Forms.PictureBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.modifyPhotoButton = new System.Windows.Forms.Button();
            this.deletePhotoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // addPhotoButton
            // 
            this.addPhotoButton.Location = new System.Drawing.Point(662, 55);
            this.addPhotoButton.Name = "addPhotoButton";
            this.addPhotoButton.Size = new System.Drawing.Size(121, 38);
            this.addPhotoButton.TabIndex = 24;
            this.addPhotoButton.Text = "Add Photo";
            this.addPhotoButton.UseVisualStyleBackColor = true;
            this.addPhotoButton.Click += new System.EventHandler(this.addPhotoButton_Click_1);
            // 
            // lastModDateLabel
            // 
            this.lastModDateLabel.AutoSize = true;
            this.lastModDateLabel.Location = new System.Drawing.Point(665, 415);
            this.lastModDateLabel.Name = "lastModDateLabel";
            this.lastModDateLabel.Size = new System.Drawing.Size(36, 20);
            this.lastModDateLabel.TabIndex = 23;
            this.lastModDateLabel.Text = "Any";
            // 
            // createdDate
            // 
            this.createdDate.AutoSize = true;
            this.createdDate.Location = new System.Drawing.Point(661, 328);
            this.createdDate.Name = "createdDate";
            this.createdDate.Size = new System.Drawing.Size(36, 20);
            this.createdDate.TabIndex = 22;
            this.createdDate.Text = "Any";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Any";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Photo List:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(661, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Modified Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(661, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Created Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(661, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Importance:";
            // 
            // photoStoryLabel
            // 
            this.photoStoryLabel.AutoSize = true;
            this.photoStoryLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoStoryLabel.Location = new System.Drawing.Point(149, 401);
            this.photoStoryLabel.Name = "photoStoryLabel";
            this.photoStoryLabel.Size = new System.Drawing.Size(0, 28);
            this.photoStoryLabel.TabIndex = 16;
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.Location = new System.Drawing.Point(379, 17);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(170, 32);
            this.eventNameLabel.TabIndex = 15;
            this.eventNameLabel.Text = "Event Name";
            this.eventNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(149, 17);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 36);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "<<Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(662, 13);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(121, 36);
            this.logoutButton.TabIndex = 13;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // photoList
            // 
            this.photoList.HideSelection = false;
            this.photoList.Location = new System.Drawing.Point(18, 44);
            this.photoList.Name = "photoList";
            this.photoList.Size = new System.Drawing.Size(111, 394);
            this.photoList.TabIndex = 12;
            this.photoList.UseCompatibleStateImageBehavior = false;
            this.photoList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.photoList_ItemSelectionChanged);
            this.photoList.SelectedIndexChanged += new System.EventHandler(this.photoList_SelectedIndexChanged_1);
            // 
            // selectedPhoto
            // 
            this.selectedPhoto.Location = new System.Drawing.Point(149, 63);
            this.selectedPhoto.Name = "selectedPhoto";
            this.selectedPhoto.Size = new System.Drawing.Size(502, 326);
            this.selectedPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedPhoto.TabIndex = 11;
            this.selectedPhoto.TabStop = false;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // modifyPhotoButton
            // 
            this.modifyPhotoButton.Location = new System.Drawing.Point(662, 99);
            this.modifyPhotoButton.Name = "modifyPhotoButton";
            this.modifyPhotoButton.Size = new System.Drawing.Size(121, 41);
            this.modifyPhotoButton.TabIndex = 25;
            this.modifyPhotoButton.Text = "Modify Photo";
            this.modifyPhotoButton.UseVisualStyleBackColor = true;
            this.modifyPhotoButton.Click += new System.EventHandler(this.modifyPhotoButton_Click);
            // 
            // deletePhotoButton
            // 
            this.deletePhotoButton.Location = new System.Drawing.Point(662, 146);
            this.deletePhotoButton.Name = "deletePhotoButton";
            this.deletePhotoButton.Size = new System.Drawing.Size(121, 42);
            this.deletePhotoButton.TabIndex = 26;
            this.deletePhotoButton.Text = "Delete Photo";
            this.deletePhotoButton.UseVisualStyleBackColor = true;
            this.deletePhotoButton.Click += new System.EventHandler(this.deletePhotoButton_Click);
            // 
            // Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletePhotoButton);
            this.Controls.Add(this.modifyPhotoButton);
            this.Controls.Add(this.addPhotoButton);
            this.Controls.Add(this.lastModDateLabel);
            this.Controls.Add(this.createdDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.photoStoryLabel);
            this.Controls.Add(this.eventNameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.photoList);
            this.Controls.Add(this.selectedPhoto);
            this.Name = "Album";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Album";
            this.Load += new System.EventHandler(this.Album_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectedPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button addPhotoButton;
        public System.Windows.Forms.Label lastModDateLabel;
        public System.Windows.Forms.Label createdDate;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label photoStoryLabel;
        public System.Windows.Forms.Label eventNameLabel;
        public System.Windows.Forms.Button backButton;
        public System.Windows.Forms.Button logoutButton;
        public System.Windows.Forms.ListView photoList;
        public System.Windows.Forms.PictureBox selectedPhoto;
        public System.Windows.Forms.ImageList imageList;
        public System.Windows.Forms.Button modifyPhotoButton;
        public System.Windows.Forms.Button deletePhotoButton;
    }
}