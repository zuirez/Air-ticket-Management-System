using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Ticket_Management_System
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

        }


        //Method to clear all fields after SignUp
        public void clearSignUpSelection()
        {
            txtUserNameSignUp.Text = "";
            txtPasswordSignUp.Text = "";
            txtEmailSignUp.Text = "";
            txtAddressSignUp.Text = "";
            rdbMaleSignUp.Checked = false;
            rdbFemaleSignUp.Checked = false;
        }


        //Method to clear all fields after LogIn
        public void clearLogInSelection()
        {
            txtUserNameLogIn.Text = "";
            txtPasswordLogIn.Text = "";
        }


        //SignUp Button Click Event
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String userName = txtUserNameSignUp.Text;
            String password = txtPasswordSignUp.Text;
            String email = txtEmailSignUp.Text;
            String address = txtAddressSignUp.Text;
            String gender = "";


            //Storing gender according to selected radio button
            if (rdbMaleSignUp.Checked)
            {
                gender += rdbMaleSignUp.Text;
            }
            if (rdbFemaleSignUp.Checked)
            {
                gender += rdbFemaleSignUp.Text;
            }


            //Checking if any field is empty
            if(string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Error : Enter username");
                return;
            }
            if(string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Error : Enter Password");
                return;
            }
            if(string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Error : Enter Email");
                return;
            }
            if(string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Error : Enter Address");
                return;
            }
            if(string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Error : Please choose a gender");
                return;
            }


            //Database Connection and Insertion for SignUp
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-MH8FO6G;Initial Catalog=Air.Ticket.Management;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

                con.Open();

                String queryCheck = "SELECT * FROM UserInfo WHERE userName = '" + userName + "' AND userPassword = '" + password + "'";
                SqlCommand cmdCheck = new SqlCommand(queryCheck, con);
                SqlDataReader reader = cmdCheck.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Error : User already exists. Please Log In.");
                    clearSignUpSelection();
                    reader.Close();
                    return;
                }
                else
                {
                    reader.Close();
                    String query = "INSERT INTO UserInfo VALUES ('" + userName + "', '" + password + "', '" + email + "', '" + address + "', '" + gender + "', 3);\r\n";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    //SignUp Success Message
                    MessageBox.Show("Message : \n\nSign Up Successful.\nNow you can Log In.");
                    clearSignUpSelection();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception.Message);
            }
        }


        //LogIn Button Click Event
        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            string userName = txtUserNameLogIn.Text;
            string password = txtPasswordLogIn.Text;

            //Checking if any field is empty
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Error : Enter username");
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Error : Enter Password");
                return;
            }

            //SignUp Success Message
            MessageBox.Show($"Message : \n\nLog In Successful.\nWelcome {userName}.");
            clearLogInSelection();
        }
    }
}