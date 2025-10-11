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
            cmbAdminRefundType.Text = "Cash";
            dtpAdminRefundDate.Value = DateTime.Now;
            dtpAdminRefundDate.Enabled = false;
            cmbAdminRefundType.Enabled = false;

            rdbPending.Checked = true;
            rdbPending.Enabled = true;
            rdbPaid.Checked = false;
            rdbPaid.Enabled = false;
            rdbCancelled.Checked = false;
            rdbCancelled.Enabled = false;

            txtAdminRefundPassengerId.ReadOnly = false;
            txtAdminRefundPaymentId.ReadOnly = false;
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


        //Form Load Event
        private void AdminRefund_Load(object sender, EventArgs e)
        {
            ClearRefundSelection();
            ShowRefundTypeData();
            ShowRefundInfo();
        }


        // DataGridView Cell Double Click Event
        private void dgvAdminRefund_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    dgvAdminRefund.ClearSelection();
                    return;
                }

                rdbPending.Checked = false;
                rdbPending.Enabled = true;
                rdbPaid.Checked = false;
                rdbPaid.Enabled = true;
                rdbCancelled.Checked = false;
                rdbCancelled.Enabled = true;
                txtAdminRefundPassengerId.ReadOnly = true;
                txtAdminRefundPaymentId.ReadOnly = true;
                cmbAdminRefundType.Text = "Cash";
                cmbAdminRefundType.Enabled = true;

                int RefundId = Convert.ToInt32(dgvAdminRefund.Rows[e.RowIndex].Cells["RefundId"].Value);

                string query = "SELECT * FROM Refund WHERE RefundId = '" + RefundId + "'";

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                txtAdminRefundId.Text = Convert.ToString(result.Data.Rows[0]["refundId"]);
                txtAdminRefundPassengerId.Text = Convert.ToString(result.Data.Rows[0]["userId"]);
                txtAdminRefundPaymentId.Text = Convert.ToString(result.Data.Rows[0]["paymentId"]);
                txtAdminRefundAmount.Text = Convert.ToString(result.Data.Rows[0]["amount"]);
                string status = Convert.ToString(result.Data.Rows[0]["refundStatus"]);
                dtpAdminRefundDate.Value = Convert.ToDateTime(result.Data.Rows[0]["refundDate"]);

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


        //Search Button Click Event
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


        //add Button Click Event
        private void btnAdminRefundUpdate_Click(object sender, EventArgs e)
        {
            int PassengerId = Convert.ToInt32(txtAdminRefundPassengerId.Text);
            int PaymentId = Convert.ToInt32(txtAdminRefundPaymentId.Text);
            string RefundStatus = "Pending";


            // Validating input fields
            if (string.IsNullOrWhiteSpace(Convert.ToString(PassengerId)))
            {
                MessageBox.Show("Error: Select a Refund to update.");
                return;
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(PaymentId)))
            {
                MessageBox.Show("Error: Select a Refund to update.");
                return;
            }


            // Checking if paymentId already exists for the passenger
            try
            {
                string checkPaymentIdQuery = "SELECT * FROM Refund WHERE paymentId = '" + PaymentId + "' AND userId = '" + PassengerId + "';";
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
                string getPaymentAmountQuery = "SELECT amount FROM Payment WHERE paymentId = '" + PaymentId + "' AND userId = '" + PassengerId + "';";
                
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
                string addRefundQuery = "INSERT INTO Refund (userId, paymentId, refundStatus, amount) VALUES ('" + PassengerId + "', '" + PaymentId + "', '" + RefundStatus + "', '"+ PaymentAmount +"');";

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


        //pay Button Click Event
        private void btnAdminRefundDelete_Click(object sender, EventArgs e)
        {
            int RefundId = Convert.ToInt32(txtAdminRefundId.Text);
            int PassengerId = Convert.ToInt32(txtAdminRefundPassengerId.Text);
            int PaymentId = Convert.ToInt32(txtAdminRefundPaymentId.Text);
            string RefundType = Convert.ToString(cmbAdminRefundType.Text);
            string RefundStatus = "";

            if (rdbPaid.Checked)
            {
                RefundStatus = "Paid";
            }
            else if (rdbPending.Checked)
            {
                RefundStatus = "Pending";
            }
            else if (rdbCancelled.Checked)
            {
                RefundStatus = "Cancelled";
            }
            else
            {
                MessageBox.Show("Error: Select Refund Status.");
                return;
            }


            // Validating input fields
            if (string.IsNullOrWhiteSpace(Convert.ToString(RefundId)))
            {
                MessageBox.Show("Error: Select a Refund to pay.");
                ClearRefundSelection();
                ShowRefundInfo();
                return;
            }
            if (Convert.ToString(RefundId) == "Auto Generated")
            {
                MessageBox.Show("Error: Select a Refund to pay.");
                ClearRefundSelection();
                ShowRefundInfo();
                return;
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(PassengerId)))
            {
                MessageBox.Show("Error: Select a Refund to pay.");
                ClearRefundSelection();
                ShowRefundInfo();
                return;
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(PaymentId)))
            {
                MessageBox.Show("Error: Select a Refund to pay.");
                ClearRefundSelection();
                ShowRefundInfo();
                return;
            }
            if (string.IsNullOrWhiteSpace(RefundType))
            {
                MessageBox.Show("Error: Select Refund Type.");
                return;
            }


            if(RefundStatus == "Pending")
            {
                // Update Refund in database
                try
                {
                    string updateRefundQuery = "UPDATE Refund SET refundStatus = '" + RefundStatus + "', refundType = '" + RefundType + "', refundDate = '" + dtpAdminRefundDate.Value.ToString("yyyy-MM-dd") + "' WHERE refundId = '" + RefundId + "';";

                    var updateRefundQueryResult = DbHelper.ExecuteNonResultQuery(updateRefundQuery);

                    if (updateRefundQueryResult.HasError)
                    {
                        MessageBox.Show("Error : " + updateRefundQueryResult.Message);
                        return;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error: " + exception.Message);
                    return;
                }

                MessageBox.Show("Refund Status Updated.");
                ClearRefundSelection();
                ShowRefundInfo();
                return;
            }

            else if(RefundStatus == "Cancelled")
            {
                // Update Refund in database
                try
                {
                    string updateRefundQuery = "UPDATE Refund SET refundStatus = '" + RefundStatus + "', refundType = '" + RefundType + "', refundDate = '" + dtpAdminRefundDate.Value.ToString("yyyy-MM-dd") + "' WHERE refundId = '" + RefundId + "';";

                    var updateRefundQueryResult = DbHelper.ExecuteNonResultQuery(updateRefundQuery);

                    if (updateRefundQueryResult.HasError)
                    {
                        MessageBox.Show("Error : " + updateRefundQueryResult.Message);
                        return;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error: " + exception.Message);
                    return;
                }

                MessageBox.Show("Refund Cancelled.");
                ClearRefundSelection();
                ShowRefundInfo();
                return;
            }

            else if(RefundStatus == "Paid")
            {
                // Update Refund in database
                try
                {
                    // Making the booked seats available again after refund is paid

                    // Getting already booked seatIds for this bookingId
                    string getBookedSeatsQuery = "SELECT flightSeatId FROM Book WHERE paymentId = '" + PaymentId + "';";

                    var getBookedSeatsQueryResult = DbHelper.GetQueryData(getBookedSeatsQuery);

                    // List to store existing booked seatIds
                    List<int> bookedSeatIds = new List<int>();

                    // storing existing booked seatIds in a list
                    foreach (DataRow row in getBookedSeatsQueryResult.Data.Rows)
                    {
                        bookedSeatIds.Add(Convert.ToInt32(row["flightSeatId"]));
                    }

                    // Updating the availability of the booked seats to 'Available'
                    foreach (int seatId in bookedSeatIds)
                    {
                        string updateSeatAvailabilityQuery = "UPDATE FlightSeats SET flightSeatStatus = 'Available', userId = NULL, paymentId = NULL WHERE flightSeatId = " + seatId + ";";

                        var updateSeatAvailabilityQueryResult = DbHelper.ExecuteNonResultQuery(updateSeatAvailabilityQuery);

                        if (updateSeatAvailabilityQueryResult.HasError)
                        {
                            MessageBox.Show("Error : " + updateSeatAvailabilityQueryResult.Message);
                            return;
                        }
                    }


                    string updateRefundQuery = "UPDATE Refund SET refundStatus = '" + RefundStatus + "', refundType = '" + RefundType + "', refundDate = '" + dtpAdminRefundDate.Value.ToString("yyyy-MM-dd") + "' WHERE refundId = '" + RefundId + "';";

                    var updateRefundQueryResult = DbHelper.ExecuteNonResultQuery(updateRefundQuery);

                    if (updateRefundQueryResult.HasError)
                    {
                        MessageBox.Show("Error : " + updateRefundQueryResult.Message);
                        return;
                    }


                    // Deleting payment from Payment table after refund is paid
                    string deletePaymentQuery = "DELETE FROM Payment WHERE paymentId = '" + PaymentId + "' AND userId = '" + PassengerId + "';";
                    
                    var deletePaymentQueryResult = DbHelper.ExecuteNonResultQuery(deletePaymentQuery);
                    
                    if (deletePaymentQueryResult.HasError)
                    {
                        MessageBox.Show("Error : " + deletePaymentQueryResult.Message);
                        return;
                    }

                    MessageBox.Show("Refund Successful.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error: " + exception.Message);
                    return;
                }
            }
        }
    }
}