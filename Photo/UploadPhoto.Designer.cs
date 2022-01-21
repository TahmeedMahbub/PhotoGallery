
namespace Photo
{
    partial class UploadPhoto
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
            this.fileLocationLabel = new System.Windows.Forms.Label();
            this.fileButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.photoStoryTextBox = new System.Windows.Forms.TextBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.createdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.highRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.moderateRadioButton = new System.Windows.Forms.RadioButton();
            this.lessImportantRadioButton = new System.Windows.Forms.RadioButton();
            this.imporanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileLocationLabel
            // 
            this.fileLocationLabel.AutoSize = true;
            this.fileLocationLabel.Location = new System.Drawing.Point(299, 246);
            this.fileLocationLabel.Name = "fileLocationLabel";
            this.fileLocationLabel.Size = new System.Drawing.Size(173, 20);
            this.fileLocationLabel.TabIndex = 0;
            this.fileLocationLabel.Text = "Select Image From File";
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(488, 236);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(82, 42);
            this.fileButton.TabIndex = 1;
            this.fileButton.Text = "File";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(687, 13);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(103, 46);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(50, 361);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(98, 47);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "<<Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(260, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // photoStoryTextBox
            // 
            this.photoStoryTextBox.Enabled = false;
            this.photoStoryTextBox.Location = new System.Drawing.Point(223, 302);
            this.photoStoryTextBox.Name = "photoStoryTextBox";
            this.photoStoryTextBox.Size = new System.Drawing.Size(533, 26);
            this.photoStoryTextBox.TabIndex = 5;
            // 
            // uploadButton
            // 
            this.uploadButton.Enabled = false;
            this.uploadButton.Location = new System.Drawing.Point(655, 361);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(101, 47);
            this.uploadButton.TabIndex = 6;
            this.uploadButton.Text = "Upload>>";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(46, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Photo Story (Optional)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // createdDateTimePicker
            // 
            this.createdDateTimePicker.Location = new System.Drawing.Point(353, 369);
            this.createdDateTimePicker.Name = "createdDateTimePicker";
            this.createdDateTimePicker.Size = new System.Drawing.Size(95, 26);
            this.createdDateTimePicker.TabIndex = 7;
            this.createdDateTimePicker.Visible = false;
            // 
            // highRadioButton
            // 
            this.highRadioButton.AutoSize = true;
            this.highRadioButton.Location = new System.Drawing.Point(23, 69);
            this.highRadioButton.Name = "highRadioButton";
            this.highRadioButton.Size = new System.Drawing.Size(67, 24);
            this.highRadioButton.TabIndex = 8;
            this.highRadioButton.Text = "High";
            this.highRadioButton.UseVisualStyleBackColor = true;
            this.highRadioButton.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importance:";
            this.label1.Visible = false;
            // 
            // moderateRadioButton
            // 
            this.moderateRadioButton.AutoSize = true;
            this.moderateRadioButton.Checked = true;
            this.moderateRadioButton.Location = new System.Drawing.Point(23, 110);
            this.moderateRadioButton.Name = "moderateRadioButton";
            this.moderateRadioButton.Size = new System.Drawing.Size(102, 24);
            this.moderateRadioButton.TabIndex = 9;
            this.moderateRadioButton.TabStop = true;
            this.moderateRadioButton.Text = "Moderate";
            this.moderateRadioButton.UseVisualStyleBackColor = true;
            this.moderateRadioButton.Visible = false;
            this.moderateRadioButton.CheckedChanged += new System.EventHandler(this.moderateRadioButton_CheckedChanged);
            // 
            // lessImportantRadioButton
            // 
            this.lessImportantRadioButton.AutoSize = true;
            this.lessImportantRadioButton.Location = new System.Drawing.Point(23, 154);
            this.lessImportantRadioButton.Name = "lessImportantRadioButton";
            this.lessImportantRadioButton.Size = new System.Drawing.Size(141, 24);
            this.lessImportantRadioButton.TabIndex = 10;
            this.lessImportantRadioButton.Text = "Less Important";
            this.lessImportantRadioButton.UseVisualStyleBackColor = true;
            this.lessImportantRadioButton.Visible = false;
            // 
            // imporanceLabel
            // 
            this.imporanceLabel.AutoSize = true;
            this.imporanceLabel.Location = new System.Drawing.Point(130, 71);
            this.imporanceLabel.Name = "imporanceLabel";
            this.imporanceLabel.Size = new System.Drawing.Size(0, 20);
            this.imporanceLabel.TabIndex = 11;
            this.imporanceLabel.Visible = false;
            // 
            // UploadPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imporanceLabel);
            this.Controls.Add(this.lessImportantRadioButton);
            this.Controls.Add(this.moderateRadioButton);
            this.Controls.Add(this.highRadioButton);
            this.Controls.Add(this.createdDateTimePicker);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.photoStoryTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileLocationLabel);
            this.Name = "UploadPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UploadPhoto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UploadPhoto_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label fileLocationLabel;
        public System.Windows.Forms.Button fileButton;
        public System.Windows.Forms.Button logOutButton;
        public System.Windows.Forms.Button backButton;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox photoStoryTextBox;
        public System.Windows.Forms.Button uploadButton;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.DateTimePicker createdDateTimePicker;
        public System.Windows.Forms.RadioButton highRadioButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton moderateRadioButton;
        public System.Windows.Forms.RadioButton lessImportantRadioButton;
        public System.Windows.Forms.Label imporanceLabel;
    }
}