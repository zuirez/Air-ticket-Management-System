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
    public partial class AdminRefund : Form
    {
        public AdminRefund()
        {
            InitializeComponent();
        }


        // Method to clear input fields
        private void ClearRefundSelection()
        {
            txtAdminRefundId.Text = "";
            txtAdminRefundPaymentId.Text = "";
            txtAdminRefundPassengerId.Text = "";
            txtAdminRefundAmount.Text = "";
            cmbAdminRefundType.SelectedIndex = -1;
            dtpAdminRefundDate.Value = DateTime.Now;
            rdbPaid.Checked = false;
            rdbCancelled.Checked = false;
            rdbPending.Checked = false;
        }


        // Method to display Refund information
        private void ShowRefundInfo()
        {
            txtAdminRefundId.Text = "Auto Generated";

            string query = "SELECT * FROM Refund";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            dgvAdminRefund.DataSource = result.Data;
            dgvAdminRefund.Refresh();
            dgvAdminRefund.ClearSelection();
        }


        // Mehtod to populate paymentTypes in combobox
        private void ShowRefundTypeData()
        {
            cmbAdminRefundType.Items.Clear();
            cmbAdminRefundType.Items.Add("Cash");
            cmbAdminRefundType.Items.Add("Card");
            cmbAdminRefundType.Items.Add("Bkash");
            cmbAdminRefundType.Items.Add("Bank Transfer");
        }


        // Refresh Button Click Event
        private void btnPaymentRefresh_Click(object sender, EventArgs e)
        {
            txtRefundSearch.Text = "";
            ClearRefundSelection();
            ShowRefundInfo();
        }


        //Form Load Event
        private void AdminRefund_Load(object sender, EventArgs e)
        {
            ShowRefundTypeData();
            ShowRefundInfo();
        }


        //Search Button Click Event
        private void btnRefundSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtRefundSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Error: Enter Refund Id/ Refund status/ Refund Type/ Passenger ID.");
                txtRefundSearch.Text = "";
                return;
            }

            string searchRefundQuery = "SELECT * FROM Refund WHERE CAST(refundId AS VARCHAR) = '" + searchText + "' OR refundStatus = '" + searchText + "' OR CAST(userId as VARCHAR) = '" + searchText + "' OR refundType = '" + searchText + "';";

            var searchRefundQueryResult = DbHelper.GetQueryData(searchRefundQuery);

            if (searchRefundQueryResult.HasError)
            {
                MessageBox.Show("Error : " + searchRefundQueryResult.Message);
                txtRefundSearch.Text = "";
                return;
            }

            dgvAdminRefund.DataSource = searchRefundQueryResult.Data;
            dgvAdminRefund.Refresh();
            dgvAdminRefund.ClearSelection();

            txtRefundSearch.Text = "";
        }


        //Refresh Button Click Event
        private void btnRefundRefresh_Click(object sender, EventArgs e)
        {
            txtRefundSearch.Text = "";
            ClearRefundSelection();
            ShowRefundInfo();
        }


        //update Button Click Event
        private void btnAdminRefundUpdate_Click(object sender, EventArgs e)
        {

        }


        //Delete Button Click Event
        private void btnAdminRefundDelete_Click(object sender, EventArgs e)
        {

        }
    }
}