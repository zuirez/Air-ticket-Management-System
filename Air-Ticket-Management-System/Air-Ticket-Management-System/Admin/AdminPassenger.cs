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
    public partial class AdminPassenger : Form
    {
        public AdminPassenger()
        {
            InitializeComponent();
        }


        // Clear Input Fields
        public void clearPassengerSelection()
        {
            txtAdminPassengerUserName.Text = "";
            txtAdminPassengerPassword.Text = "";
            txtAdminPassengerEmail.Text = "";
            txtAdminPassengerAddress.Text = "";
            rdbAdminPassengerMale.Checked = false;
            rdbAdminPassengerFemale.Checked = false;
        }


        // Show Employee data in data grid view
        public void showPassengerInfo()
        {
            txtAdminPassengerUserId.Text = "Auto Generated";

            string query = "SELECT * FROM userInfo WHERE userIdType = 3;";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            dgvAdminPassenger.DataSource = result.Data;
            dgvAdminPassenger.Refresh();
            dgvAdminPassenger.ClearSelection();
        }


        // Form load event
        private void AdminPassenger_Load(object sender, EventArgs e)
        {
            showPassengerInfo();
        }


        // Search button click event
        private void btnPassengerSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtPassengerSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Error: Enter User Name/ User Id/ User Gender.");
                txtPassengerSearch.Text = "";
                return;
            }

            string query = "SELECT * FROM userInfo WHERE userIdType = 3 AND (userName = '" + searchText + "' OR CAST(userId AS VARCHAR) = '" + searchText + "' OR userGender = '" + searchText + "');";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                txtPassengerSearch.Text = "";
                return;
            }

            dgvAdminPassenger.DataSource = result.Data;
            dgvAdminPassenger.Refresh();
            dgvAdminPassenger.ClearSelection();

            txtPassengerSearch.Text = "";
        }


        // Refresh button click event
        private void btnPassengerRefresh_Click(object sender, EventArgs e)
        {
            txtPassengerSearch.Text = "";
            clearPassengerSelection();
            showPassengerInfo();
        }


        // Add button click event
        private void btnAdminPassengerAdd_Click(object sender, EventArgs e)
        {
            string userName = txtAdminPassengerUserName.Text;
            string userPassword = txtAdminPassengerPassword.Text;
            string userEmail = txtAdminPassengerEmail.Text;
            string userAddress = txtAdminPassengerAddress.Text;
            string userGender = "";

            if (rdbAdminPassengerMale.Checked)
            {
                userGender = rdbAdminPassengerMale.Text;
            }
            else if (rdbAdminPassengerFemale.Checked)
            {
                userGender = rdbAdminPassengerFemale.Text;
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

            if (!rdbAdminPassengerMale.Checked)
            {
                if (!rdbAdminPassengerFemale.Checked)
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
                string query = "INSERT INTO userInfo (userName, userPassword, userEmail, userAddress, userGender, userIdType) VALUES ('" + userName + "', '" + userPassword + "', '" + userEmail + "', '" + userAddress + "', '" + userGender + "', 3);";

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                MessageBox.Show("Passenger added successfully.");

                clearPassengerSelection();
                showPassengerInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception.Message);
                return;
            }
        }


        // Update button click event
        private void btnAdminPassengerUpdate_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(txtAdminPassengerUserId.Text);
            string userName = txtAdminPassengerUserName.Text;
            string userPassword = txtAdminPassengerPassword.Text;
            string userEmail = txtAdminPassengerEmail.Text;
            string userAddress = txtAdminPassengerAddress.Text;
            string userGender = "";

            if (rdbAdminPassengerMale.Checked)
            {
                userGender = rdbAdminPassengerMale.Text;
            }
            else if (rdbAdminPassengerFemale.Checked)
            {
                userGender = rdbAdminPassengerFemale.Text;
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

            if (!rdbAdminPassengerMale.Checked)
            {
                if (!rdbAdminPassengerFemale.Checked)
                {
                    MessageBox.Show("Error: Select gender.");
                    return;
                }
            }


            // Validating that user name is unique
            string checkUserName = "SELECT userName FROM userInfo WHERE userName = '" + userName + "' AND userId != '" + userId + "';";

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

                MessageBox.Show("Passenger updated successfully.");

                clearPassengerSelection();
                showPassengerInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception.Message);
                return;
            }
        }


        // Delete button click event
        private void btnAdminPassengerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = Convert.ToString(txtAdminPassengerUserId.Text);

                string query = "DELETE FROM userInfo WHERE userId = '" + userId + "';";

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                clearPassengerSelection();
                showPassengerInfo();

                MessageBox.Show("Message: Passenger Deleted Successfully.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }


        // DataGridView cell double-click event
        private void dgvAdminPassenger_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    dgvAdminPassenger.ClearSelection();
                    return;
                }

                int userId = Convert.ToInt32(dgvAdminPassenger.Rows[e.RowIndex].Cells["userId"].Value);

                string query = "SELECT * FROM userInfo WHERE userIdType = 3 AND userId = '" + userId + "'";

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                txtAdminPassengerUserId.Text = Convert.ToString(result.Data.Rows[0]["userId"]);
                txtAdminPassengerUserName.Text = Convert.ToString(result.Data.Rows[0]["userName"]);
                txtAdminPassengerPassword.Text = Convert.ToString(result.Data.Rows[0]["userPassword"]);
                txtAdminPassengerEmail.Text = Convert.ToString(result.Data.Rows[0]["userEmail"]);
                txtAdminPassengerAddress.Text = Convert.ToString(result.Data.Rows[0]["userAddress"]);
                string gender = Convert.ToString(result.Data.Rows[0]["userGender"]);

                if (gender == rdbAdminPassengerMale.Text)
                {
                    rdbAdminPassengerMale.Checked = true;
                }
                else if (gender == rdbAdminPassengerFemale.Text)
                {
                    rdbAdminPassengerFemale.Checked = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }
    }
}
