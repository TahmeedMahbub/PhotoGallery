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
using System.IO;

namespace Photo
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }


        private void Account_Load(object sender, EventArgs e)
        {
            loginPassCheckBox.Visible = false;
            regPassCheckBox.Visible = false;
            regConPassCheckBox.Visible = false;
        }
        private void DisableLogin()
        {
            loginEmailLabel.Visible = false;
            loginEmailTextBox.Visible = false;
            loginPasswordLabel.Visible = false;
            loginPasswordTextBox.Visible = false;
            loginButton.Visible = false;
            userLoginLabel.Visible = false;
            loginPassCheckBox.Visible = false;
        }
        private void EnableLogin()
        {
            loginEmailLabel.Visible = true;
            loginEmailTextBox.Visible = true;
            loginPasswordLabel.Visible = true;
            loginPasswordTextBox.Visible = true;
            loginButton.Visible = true;
            userLoginLabel.Visible = true;
            loginPassCheckBox.Visible = true;

        }
        private void DisableRegistration()
        {
            nameLabel.Visible = false;
            nameTextBox.Visible = false;
            emailLabel.Visible = false;
            emailTextBox.Visible = false;
            passwordLabel.Visible = false;
            passwordTextBox.Visible = false;
            confirmPasswordLabel.Visible = false;
            confirmPasswordTextBox.Visible = false;
            genderLabel.Visible = false;
            maleRadioButton.Visible = false;
            femaleRadioButton.Visible = false;
            dateOfBirthLabel.Visible = false;
            dateOfBirthTimePicker.Visible = false;
            termsConditionsCheckBox.Visible = false;
            registrationButton.Visible = false;
            registrationLabel.Visible = false;
            regConPassCheckBox.Visible = false;
            regPassCheckBox.Visible = false;
        }
        private void EnableRegistration()
        {
            nameLabel.Visible = true;
            nameTextBox.Visible = true;
            emailLabel.Visible = true;
            emailTextBox.Visible = true;
            passwordLabel.Visible = true;
            passwordTextBox.Visible = true;
            confirmPasswordLabel.Visible = true;
            confirmPasswordTextBox.Visible = true;
            genderLabel.Visible = true;
            maleRadioButton.Visible = true;
            femaleRadioButton.Visible = true;
            dateOfBirthLabel.Visible = true;
            dateOfBirthTimePicker.Visible = true;
            termsConditionsCheckBox.Visible = true;
            registrationButton.Visible = true;
            registrationLabel.Visible = true;
            regConPassCheckBox.Visible = true;
            regPassCheckBox.Visible = true;

        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableLogin();
            EnableRegistration();
        }

        private void logInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisableRegistration();
            EnableLogin();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void regPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (regPassCheckBox.Checked == false)
            {
                passwordTextBox.PasswordChar = '*';
            }
            else
                passwordTextBox.PasswordChar = '\0';
        }

        private void regConPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (regConPassCheckBox.Checked == false)
            {
                confirmPasswordTextBox.PasswordChar = '*';
            }
            else
                confirmPasswordTextBox.PasswordChar = '\0';
        }

        private void loginPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (loginPassCheckBox.Checked == false)
            {
                loginPasswordTextBox.PasswordChar = '*';
            }
            else
                loginPasswordTextBox.PasswordChar = '\0';
        }
        private void termsConditionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            

            //nothing can null
            if (nameTextBox.Text == "")
            {
                termsConditionsCheckBox.Checked = false;
                MessageBox.Show("Enter Name!");

            }
            else if (emailTextBox.Text == "")
            {
                termsConditionsCheckBox.Checked = false;
                MessageBox.Show("Enter Email!");

            }
            else if (passwordTextBox.Text == "")
            {
                termsConditionsCheckBox.Checked = false;
                MessageBox.Show("Enter Password!");

            }
            else if (confirmPasswordTextBox.Text == "")
            {
                termsConditionsCheckBox.Checked = false;
                MessageBox.Show("Enter Confirm Password!");

            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                termsConditionsCheckBox.Checked = false;
                MessageBox.Show("Enter Gender!");

            }
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {

                termsConditionsCheckBox.Checked = false;
                MessageBox.Show("Password not match!");

            }

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {

            try
            {
            if (termsConditionsCheckBox.Checked)
            {

                if (maleRadioButton.Checked)
                {
                    gender.Text = "Male";
                }
                else
                    gender.Text = "Female";


               


                

                //Database Logic
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();
                string sql = "INSERT INTO Users(Name, Email, Password, Gender, DateOfBirth, AccountCreated) VALUES('" + nameTextBox.Text + "', '" + emailTextBox.Text + "', '" + passwordTextBox.Text + "','" + gender.Text + "','" + dateOfBirthTimePicker.Text + "','" + accountCreatedDateTimePicker.Text + "')";
                SqlCommand command = new SqlCommand(sql, connection);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    
                    
                    getEmailLabel.Text = emailTextBox.Text;
                    HomePage homePage = new HomePage(this);
                    this.Hide();
                    homePage.Show();
                        MessageBox.Show("Congratulations " + nameTextBox.Text);
                    }
                else
                {
                    MessageBox.Show("Error");
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Must need to agree with our T/C");
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Email exists!");
            }
            
            
        }

        
        private void loginButton_Click(object sender, EventArgs e)
        {

            if (loginEmailTextBox.Text == "" || loginPasswordTextBox.Text == "")
            {
                MessageBox.Show("Enter Login Informations!");
            }
            else
            {
                
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();
                string sql = "SELECT * FROM Users WHERE Email = '" + loginEmailTextBox.Text + "' and password = '" + loginPasswordTextBox.Text+"'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    getNameLabel.Text = reader["Name"].ToString();
                    getEmailLabel.Text = reader["Email"].ToString();
                    MessageBox.Show("Hello "+getNameLabel.Text);
                    HomePage homepage = new HomePage(this);
                    this.Hide();
                    homepage.Show();
                    loginEmailTextBox.Text = loginPasswordTextBox.Text = "";

                }
                else
                {
                    MessageBox.Show("Entered wrong login information!");
                    

                }


            }
        }

        
    }
}////////////////////////////////////////////////////////////////////////////////rafid@gmail.com
