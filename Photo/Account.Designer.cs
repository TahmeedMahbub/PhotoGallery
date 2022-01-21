
namespace Photo
{
    partial class Account
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userAccountManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.loginEmailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.termsConditionsCheckBox = new System.Windows.Forms.CheckBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.loginEmailTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.dateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.accountCreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.getEmailLabel = new System.Windows.Forms.Label();
            this.getNameLabel = new System.Windows.Forms.Label();
            this.regPassCheckBox = new System.Windows.Forms.CheckBox();
            this.regConPassCheckBox = new System.Windows.Forms.CheckBox();
            this.loginPassCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAccountManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userAccountManagementToolStripMenuItem
            // 
            this.userAccountManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logInToolStripMenuItem1});
            this.userAccountManagementToolStripMenuItem.Name = "userAccountManagementToolStripMenuItem";
            this.userAccountManagementToolStripMenuItem.Size = new System.Drawing.Size(243, 32);
            this.userAccountManagementToolStripMenuItem.Text = "User Account Management";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.loginToolStripMenuItem.Text = "Registration";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem1
            // 
            this.logInToolStripMenuItem1.Name = "logInToolStripMenuItem1";
            this.logInToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.logInToolStripMenuItem1.Text = "Log in";
            this.logInToolStripMenuItem1.Click += new System.EventHandler(this.logInToolStripMenuItem1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(191, 73);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(242, 26);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(191, 171);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(242, 26);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Visible = false;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(191, 219);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(242, 26);
            this.confirmPasswordTextBox.TabIndex = 3;
            this.confirmPasswordTextBox.Visible = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(191, 123);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(242, 26);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 79);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            this.nameLabel.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(22, 129);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 20);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
            this.emailLabel.Visible = false;
            // 
            // loginEmailLabel
            // 
            this.loginEmailLabel.AutoSize = true;
            this.loginEmailLabel.Location = new System.Drawing.Point(589, 132);
            this.loginEmailLabel.Name = "loginEmailLabel";
            this.loginEmailLabel.Size = new System.Drawing.Size(48, 20);
            this.loginEmailLabel.TabIndex = 8;
            this.loginEmailLabel.Text = "Email";
            this.loginEmailLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(22, 177);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Visible = false;
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Location = new System.Drawing.Point(580, 202);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(78, 20);
            this.loginPasswordLabel.TabIndex = 8;
            this.loginPasswordLabel.Text = "Password";
            this.loginPasswordLabel.Visible = false;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(22, 225);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(137, 20);
            this.confirmPasswordLabel.TabIndex = 8;
            this.confirmPasswordLabel.Text = "Confirm Password";
            this.confirmPasswordLabel.Visible = false;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(22, 272);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(63, 20);
            this.genderLabel.TabIndex = 8;
            this.genderLabel.Text = "Gender";
            this.genderLabel.Visible = false;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(22, 325);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(102, 20);
            this.dateOfBirthLabel.TabIndex = 8;
            this.dateOfBirthLabel.Text = "Date Of Birth";
            this.dateOfBirthLabel.Visible = false;
            // 
            // termsConditionsCheckBox
            // 
            this.termsConditionsCheckBox.AutoSize = true;
            this.termsConditionsCheckBox.Location = new System.Drawing.Point(100, 363);
            this.termsConditionsCheckBox.Name = "termsConditionsCheckBox";
            this.termsConditionsCheckBox.Size = new System.Drawing.Size(238, 24);
            this.termsConditionsCheckBox.TabIndex = 9;
            this.termsConditionsCheckBox.Text = "Agree Terms And Conditions";
            this.termsConditionsCheckBox.UseVisualStyleBackColor = true;
            this.termsConditionsCheckBox.Visible = false;
            this.termsConditionsCheckBox.CheckedChanged += new System.EventHandler(this.termsConditionsCheckBox_CheckedChanged);
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(128, 393);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(197, 44);
            this.registrationButton.TabIndex = 10;
            this.registrationButton.Text = "Registration";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Visible = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // loginEmailTextBox
            // 
            this.loginEmailTextBox.Location = new System.Drawing.Point(481, 155);
            this.loginEmailTextBox.Name = "loginEmailTextBox";
            this.loginEmailTextBox.Size = new System.Drawing.Size(282, 26);
            this.loginEmailTextBox.TabIndex = 11;
            this.loginEmailTextBox.Visible = false;
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Location = new System.Drawing.Point(481, 225);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '*';
            this.loginPasswordTextBox.Size = new System.Drawing.Size(282, 26);
            this.loginPasswordTextBox.TabIndex = 12;
            this.loginPasswordTextBox.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(537, 272);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(177, 56);
            this.loginButton.TabIndex = 13;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Visible = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(218, 268);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(68, 24);
            this.maleRadioButton.TabIndex = 17;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.Visible = false;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(322, 268);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(87, 24);
            this.femaleRadioButton.TabIndex = 18;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.Visible = false;
            // 
            // dateOfBirthTimePicker
            // 
            this.dateOfBirthTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthTimePicker.Location = new System.Drawing.Point(191, 318);
            this.dateOfBirthTimePicker.Name = "dateOfBirthTimePicker";
            this.dateOfBirthTimePicker.Size = new System.Drawing.Size(242, 26);
            this.dateOfBirthTimePicker.TabIndex = 19;
            this.dateOfBirthTimePicker.Visible = false;
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoginLabel.Location = new System.Drawing.Point(73, 165);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(300, 80);
            this.userLoginLabel.TabIndex = 20;
            this.userLoginLabel.Text = "User Login";
            this.userLoginLabel.Visible = false;
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold);
            this.registrationLabel.Location = new System.Drawing.Point(451, 165);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(349, 80);
            this.registrationLabel.TabIndex = 21;
            this.registrationLabel.Text = "Registration";
            this.registrationLabel.Visible = false;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(29, 271);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(0, 20);
            this.gender.TabIndex = 22;
            this.gender.Visible = false;
            // 
            // accountCreatedDateTimePicker
            // 
            this.accountCreatedDateTimePicker.Location = new System.Drawing.Point(284, 318);
            this.accountCreatedDateTimePicker.Name = "accountCreatedDateTimePicker";
            this.accountCreatedDateTimePicker.Size = new System.Drawing.Size(73, 26);
            this.accountCreatedDateTimePicker.TabIndex = 23;
            this.accountCreatedDateTimePicker.Visible = false;
            // 
            // getEmailLabel
            // 
            this.getEmailLabel.AutoSize = true;
            this.getEmailLabel.Location = new System.Drawing.Point(498, 205);
            this.getEmailLabel.Name = "getEmailLabel";
            this.getEmailLabel.Size = new System.Drawing.Size(51, 20);
            this.getEmailLabel.TabIndex = 24;
            this.getEmailLabel.Text = "label1";
            this.getEmailLabel.Visible = false;
            // 
            // getNameLabel
            // 
            this.getNameLabel.AutoSize = true;
            this.getNameLabel.Location = new System.Drawing.Point(234, 78);
            this.getNameLabel.Name = "getNameLabel";
            this.getNameLabel.Size = new System.Drawing.Size(51, 20);
            this.getNameLabel.TabIndex = 25;
            this.getNameLabel.Text = "label1";
            this.getNameLabel.Visible = false;
            // 
            // regPassCheckBox
            // 
            this.regPassCheckBox.AutoSize = true;
            this.regPassCheckBox.Location = new System.Drawing.Point(410, 176);
            this.regPassCheckBox.Name = "regPassCheckBox";
            this.regPassCheckBox.Size = new System.Drawing.Size(22, 21);
            this.regPassCheckBox.TabIndex = 26;
            this.regPassCheckBox.UseVisualStyleBackColor = true;
            this.regPassCheckBox.Visible = false;
            this.regPassCheckBox.CheckedChanged += new System.EventHandler(this.regPassCheckBox_CheckedChanged);
            // 
            // regConPassCheckBox
            // 
            this.regConPassCheckBox.AutoSize = true;
            this.regConPassCheckBox.Location = new System.Drawing.Point(410, 224);
            this.regConPassCheckBox.Name = "regConPassCheckBox";
            this.regConPassCheckBox.Size = new System.Drawing.Size(22, 21);
            this.regConPassCheckBox.TabIndex = 27;
            this.regConPassCheckBox.UseVisualStyleBackColor = true;
            this.regConPassCheckBox.Visible = false;
            this.regConPassCheckBox.CheckedChanged += new System.EventHandler(this.regConPassCheckBox_CheckedChanged);
            // 
            // loginPassCheckBox
            // 
            this.loginPassCheckBox.AutoSize = true;
            this.loginPassCheckBox.Location = new System.Drawing.Point(740, 230);
            this.loginPassCheckBox.Name = "loginPassCheckBox";
            this.loginPassCheckBox.Size = new System.Drawing.Size(22, 21);
            this.loginPassCheckBox.TabIndex = 28;
            this.loginPassCheckBox.UseVisualStyleBackColor = true;
            this.loginPassCheckBox.Visible = false;
            this.loginPassCheckBox.CheckedChanged += new System.EventHandler(this.loginPassCheckBox_CheckedChanged);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regConPassCheckBox);
            this.Controls.Add(this.regPassCheckBox);
            this.Controls.Add(this.loginPassCheckBox);
            this.Controls.Add(this.dateOfBirthTimePicker);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginEmailTextBox);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.termsConditionsCheckBox);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.loginPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginEmailLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.accountCreatedDateTimePicker);
            this.Controls.Add(this.getEmailLabel);
            this.Controls.Add(this.getNameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.loginPasswordTextBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem userAccountManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem1;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox passwordTextBox;
        public System.Windows.Forms.TextBox confirmPasswordTextBox;
        public System.Windows.Forms.TextBox emailTextBox;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.Label loginEmailLabel;
        public System.Windows.Forms.Label passwordLabel;
        public System.Windows.Forms.Label loginPasswordLabel;
        public System.Windows.Forms.Label confirmPasswordLabel;
        public System.Windows.Forms.Label genderLabel;
        public System.Windows.Forms.Label dateOfBirthLabel;
        public System.Windows.Forms.CheckBox termsConditionsCheckBox;
        public System.Windows.Forms.Button registrationButton;
        public System.Windows.Forms.TextBox loginEmailTextBox;
        public System.Windows.Forms.TextBox loginPasswordTextBox;
        public System.Windows.Forms.Button loginButton;
        public System.Windows.Forms.RadioButton maleRadioButton;
        public System.Windows.Forms.RadioButton femaleRadioButton;
        public System.Windows.Forms.DateTimePicker dateOfBirthTimePicker;
        public System.Windows.Forms.Label userLoginLabel;
        public System.Windows.Forms.Label registrationLabel;
        public System.Windows.Forms.Label gender;
        public System.Windows.Forms.DateTimePicker accountCreatedDateTimePicker;
        public System.Windows.Forms.Label getEmailLabel;
        public System.Windows.Forms.Label getNameLabel;
        private System.Windows.Forms.CheckBox regPassCheckBox;
        private System.Windows.Forms.CheckBox regConPassCheckBox;
        private System.Windows.Forms.CheckBox loginPassCheckBox;
    }
}