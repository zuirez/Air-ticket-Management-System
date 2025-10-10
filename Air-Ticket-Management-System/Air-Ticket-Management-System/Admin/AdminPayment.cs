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
    public partial class AdminPayment : Form
    {
        public AdminPayment()
        {
            InitializeComponent();
        }


        // Method to clear input fields
        private void ClearPaymentSelection()
        {
            txtAdminPaymentId.Text = "";
            txtAdminPaymentPassengerId.Text = "";
            txtAdminPaymentBookingId.Text = "";
            txtAdminPaymentAmount.Text = "";
            cmbAdminPaymentType.SelectedIndex = -1;
            dtpAdminPaymentDate.Value = DateTime.Now;
            rdbPaid.Checked = false;
            rdbCancelled.Checked = false;
            rdbPending.Checked = false;
        }


        // Method to display payment information
        private void ShowPaymentInfo()
        {
            txtAdminPaymentId.Text = "Auto Generated";

            string query = "SELECT * FROM Payment";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            dgvAdminPayment.DataSource = result.Data;
            dgvAdminPayment.Refresh();
            dgvAdminPayment.ClearSelection();
        }


        // Mehtod to populate paymentTypes in combobox
        private void ShowPaymentTypeData()
        {
            cmbAdminPaymentType.Items.Clear();
            cmbAdminPaymentType.Items.Add("Cash");
            cmbAdminPaymentType.Items.Add("Card");
            cmbAdminPaymentType.Items.Add("Bkash");
            cmbAdminPaymentType.Items.Add("Bank Transfer");
        }


        // Search Button Click Event
        private void btnPaymentSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtPaymentSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Error: Enter Payment Id/ Payment status/ Payment Type/ Passenger ID/ Booking ID.");
                txtPaymentSearch.Text = "";
                return;
            }

            string searchPaymentQuery = "SELECT * FROM Payment WHERE CAST(paymentId AS VARCHAR) = '" + searchText + "' OR paymentStatus = '" + searchText + "' OR CAST(userId as VARCHAR) = '" + searchText + "' OR paymentType = '"+ searchText +"' OR bookingId = '"+ searchText +"';";

            var searchPaymentQueryResult = DbHelper.GetQueryData(searchPaymentQuery);

            if (searchPaymentQueryResult.HasError)
            {
                MessageBox.Show("Error : " + searchPaymentQueryResult.Message);
                txtPaymentSearch.Text = "";
                return;
            }

            dgvAdminPayment.DataSource = searchPaymentQueryResult.Data;
            dgvAdminPayment.Refresh();
            dgvAdminPayment.ClearSelection();

            txtPaymentSearch.Text = "";
        }


        // Refresh Button Click Event
        private void btnPaymentRefresh_Click(object sender, EventArgs e)
        {
            txtPaymentSearch.Text = "";
            ClearPaymentSelection();
            ShowPaymentInfo();
        }


        // Update Button Click Event
        private void btnAdminPaymentUpdate_Click(object sender, EventArgs e)
        {
            string PaymentStatus = "";
            string paymentType = cmbAdminPaymentType.Text;

            if (rdbPaid.Checked)
            {
                PaymentStatus = "Paid";
            }
            else if(rdbPending.Checked)
            {
                PaymentStatus = "Pending";
            }
            else if(rdbCancelled.Checked)
            {
                PaymentStatus = "Cancelled";
            }

            // Checking if any field is empty
            if (!rdbPaid.Checked)
            {
                if (!rdbPending.Checked)
                {
                    if (!rdbCancelled.Checked)
                    {
                        MessageBox.Show("Error: Select Payment Status");
                        return;
                    }
                }
            }

            if (cmbAdminPaymentType.SelectedItem == null || cmbAdminPaymentType.SelectedIndex == -1)
            {
                MessageBox.Show("Error: Select payment Type");
                return;
            }

            // updating payment info
            try
            {
                // updating payment info
                int PaymentId = Convert.ToInt32(txtAdminPaymentId.Text);

                string updatePaymentQuery = "UPDATE Payment SET paymentStatus = '" + PaymentStatus + "', paymentType = '" + paymentType + "' WHERE paymentId = '"+ PaymentId +"';";

                var updatePaymentQueryResult = DbHelper.ExecuteNonResultQuery(updatePaymentQuery);

                if (updatePaymentQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + updatePaymentQueryResult.Message);
                    return;
                }

                
                // updating payment status in book table 
                string updateBookingPaymentStatusQuery = "UPDATE Book SET bookingStatus = '" + PaymentStatus + "' WHERE paymentId = '" + PaymentId + "';";

                var updateBookingPaymentStatusQueryResult = DbHelper.ExecuteNonResultQuery(updateBookingPaymentStatusQuery);

                if (updateBookingPaymentStatusQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + updateBookingPaymentStatusQueryResult.Message);
                    return;
                }


                MessageBox.Show("Message: Payment Updated Successfully.");

                ClearPaymentSelection();
                ShowPaymentInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }


        // Delete Button Click Event
        private void btnAdminPaymentDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string PaymentId = Convert.ToString(txtAdminPaymentId.Text);
                string BookingId = Convert.ToString(txtAdminPaymentBookingId.Text);
                string UserId = Convert.ToString(txtAdminPaymentPassengerId.Text);

                if (string.IsNullOrEmpty(PaymentId))
                {
                    MessageBox.Show("Error: Payment ID is missing.");
                    return;
                }

                if (string.IsNullOrEmpty(UserId))
                {
                    MessageBox.Show("Error: Passenger ID is missing.");
                    return;
                }

                int paymentId = Convert.ToInt32(PaymentId);
                int userId = Convert.ToInt32(UserId);


                // Find all Book rows related to this payment
                string getBooksQuery = "SELECT bookingId, flightSeatId FROM Book WHERE paymentId = '" + paymentId + "' AND userId = '" + userId + "'";
                
                var getBooksResult = DbHelper.GetQueryData(getBooksQuery);

                if (getBooksResult.HasError)
                {
                    MessageBox.Show("Error : " + getBooksResult.Message);
                    return;
                }

                if (getBooksResult.Data.Rows.Count == 0)
                {
                    MessageBox.Show("No booking found for this payment and passenger.");
                    return;
                }


                // Update flight seats to available
                foreach (DataRow row in getBooksResult.Data.Rows)
                {
                    int seatId = Convert.ToInt32(row["flightSeatId"]);

                    string updateSeatQuery = "UPDATE FlightSeats SET flightSeatStatus = 'Available', userId = NULL, paymentId = NULL WHERE flightSeatId = '" + seatId + "'";
                    
                    var updateSeatResult = DbHelper.ExecuteNonResultQuery(updateSeatQuery);

                    if (updateSeatResult.HasError)
                    {
                        MessageBox.Show("Error updating seat " + seatId + " : " + updateSeatResult.Message);
                    }
                }


                // Delete all related booking rows
                foreach (DataRow row in getBooksResult.Data.Rows)
                {
                    int bookingId = Convert.ToInt32(row["bookingId"]);
                    string deleteBookQuery = "DELETE FROM Book WHERE bookingId = '" + bookingId + "' AND userId = '" + userId + "'";
                    var deleteBookResult = DbHelper.ExecuteNonResultQuery(deleteBookQuery);

                    if (deleteBookResult.HasError)
                    {
                        MessageBox.Show("Error deleting booking " + bookingId + " : " + deleteBookResult.Message);
                    }
                }


                // Delete the payment only if no Book rows still use it
                string checkQuery = "SELECT COUNT(*) AS cnt FROM Book WHERE paymentId = '" + paymentId + "'";
                var checkResult = DbHelper.GetQueryData(checkQuery);

                if (checkResult.HasError)
                {
                    MessageBox.Show("Error checking payment references: " + checkResult.Message);
                    return;
                }

                int cnt = Convert.ToInt32(checkResult.Data.Rows[0]["cnt"]);
                if (cnt == 0)
                {
                    string deletePaymentQuery = "DELETE FROM Payment WHERE paymentId = '" + paymentId + "'";
                    var deletePaymentResult = DbHelper.ExecuteNonResultQuery(deletePaymentQuery);

                    if (deletePaymentResult.HasError)
                    {
                        MessageBox.Show("Error deleting payment: " + deletePaymentResult.Message);
                        return;
                    }
                }

                ClearPaymentSelection();
                ShowPaymentInfo();

                MessageBox.Show("Message: Payment and related bookings/seats removed successfully.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }


        // DataGridView Cell Double Click Event
        private void dgvAdminPayment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    dgvAdminPayment.ClearSelection();
                    return;
                }

                int PaymentId = Convert.ToInt32(dgvAdminPayment.Rows[e.RowIndex].Cells["paymentId"].Value);

                string query = "SELECT * FROM Payment WHERE paymentId = '" + PaymentId + "'";

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                txtAdminPaymentId.Text = Convert.ToString(result.Data.Rows[0]["paymentId"]);
                txtAdminPaymentPassengerId.Text = Convert.ToString(result.Data.Rows[0]["userId"]);
                txtAdminPaymentBookingId.Text = Convert.ToString(result.Data.Rows[0]["bookingId"]);
                txtAdminPaymentAmount.Text = Convert.ToString(result.Data.Rows[0]["Amount"]);
                cmbAdminPaymentType.Text = Convert.ToString(result.Data.Rows[0]["paymentType"]);
                string status = Convert.ToString(result.Data.Rows[0]["paymentStatus"]);
                dtpAdminPaymentDate.Value = Convert.ToDateTime(result.Data.Rows[0]["paymentDate"]);

                if (status == "Paid")
                {
                    rdbPaid.Checked = true;
                }
                else if (status == "Pending")
                {
                    rdbPending.Checked = true;
                }
                else if (status == "Cancelled")
                {
                    rdbCancelled.Checked = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }


        // Form Load Event
        private void AdminPayment_Load(object sender, EventArgs e)
        {
            ShowPaymentTypeData();
            ShowPaymentInfo();
        }
    }
}
