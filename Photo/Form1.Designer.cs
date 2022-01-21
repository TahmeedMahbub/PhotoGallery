
namespace Photo
{
    partial class HomePage
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
            this.goEventButton = new System.Windows.Forms.Button();
            this.existingComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExistingEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.createTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.createdEventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goEventButton
            // 
            this.goEventButton.Location = new System.Drawing.Point(449, 56);
            this.goEventButton.Name = "goEventButton";
            this.goEventButton.Size = new System.Drawing.Size(156, 65);
            this.goEventButton.TabIndex = 3;
            this.goEventButton.Text = "Go Event>>";
            this.goEventButton.UseVisualStyleBackColor = true;
            this.goEventButton.Visible = false;
            this.goEventButton.Click += new System.EventHandler(this.goEventButton_Click);
            // 
            // existingComboBox
            // 
            this.existingComboBox.FormattingEnabled = true;
            this.existingComboBox.Location = new System.Drawing.Point(84, 77);
            this.existingComboBox.Name = "existingComboBox";
            this.existingComboBox.Size = new System.Drawing.Size(323, 28);
            this.existingComboBox.TabIndex = 4;
            this.existingComboBox.Visible = false;
            this.existingComboBox.SelectedIndexChanged += new System.EventHandler(this.existingComboBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectOptionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectOptionToolStripMenuItem
            // 
            this.selectOptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem,
            this.openExistingEventToolStripMenuItem});
            this.selectOptionToolStripMenuItem.Name = "selectOptionToolStripMenuItem";
            this.selectOptionToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.selectOptionToolStripMenuItem.Text = "Select Option";
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.addEventToolStripMenuItem.Text = "Add Event";
            this.addEventToolStripMenuItem.Click += new System.EventHandler(this.addEventToolStripMenuItem_Click);
            // 
            // openExistingEventToolStripMenuItem
            // 
            this.openExistingEventToolStripMenuItem.Name = "openExistingEventToolStripMenuItem";
            this.openExistingEventToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.openExistingEventToolStripMenuItem.Text = "Open Existing Event";
            this.openExistingEventToolStripMenuItem.Click += new System.EventHandler(this.openExistingEventToolStripMenuItem_Click);
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.Location = new System.Drawing.Point(660, 47);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(128, 57);
            this.LogOutbutton.TabIndex = 6;
            this.LogOutbutton.Text = "Logout";
            this.LogOutbutton.UseVisualStyleBackColor = true;
            this.LogOutbutton.Click += new System.EventHandler(this.LogOutbutton_Click);
            // 
            // createTextBox
            // 
            this.createTextBox.Location = new System.Drawing.Point(84, 77);
            this.createTextBox.Name = "createTextBox";
            this.createTextBox.Size = new System.Drawing.Size(323, 26);
            this.createTextBox.TabIndex = 7;
            this.createTextBox.Visible = false;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(449, 58);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(156, 64);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create>>";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Visible = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // createdEventDateTimePicker
            // 
            this.createdEventDateTimePicker.Location = new System.Drawing.Point(468, 76);
            this.createdEventDateTimePicker.Name = "createdEventDateTimePicker";
            this.createdEventDateTimePicker.Size = new System.Drawing.Size(106, 26);
            this.createdEventDateTimePicker.TabIndex = 9;
            this.createdEventDateTimePicker.Visible = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.createTextBox);
            this.Controls.Add(this.LogOutbutton);
            this.Controls.Add(this.existingComboBox);
            this.Controls.Add(this.goEventButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.createdEventDateTimePicker);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button goEventButton;
        public System.Windows.Forms.ComboBox existingComboBox;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem selectOptionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem openExistingEventToolStripMenuItem;
        public System.Windows.Forms.Button LogOutbutton;
        public System.Windows.Forms.TextBox createTextBox;
        public System.Windows.Forms.Button createButton;
        public System.Windows.Forms.DateTimePicker createdEventDateTimePicker;
    }
}

