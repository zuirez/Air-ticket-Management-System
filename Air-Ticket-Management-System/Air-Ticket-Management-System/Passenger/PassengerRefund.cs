using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Ticket_Management_System.Passenger
{
    public partial class PassengerRefund : Form
    {
        // Storing logged in user id
        int userId = SessionInfo.LoggedInUserId;


        public PassengerRefund()
        {
            InitializeComponent();
        }


        // Method to clear input fields
        private void ClearRefundSelection()
        {
            txtPassengerRefundId.Text = "";
            txtPassengerRefundPaymentId.Text = "";
            txtPassengerRefundPassengerId.Text = Convert.ToString(userId);
            txtPassengerRefundAmount.Text = "";
            dtpPassengerRefundDate.Value = DateTime.Now;
            dtpPassengerRefundDate.Enabled = false;
        }


        // Method to display Refund information
        private void ShowRefundInfo()
        {
            txtPassengerRefundId.Text = "Auto Generated";

            string query = "SELECT * FROM Refund WHERE userId = '"+ userId +"'";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            dgvPassengerRefund.DataSource = result.Data;
            dgvPassengerRefund.Refresh();
            dgvPassengerRefund.ClearSelection();
        }


        // Form Load Event
        private void PassengerRefund_Load(object sender, EventArgs e)
        {
            ClearRefundSelection();
            ShowRefundInfo();
        }


        // Search Button Click Event
        private void btnRefundSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtRefundSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Error: Enter Refund Id/ Refund status/ Refund Type/ Passenger ID.");
                txtRefundSearch.Text = "";
                ClearRefundSelection();
                ShowRefundInfo();
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

            dgvPassengerRefund.DataSource = searchRefundQueryResult.Data;
            dgvPassengerRefund.Refresh();
            dgvPassengerRefund.ClearSelection();

            txtRefundSearch.Text = "";
        }


        // Refresh Button Click Event
        private void btnRefundRefresh_Click(object sender, EventArgs e)
        {
            txtRefundSearch.Text = "";
            ClearRefundSelection();
            ShowRefundInfo();
        }


        // DataGridView Cell Double Click Event
        private void dgvPassengerRefund_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    dgvPassengerRefund.ClearSelection();
                    return;
                }

                int RefundId = Convert.ToInt32(dgvPassengerRefund.Rows[e.RowIndex].Cells["RefundId"].Value);

                string query = "SELECT * FROM Refund WHERE RefundId = '" + RefundId + "'";

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                txtPassengerRefundId.Text = Convert.ToString(result.Data.Rows[0]["refundId"]);
                txtPassengerRefundPassengerId.Text = Convert.ToString(result.Data.Rows[0]["userId"]);
                txtPassengerRefundPaymentId.Text = Convert.ToString(result.Data.Rows[0]["paymentId"]);
                txtPassengerRefundAmount.Text = Convert.ToString(result.Data.Rows[0]["amount"]);
                dtpPassengerRefundDate.Value = Convert.ToDateTime(result.Data.Rows[0]["refundDate"]);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }


        // Request for  a refund Button Click Event
        private void btnPassengerRefundPay_Click(object sender, EventArgs e)
        {
            int PaymentId = Convert.ToInt32(txtPassengerRefundPaymentId.Text);


            // Validating input field
            if (string.IsNullOrWhiteSpace(Convert.ToString(PaymentId)))
            {
                MessageBox.Show("Error: Select a Payment to Request Refund.");
                ClearRefundSelection();
                ShowRefundInfo();
                return;
            }


            // Checking if paymentId already exists for the passenger
            try
            {
                string checkPaymentIdQuery = "SELECT * FROM Refund WHERE paymentId = '" + PaymentId + "' AND userId = '" + userId + "';";
                var checkPaymentIdQueryResult = DbHelper.GetQueryData(checkPaymentIdQuery);
                if (checkPaymentIdQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + checkPaymentIdQueryResult.Message);
                    return;
                }
                if (checkPaymentIdQueryResult.Data.Rows.Count > 0)
                {
                    MessageBox.Show("Error: A refund request for this Payment ID already exists.");
                    ClearRefundSelection();
                    ShowRefundInfo();
                    return;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
                return;
            }


            int PaymentAmount = 0;

            // Getting payment amount from Payment table
            try
            {
                string getPaymentAmountQuery = "SELECT amount FROM Payment WHERE paymentId = '" + PaymentId + "' AND userId = '" + userId + "';";

                var getPaymentAmountQueryResult = DbHelper.GetQueryData(getPaymentAmountQuery);

                if (getPaymentAmountQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + getPaymentAmountQueryResult.Message);
                    return;
                }
                if (getPaymentAmountQueryResult.Data.Rows.Count == 0)
                {
                    MessageBox.Show("Error: No payment found for the given Payment ID and Passenger ID.");
                    return;
                }

                PaymentAmount = Convert.ToInt32(getPaymentAmountQueryResult.Data.Rows[0]["amount"]);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
                return;
            }


            // Add Refund to database
            try
            {
                string addRefundQuery = "INSERT INTO Refund (userId, paymentId, refundStatus, amount) VALUES ('" + userId + "', '" + PaymentId + "', 'Pending', '" + PaymentAmount + "');";

                var addRefundQueryResult = DbHelper.ExecuteNonResultQuery(addRefundQuery);

                if (addRefundQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + addRefundQueryResult.Message);
                    return;
                }
                MessageBox.Show("Refund Request Added Successfully.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
                return;
            }

            ClearRefundSelection();
            ShowRefundInfo();
        }
    }
}
