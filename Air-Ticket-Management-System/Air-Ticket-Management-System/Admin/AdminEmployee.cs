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
    public partial class AdminEmployee : Form
    {
        public AdminEmployee()
        {
            InitializeComponent();
        }


        // Clear Input Fields
        public void clearEmployeeSelection()
        {
            txtAdminEmployeeUserName.Text = "";
            txtAdminEmployeePassword.Text = "";
            txtAdminEmployeeEmail.Text = "";
            txtAdminEmployeeAddress.Text = "";
            rdbAdminEmployeeMale.Checked = false;
            rdbAdminEmployeeFemale.Checked = false;
        }


        // Show Employee data in data grid view
        public void showEmployeeInfo()
        {
            txtAdminEmployeeUserId.Text = "Auto Generated";

            string query = "SELECT * FROM userInfo WHERE userIdType = 2;";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            dgvAdminEmployee.DataSource = result.Data;
            dgvAdminEmployee.Refresh();
            dgvAdminEmployee.ClearSelection();
        }


        // Form Load Event
        private void AdminEmployee_Load(object sender, EventArgs e)
        {
            showEmployeeInfo();
        }


        // Search Button Click Event
        private void btnEmployeeSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtEmployeeSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Error: Enter User Name/ User Id/ User Gender.");
                txtEmployeeSearch.Text = "";
                return;
            }

            string query = "SELECT * FROM userInfo WHERE userIdType = 2 AND (userName = '" + searchText + "' OR CAST(userId AS VARCHAR) = '" + searchText + "' OR userGender = '" + searchText + "');";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message); 
                txtEmployeeSearch.Text = "";
                return;
            }

            dgvAdminEmployee.DataSource = result.Data;
            dgvAdminEmployee.Refresh();
            dgvAdminEmployee.ClearSelection();

            txtEmployeeSearch.Text = "";
        }


        // Refresh Button Click Event
        private void btnEmployeeRefresh_Click(object sender, EventArgs e)
        {
            txtEmployeeSearch.Text = "";
            clearEmployeeSelection();
            showEmployeeInfo();
        }


        // Add Button Click Event
        private void btnAdminEmployeeAdd_Click(object sender, EventArgs e)
        {
            string userName = txtAdminEmployeeUserName.Text;
            string userPassword = txtAdminEmployeePassword.Text;
            string userEmail = txtAdminEmployeeEmail.Text;
            string userAddress = txtAdminEmployeeAddress.Text;
            string userGender = "";

            if (rdbAdminEmployeeMale.Checked)
            {
                userGender = rdbAdminEmployeeMale.Text;
            }
            else if (rdbAdminEmployeeFemale.Checked)
            {
                userGender = rdbAdminEmployeeFemale.Text;
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

            if (!rdbAdminEmployeeMale.Checked)
            {
                if (!rdbAdminEmployeeFemale.Checked)
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
                string query = "INSERT INTO userInfo (userName, userPassword, userEmail, userAddress, userGender, userIdType) VALUES ('" + userName + "', '" + userPassword + "', '" + userEmail + "', '" + userAddress + "', '" + userGender + "', 2);";

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                MessageBox.Show("Employee added successfully.");

                clearEmployeeSelection();
                showEmployeeInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception.Message);
                return;
            }
        }


        // Update Button Click Event
        private void btnAdminEmployeeUpdate_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(txtAdminEmployeeUserId.Text);
            string userName = txtAdminEmployeeUserName.Text;
            string userPassword = txtAdminEmployeePassword.Text;
            string userEmail = txtAdminEmployeeEmail.Text;
            string userAddress = txtAdminEmployeeAddress.Text;
            string userGender = "";

            if (rdbAdminEmployeeMale.Checked)
            {
                userGender = rdbAdminEmployeeMale.Text;
            }
            else if (rdbAdminEmployeeFemale.Checked)
            {
                userGender = rdbAdminEmployeeFemale.Text;
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

            if (!rdbAdminEmployeeMale.Checked)
            {
                if (!rdbAdminEmployeeFemale.Checked)
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

                MessageBox.Show("Employee updated successfully.");

                clearEmployeeSelection();
                showEmployeeInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception.Message);
                return;
            }
        }


        // Delete Button Click Event
        private void btnAdminEmployeeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = Convert.ToString(txtAdminEmployeeUserId.Text);

                string query = "DELETE FROM userInfo WHERE userId = '" + userId + "';";

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                clearEmployeeSelection();
                showEmployeeInfo();

                MessageBox.Show("Message: Employee Deleted Successfully.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }


        // DataGridView Cell Double Click Event
        private void dgvAdminEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    dgvAdminEmployee.ClearSelection();
                    return;
                }

                int userId = Convert.ToInt32(dgvAdminEmployee.Rows[e.RowIndex].Cells["userId"].Value);

                string query = "SELECT * FROM userInfo WHERE userIdType = 2 AND userId = '" + userId + "'";

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                txtAdminEmployeeUserId.Text = Convert.ToString(result.Data.Rows[0]["userId"]);
                txtAdminEmployeeUserName.Text = Convert.ToString(result.Data.Rows[0]["userName"]);
                txtAdminEmployeePassword.Text = Convert.ToString(result.Data.Rows[0]["userPassword"]);
                txtAdminEmployeeEmail.Text = Convert.ToString(result.Data.Rows[0]["userEmail"]);
                txtAdminEmployeeAddress.Text = Convert.ToString(result.Data.Rows[0]["userAddress"]);
                string gender = Convert.ToString(result.Data.Rows[0]["userGender"]);

                if (gender == rdbAdminEmployeeMale.Text)
                {
                    rdbAdminEmployeeMale.Checked = true;
                }
                else if (gender == rdbAdminEmployeeFemale.Text)
                {
                    rdbAdminEmployeeFemale.Checked = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }
    }
}
