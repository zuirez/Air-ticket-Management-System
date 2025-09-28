using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Air_Ticket_Management_System
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }


        // Load data from the database and display it in the Data Grid View
        public void LoadEvent()
        {
            string query = "SELECT * FROM userInfo;";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            dgvAdminForm.DataSource = result.Data;
            dgvAdminForm.Refresh();
            dgvAdminForm.ClearSelection();

            txtAdminSearch.Text = "";
        }


        // Form Load Event
        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();

            LoadEvent();
        }


        // Form Closed Event
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }


        // Search Button Click Event
        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            String userName = txtAdminSearch.Text;

            if (string.IsNullOrEmpty(txtAdminSearch.Text))
            {
                MessageBox.Show("Please enter a username to search.");
                return;
            }

            string query = "SELECT * FROM UserInfo WHERE userName = '" + userName + "'";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            dgvAdminForm.DataSource = result.Data;
            dgvAdminForm.Refresh();
            dgvAdminForm.ClearSelection();
        }


        // Refresh Button Click Event
        private void btnAdminRefresh_Click(object sender, EventArgs e)
        {
            LoadEvent();
        }
    }
}
