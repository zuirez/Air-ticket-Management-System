using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Ticket_Management_System
{
    public partial class AdminAdmin : Form
    {
        public AdminAdmin()
        {
            InitializeComponent();
        }

        // Clear input fields
        public void clearAdminSelection()
        {
            txtAdminAdminUserName.Text = "";
            txtAdminAdminPassword.Text = "";
            txtAdminAdminEmail.Text = "";
            txtAdminAdminAddress.Text = "";
            rdbAdminAdminMale.Checked = false;
            rdbAdminAdminFemale.Checked = false;
        }


        // Show Admin data in data grid view
        public void showAdminInfo()
        {
            txtAdminAdminUserId.Text = "Auto Generated";

            string query = "SELECT * FROM userInfo WHERE userIdType = 1;";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            dgvAdminAdmin.DataSource = result.Data;
            dgvAdminAdmin.Refresh();
            dgvAdminAdmin.ClearSelection();
        }


        // Form Load event
        private void AdminAdmin_Load(object sender, EventArgs e)
        {
            showAdminInfo();
        }


        // Search button click event
        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtAdminSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Error: Enter User Name/ User Id/ User Gender.");
                txtAdminSearch.Text = "";
                return;
            }

            string query = "SELECT * FROM userInfo WHERE userIdType = 1 AND (userName = '" + searchText + "' OR CAST(userId AS VARCHAR) = '" + searchText + "' OR userGender = '" + searchText + "');";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message); 
                txtAdminSearch.Text = "";
                return;
            }

            dgvAdminAdmin.DataSource = result.Data;
            dgvAdminAdmin.Refresh();
            dgvAdminAdmin.ClearSelection();

            txtAdminSearch.Text = "";
        }


        // Refresh button click event
        private void btnAdminRefresh_Click(object sender, EventArgs e)
        {
            txtAdminSearch.Text = "";
            clearAdminSelection();
            showAdminInfo();
        }


        // Add button click event
        private void btnAdminFlightAdd_Click(object sender, EventArgs e)
        {
            string userName = txtAdminAdminUserName.Text;
            string userPassword = txtAdminAdminPassword.Text;
            string userEmail = txtAdminAdminEmail.Text;
            string userAddress = txtAdminAdminAddress.Text;
            string userGender = "";

            if(rdbAdminAdminMale.Checked)
            {
                userGender = rdbAdminAdminMale.Text;
            }
            else if(rdbAdminAdminFemale.Checked)
            {
                userGender = rdbAdminAdminFemale.Text;
            }


            // Validating input fields
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Error: Enter user name.");
                return;
            }

            if(string.IsNullOrWhiteSpace(userPassword))
            {
                MessageBox.Show("Error: Enter user password.");
                return;
            }

            if(string.IsNullOrWhiteSpace(userEmail))
            {
                MessageBox.Show("Error: Enter user email.");
                return;
            }

            if(string.IsNullOrWhiteSpace(userAddress))
            {
                MessageBox.Show("Error: Enter user address.");
                return;
            }

            if (!rdbAdminAdminMale.Checked)
            {
                if (!rdbAdminAdminFemale.Checked)
                {
                    MessageBox.Show("Error: Select gender.");
                    return;
                }
            }


            // Validating that user name is unique
            string checkUserName = "SELECT userName FROM userInfo WHERE userName = '" + userName + "';";

            var checkFlightNoResult = DbHelper.GetQueryData(checkUserName);

            if (checkFlightNoResult.HasError)
            {
                MessageBox.Show("Error : " + checkFlightNoResult.Message);
                return;
            }

            if (checkFlightNoResult.Data.Rows.Count > 0)
            {
                MessageBox.Show("Error: User name already exists. Please select a different user name.");
                return;
            }


            //Inserting data into database
            try
            {
                string query = "INSERT INTO userInfo (userName, userPassword, userEmail, userAddress, userGender, userIdType) VALUES ('" + userName + "', '" + userPassword + "', '" + userEmail + "', '" + userAddress + "', '" + userGender + "', 1);";

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                MessageBox.Show("Admin added successfully.");

                clearAdminSelection();
                showAdminInfo();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error : " + exception.Message);
                return;
            }
        }


        // Update button click event
        private void btnAdminFlightUpdate_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(txtAdminAdminUserId.Text);
            string userName = txtAdminAdminUserName.Text;
            string userPassword = txtAdminAdminPassword.Text;
            string userEmail = txtAdminAdminEmail.Text;
            string userAddress = txtAdminAdminAddress.Text;
            string userGender = "";

            if (rdbAdminAdminMale.Checked)
            {
                userGender = rdbAdminAdminMale.Text;
            }
            else if (rdbAdminAdminFemale.Checked)
            {
                userGender = rdbAdminAdminFemale.Text;
            }

            // Validating input fields
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Error: Enter user name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(userPassword))
            {
                MessageBox.Show("Error: Enter user password.");
                return;
            }

            if (string.IsNullOrWhiteSpace(userEmail))
            {
                MessageBox.Show("Error: Enter user email.");
                return;
            }

            if (string.IsNullOrWhiteSpace(userAddress))
            {
                MessageBox.Show("Error: Enter user address.");
                return;
            }

            if (!rdbAdminAdminMale.Checked)
            {
                if (!rdbAdminAdminFemale.Checked)
                {
                    MessageBox.Show("Error: Select gender.");
                    return;
                }
            }


            // Validating that user name is unique
            string checkUserName = "SELECT userName FROM userInfo WHERE userName = '" + userName + "' AND userId != '"+ userId +"';";

            var checkFlightNoResult = DbHelper.GetQueryData(checkUserName);

            if (checkFlightNoResult.HasError)
            {
                MessageBox.Show("Error : " + checkFlightNoResult.Message);
                return;
            }

            if (checkFlightNoResult.Data.Rows.Count > 0)
            {
                MessageBox.Show("Error: User name already exists. Please select a different user name.");
                return;
            }


            // Updating data into database
            try
            {
                string query = "UPDATE userInfo SET userName = '" + userName + "', userPassword = '" + userPassword + "', userEmail = '" + userEmail + "', userAddress = '" + userAddress + "', userGender = '" + userGender + "' WHERE userId = '" + userId + "';";
                var result = DbHelper.ExecuteNonResultQuery(query);
                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                MessageBox.Show("Admin updated successfully.");

                clearAdminSelection();
                showAdminInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception.Message);
                return;
            }
        }


        // Delete button click event
        private void btnAdminFlightDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = Convert.ToString(txtAdminAdminUserId.Text);

                string query = "DELETE FROM userInfo WHERE userId = '" + userId + "';";

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                clearAdminSelection();
                showAdminInfo();

                MessageBox.Show("Message: Admin Deleted Successfully.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }


        // Data grid view cell double click event
        private void dgvAdminAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    dgvAdminAdmin.ClearSelection();
                    return;
                }

                int userId = Convert.ToInt32(dgvAdminAdmin.Rows[e.RowIndex].Cells["userId"].Value);

                string query = "SELECT * FROM userInfo WHERE userIdType = 1 AND userId = '" + userId + "'";

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                txtAdminAdminUserId.Text = Convert.ToString(result.Data.Rows[0]["userId"]);
                txtAdminAdminUserName.Text = Convert.ToString(result.Data.Rows[0]["userName"]);
                txtAdminAdminPassword.Text = Convert.ToString(result.Data.Rows[0]["userPassword"]);
                txtAdminAdminEmail.Text = Convert.ToString(result.Data.Rows[0]["userEmail"]);
                txtAdminAdminAddress.Text = Convert.ToString(result.Data.Rows[0]["userAddress"]);
                string gender = Convert.ToString(result.Data.Rows[0]["userGender"]);

                if (gender == rdbAdminAdminMale.Text)
                {
                    rdbAdminAdminMale.Checked = true;
                }
                else if (gender == rdbAdminAdminFemale.Text)
                {
                    rdbAdminAdminFemale.Checked = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }
    }
}
