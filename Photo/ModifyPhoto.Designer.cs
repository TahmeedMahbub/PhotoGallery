
namespace Photo
{
    partial class ModifyPhoto
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
            this.imporanceLabel = new System.Windows.Forms.Label();
            this.lessImportantRadioButton = new System.Windows.Forms.RadioButton();
            this.moderateRadioButton = new System.Windows.Forms.RadioButton();
            this.highRadioButton = new System.Windows.Forms.RadioButton();
            this.modifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uploadButton = new System.Windows.Forms.Button();
            this.photoStoryTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.fileButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileLocationLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imporanceLabel
            // 
            this.imporanceLabel.AutoSize = true;
            this.imporanceLabel.Location = new System.Drawing.Point(15, 209);
            this.imporanceLabel.Name = "imporanceLabel";
            this.imporanceLabel.Size = new System.Drawing.Size(88, 20);
            this.imporanceLabel.TabIndex = 25;
            this.imporanceLabel.Text = "importance";
            this.imporanceLabel.Visible = false;
            // 
            // lessImportantRadioButton
            // 
            this.lessImportantRadioButton.AutoSize = true;
            this.lessImportantRadioButton.Location = new System.Drawing.Point(19, 169);
            this.lessImportantRadioButton.Name = "lessImportantRadioButton";
            this.lessImportantRadioButton.Size = new System.Drawing.Size(141, 24);
            this.lessImportantRadioButton.TabIndex = 24;
            this.lessImportantRadioButton.Text = "Less Important";
            this.lessImportantRadioButton.UseVisualStyleBackColor = true;
            this.lessImportantRadioButton.Visible = false;
            // 
            // moderateRadioButton
            // 
            this.moderateRadioButton.AutoSize = true;
            this.moderateRadioButton.Checked = true;
            this.moderateRadioButton.Location = new System.Drawing.Point(19, 125);
            this.moderateRadioButton.Name = "moderateRadioButton";
            this.moderateRadioButton.Size = new System.Drawing.Size(102, 24);
            this.moderateRadioButton.TabIndex = 23;
            this.moderateRadioButton.TabStop = true;
            this.moderateRadioButton.Text = "Moderate";
            this.moderateRadioButton.UseVisualStyleBackColor = true;
            this.moderateRadioButton.Visible = false;
            // 
            // highRadioButton
            // 
            this.highRadioButton.AutoSize = true;
            this.highRadioButton.Location = new System.Drawing.Point(19, 84);
            this.highRadioButton.Name = "highRadioButton";
            this.highRadioButton.Size = new System.Drawing.Size(67, 24);
            this.highRadioButton.TabIndex = 22;
            this.highRadioButton.Text = "High";
            this.highRadioButton.UseVisualStyleBackColor = true;
            this.highRadioButton.Visible = false;
            // 
            // modifiedDateTimePicker
            // 
            this.modifiedDateTimePicker.Location = new System.Drawing.Point(349, 384);
            this.modifiedDateTimePicker.Name = "modifiedDateTimePicker";
            this.modifiedDateTimePicker.Size = new System.Drawing.Size(95, 26);
            this.modifiedDateTimePicker.TabIndex = 21;
            this.modifiedDateTimePicker.Visible = false;
            // 
            // uploadButton
            // 
            this.uploadButton.Enabled = false;
            this.uploadButton.Location = new System.Drawing.Point(651, 376);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(101, 47);
            this.uploadButton.TabIndex = 20;
            this.uploadButton.Text = "Upload>>";
            this.uploadButton.UseVisualStyleBackColor = true;
            // 
            // photoStoryTextBox
            // 
            this.photoStoryTextBox.Enabled = false;
            this.photoStoryTextBox.Location = new System.Drawing.Point(219, 317);
            this.photoStoryTextBox.Name = "photoStoryTextBox";
            this.photoStoryTextBox.Size = new System.Drawing.Size(533, 26);
            this.photoStoryTextBox.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(256, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(46, 376);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(98, 47);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "<<Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(683, 28);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(103, 46);
            this.logOutButton.TabIndex = 16;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(484, 251);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(82, 42);
            this.fileButton.TabIndex = 15;
            this.fileButton.Text = "File";
            this.fileButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(42, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Photo Story (Optional)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Importance:";
            this.label1.Visible = false;
            // 
            // fileLocationLabel
            // 
            this.fileLocationLabel.AutoSize = true;
            this.fileLocationLabel.Location = new System.Drawing.Point(295, 261);
            this.fileLocationLabel.Name = "fileLocationLabel";
            this.fileLocationLabel.Size = new System.Drawing.Size(173, 20);
            this.fileLocationLabel.TabIndex = 14;
            this.fileLocationLabel.Text = "Select Image From File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ModifyPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imporanceLabel);
            this.Controls.Add(this.lessImportantRadioButton);
            this.Controls.Add(this.moderateRadioButton);
            this.Controls.Add(this.highRadioButton);
            this.Controls.Add(this.modifiedDateTimePicker);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.photoStoryTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileLocationLabel);
            this.Name = "ModifyPhoto";
            this.Text = "ModifyPhoto";
            this.Load += new System.EventHandler(this.ModifyPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imporanceLabel;
        private System.Windows.Forms.RadioButton lessImportantRadioButton;
        private System.Windows.Forms.RadioButton moderateRadioButton;
        private System.Windows.Forms.RadioButton highRadioButton;
        private System.Windows.Forms.DateTimePicker modifiedDateTimePicker;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.TextBox photoStoryTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileLocationLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}