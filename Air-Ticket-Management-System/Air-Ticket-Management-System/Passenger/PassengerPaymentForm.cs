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
    public partial class PassengerPaymentForm : Form
    {
        // Storing logged in user id
        int userId = SessionInfo.LoggedInUserId;


        public PassengerPaymentForm()
        {
            InitializeComponent();
        }


        // Method to clear input fields
        private void ClearPaymentSelection()
        {
            txtPassengerPaymentId.Text = "";
            txtPassengerPaymentPassengerId.Text = Convert.ToString(userId);
            txtPassengerPaymentBookingId.Text = "";
            txtPassengerPaymentAmount.Text = "";
            cmbPassengerPaymentType.SelectedIndex = -1;
            dtpPassengerPaymentDate.Value = DateTime.Now;
            dtpPassengerPaymentDate.Enabled = false;
            rdbPending.Checked = true;
            rdbPending.Enabled = true;
            rdbCancelled.Checked = false;
            rdbCancelled.Enabled = false;
            rdbPaid.Checked = false;
            rdbPaid.Enabled = false;
        }


        // Method to display payment information
        private void ShowPaymentInfo()
        {
            txtPassengerPaymentId.Text = "Auto Generated";
            txtPassengerPaymentPassengerId.Text = Convert.ToString(userId);

            string query = "SELECT * FROM Payment WHERE userId = '"+ userId +"'";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            dgvPassengerPayment.DataSource = result.Data;
            dgvPassengerPayment.Refresh();
            dgvPassengerPayment.ClearSelection();
        }


        // Mehtod to populate paymentTypes in combobox
        private void ShowPaymentTypeData()
        {
            cmbPassengerPaymentType.Items.Clear();
            cmbPassengerPaymentType.Items.Add("Cash");
            cmbPassengerPaymentType.Items.Add("Card");
            cmbPassengerPaymentType.Items.Add("Bkash");
            cmbPassengerPaymentType.Items.Add("Bank Transfer");
        }


        // Form Load Event
        private void PassengerPaymentForm_Load(object sender, EventArgs e)
        {
            ClearPaymentSelection();
            ShowPaymentTypeData();
            ShowPaymentInfo();
        }


        // Search Button Click Event
        private void btnPaymentSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtPaymentSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Error: Enter Payment Id/ Payment status/ Payment Type/ Booking ID.");
                txtPaymentSearch.Text = "";
                ClearPaymentSelection();
                ShowPaymentTypeData();
                ShowPaymentInfo();
                return;
            }

            string searchPaymentQuery = "SELECT * FROM Payment WHERE CAST(paymentId AS VARCHAR) = '" + searchText + "' OR paymentStatus = '" + searchText + "' OR paymentType = '" + searchText + "' OR bookingId = '" + searchText + "';";

            var searchPaymentQueryResult = DbHelper.GetQueryData(searchPaymentQuery);

            if (searchPaymentQueryResult.HasError)
            {
                MessageBox.Show("Error : " + searchPaymentQueryResult.Message);
                txtPaymentSearch.Text = "";
                return;
            }

            dgvPassengerPayment.DataSource = searchPaymentQueryResult.Data;
            dgvPassengerPayment.Refresh();
            dgvPassengerPayment.ClearSelection();

            txtPaymentSearch.Text = "";
        }


        // Refresh Button Click Event
        private void btnPaymentRefresh_Click(object sender, EventArgs e)
        {
            txtPaymentSearch.Text = "";
            ClearPaymentSelection();
            ShowPaymentInfo();
        }


        // DataGridView Cell Double Click Event
        private void dgvPassengerPayment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    dgvPassengerPayment.ClearSelection();
                    return;
                }

                int PaymentId = Convert.ToInt32(dgvPassengerPayment.Rows[e.RowIndex].Cells["paymentId"].Value);

                string query = "SELECT * FROM Payment WHERE paymentId = '" + PaymentId + "'";

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                txtPassengerPaymentId.Text = Convert.ToString(result.Data.Rows[0]["paymentId"]);
                txtPassengerPaymentPassengerId.Text = Convert.ToString(result.Data.Rows[0]["userId"]);
                txtPassengerPaymentBookingId.Text = Convert.ToString(result.Data.Rows[0]["bookingId"]);
                txtPassengerPaymentAmount.Text = Convert.ToString(result.Data.Rows[0]["Amount"]);
                cmbPassengerPaymentType.Text = Convert.ToString(result.Data.Rows[0]["paymentType"]);
                string status = Convert.ToString(result.Data.Rows[0]["paymentStatus"]);
                dtpPassengerPaymentDate.Value = Convert.ToDateTime(result.Data.Rows[0]["paymentDate"]);
                dtpPassengerPaymentDate.Enabled = false;

                if (status == "Paid")
                {
                    rdbPaid.Checked = true;
                    rdbPaid.Enabled = true;
                    rdbCancelled.Enabled = false;
                    rdbPending.Enabled = false;
                }
                else if (status == "Pending")
                {
                    rdbPending.Checked = true;
                    rdbPending.Enabled = true;
                    rdbCancelled.Enabled = false;
                    rdbPaid.Enabled = false;
                }
                else if (status == "Cancelled")
                {
                    rdbCancelled.Checked = true;
                    rdbCancelled.Enabled = true;
                    rdbPaid.Enabled = false;
                    rdbPending.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }


        // Pay Button Click Event
        private void btnPassengerPaymentPay_Click(object sender, EventArgs e)
        {
            // Validations
            if (string.IsNullOrWhiteSpace(txtPassengerPaymentId.Text))
            {
                MessageBox.Show("Error: Select a payment to pay.");
                ClearPaymentSelection();
                ShowPaymentInfo();
                return;
            }


            string PaymentStatus = "";
            string paymentType = cmbPassengerPaymentType.Text;
            int paymentId = Convert.ToInt32(txtPassengerPaymentId.Text);

            if (rdbPaid.Checked)
            {
                PaymentStatus = "Paid";
            }
            else if (rdbPending.Checked)
            {
                PaymentStatus = "Pending";
            }
            else if (rdbCancelled.Checked)
            {
                PaymentStatus = "Cancelled";
            }


            if (cmbPassengerPaymentType.SelectedItem == null || cmbPassengerPaymentType.SelectedIndex == -1)
            {
                MessageBox.Show("Error: Select payment Type");
                return;
            }


            // Cheaking if already paid
            string checkAlreadyPaidQuery = "SELECT * FROM Payment WHERE paymentId = '" + paymentId + "' AND paymentStatus = 'Paid';";

            var checkAlreadyPaidQueryResult = DbHelper.GetQueryData(checkAlreadyPaidQuery);
            if (checkAlreadyPaidQueryResult.HasError)
            {
                MessageBox.Show("Error : " + checkAlreadyPaidQueryResult.Message);
                return;
            }
            if (checkAlreadyPaidQueryResult.Data.Rows.Count > 0)
            {
                MessageBox.Show("Error: Already paid.");
                ClearPaymentSelection();
                ShowPaymentInfo();
                return;
            }


            // updating payment info
            try
            {
                // updating payment info
                string updatePaymentQuery = "UPDATE Payment SET paymentStatus = 'Paid', paymentType = '" + paymentType + "' WHERE paymentId = '" + paymentId + "';";

                var updatePaymentQueryResult = DbHelper.ExecuteNonResultQuery(updatePaymentQuery);

                if (updatePaymentQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + updatePaymentQueryResult.Message);
                    return;
                }


                // updating payment status in book table 
                string updateBookingPaymentStatusQuery = "UPDATE Book SET bookingStatus = 'Paid' WHERE paymentId = '" + paymentId + "';";

                var updateBookingPaymentStatusQueryResult = DbHelper.ExecuteNonResultQuery(updateBookingPaymentStatusQuery);

                if (updateBookingPaymentStatusQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + updateBookingPaymentStatusQueryResult.Message);
                    return;
                }


                MessageBox.Show("Message: Payment Successful.");

                ClearPaymentSelection();
                ShowPaymentInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }
    }
}
