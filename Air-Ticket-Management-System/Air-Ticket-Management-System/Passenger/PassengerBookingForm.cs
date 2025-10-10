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
    public partial class PassengerBookingForm : Form
    {
        // Storing logged in user id
        int userId = SessionInfo.LoggedInUserId;

        public PassengerBookingForm()
        {
            InitializeComponent();
        }


        // Method to clear input fields
        private void ClearBookingSelection()
        {
            txtPassengerBookingPassengerId.ReadOnly = true;
            txtPassengerBookingPassengerId.Text = Convert.ToString(userId);
            cmbPassengerBookingFlightName.Enabled = true;
            dtpPassengerBookingDate.Value = DateTime.Now;
            cmbPassengerBookingFlightName.SelectedIndex = -1;
            txtPassengerBookingFlightOrigin.Text = "";
            txtPassengerBookingFlightDestination.Text = "";
            txtPassengerBookingPaymentStatus.Text = "";
            txtPassengerBookingBookedSeats.Text = "";
            rdbCancelled.Checked = false;
            rdbConfirmed.Checked = false;
            rdbPending.Checked = false;
        }


        // Method to display booking information
        private void ShowBookingInfo()
        {
            txtPassengerBookingId.Text = "Auto Generated";
            txtPassengerBookingPassengerId.Text = Convert.ToString(userId);
            txtPassengerBookingPaymentStatus.Text = "Pending";
            rdbPending.Checked = true;
            rdbCancelled.Enabled = false;
            rdbConfirmed.Enabled = false;

            string query = "SELECT * FROM BOOK WHERE userId = '"+ userId +"'";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            dgvPassengerBooking.DataSource = result.Data;
            dgvPassengerBooking.Refresh();
            dgvPassengerBooking.ClearSelection();
        }


        // Mehtod to populate flight names in combobox
        private void ShowFlightNames()
        {
            string query = "SELECT flightNo FROM Flight";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            cmbPassengerBookingFlightName.Items.Clear();

            foreach (DataRow row in result.Data.Rows)
            {
                cmbPassengerBookingFlightName.Items.Add(row["flightNo"].ToString());
            }
        }


        // Methode to populate flight origin and destination based on selected flight name
        private void cmbPassengerBookingFlightName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPassengerBookingFlightName.SelectedItem == null || cmbPassengerBookingFlightName.SelectedIndex == -1)
            {
                txtPassengerBookingFlightId.Text = "";
                txtPassengerBookingFlightOrigin.Text = "";
                txtPassengerBookingFlightDestination.Text = "";
                return;
            }

            string selectedFlightNo = cmbPassengerBookingFlightName.SelectedItem.ToString();

            try
            {
                string query = "SELECT origin, destination, flightId FROM Flight WHERE flightNo = '" + selectedFlightNo + "';";
                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error: " + result.Message);
                    return;
                }

                if (result.Data != null && result.Data.Rows.Count > 0)
                {
                    txtPassengerBookingFlightId.Text = result.Data.Rows[0]["flightId"].ToString();
                    txtPassengerBookingFlightOrigin.Text = result.Data.Rows[0]["origin"].ToString();
                    txtPassengerBookingFlightDestination.Text = result.Data.Rows[0]["destination"].ToString();
                }
                else
                {
                    txtPassengerBookingFlightId.Text = "";
                    txtPassengerBookingFlightOrigin.Text = "";
                    txtPassengerBookingFlightDestination.Text = "";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unexpected error: " + exception.Message);
                return;
            }
        }


        // Form Load Event
        private void PassengerBookingForm_Load(object sender, EventArgs e)
        {
            txtPassengerBookingPassengerId.Text = Convert.ToString(userId);
            ShowBookingInfo();
            ShowFlightNames();
        }


        // Search Button Click Event
        private void btnBookingSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtBookingSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Error: Enter Booking Id/ Booking status");
                txtBookingSearch.Text = "";
                return;
            }

            string searchBookingQuery = "SELECT * FROM BOOK WHERE userId = '" + userId + "' AND (CAST(bookingId AS VARCHAR) = '" + searchText + "' OR bookingStatus = '" + searchText + "');";

            var searchBookingQueryResult = DbHelper.GetQueryData(searchBookingQuery);

            if (searchBookingQueryResult.HasError)
            {
                MessageBox.Show("Error : " + searchBookingQueryResult.Message);
                txtBookingSearch.Text = "";
                return;
            }

            dgvPassengerBooking.DataSource = searchBookingQueryResult.Data;
            dgvPassengerBooking.Refresh();
            dgvPassengerBooking.ClearSelection();

            txtBookingSearch.Text = "";
        }


        // Refresh Button Click Event
        private void btnBookingRefresh_Click(object sender, EventArgs e)
        {
            txtBookingSearch.Text = "";
            ClearBookingSelection();
            ShowBookingInfo();
        }


        // DataGridView Cell Double Click Event
        private void dgvPassengerBooking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    dgvPassengerBooking.ClearSelection();
                    return;
                }

                int BookingId = Convert.ToInt32(dgvPassengerBooking.Rows[e.RowIndex].Cells["bookingId"].Value);

                // getting paymentId from booking table
                string GetPaymentIdQuery = "SELECT paymentId FROM Book WHERE bookingId = '" + BookingId + "';";

                var GetPaymentIdQueryResult = DbHelper.GetQueryData(GetPaymentIdQuery);

                if (GetPaymentIdQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + GetPaymentIdQueryResult.Message);
                    return;
                }
                if (GetPaymentIdQueryResult.Data.Rows.Count < 1)
                {
                    MessageBox.Show("Error: Payment record not found for the selected booking.");
                    ClearBookingSelection();
                    return;
                }

                // Stroring paymentId
                int PaymentId = Convert.ToInt32(GetPaymentIdQueryResult.Data.Rows[0]["paymentId"]);


                // getting booking info from booking table
                string GetBookQuery = "SELECT * FROM Book WHERE bookingId = '" + BookingId + "' AND paymentId = '" + PaymentId + "'";

                var GetBookQueryResult = DbHelper.GetQueryData(GetBookQuery);

                if (GetBookQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + GetBookQueryResult.Message);
                    return;
                }

                txtPassengerBookingPassengerId.ReadOnly = true;

                txtPassengerBookingId.Text = Convert.ToString(GetBookQueryResult.Data.Rows[0]["bookingId"]);
                string BookingStatus = Convert.ToString(GetBookQueryResult.Data.Rows[0]["bookingStatus"]);
                dtpPassengerBookingDate.Value = Convert.ToDateTime(GetBookQueryResult.Data.Rows[0]["bookingDate"]);
                int PassengerId = Convert.ToInt32(GetBookQueryResult.Data.Rows[0]["userId"]);
                txtPassengerBookingPassengerId.Text = Convert.ToString(GetBookQueryResult.Data.Rows[0]["userId"]);
                int FlightId = Convert.ToInt32(GetBookQueryResult.Data.Rows[0]["flightId"]);
                txtPassengerBookingFlightId.Text = Convert.ToString(GetBookQueryResult.Data.Rows[0]["flightId"]);

                if (BookingStatus == "Confirmed")
                {
                    rdbConfirmed.Checked = true;
                }
                else if (BookingStatus == "Pending")
                {
                    rdbPending.Checked = true;
                }
                else if (BookingStatus == "Canceled")
                {
                    rdbCancelled.Checked = true;
                }

                string GetFlightQuery = "SELECT * FROM FLIGHT WHERE flightId = '" + FlightId + "';";

                var GetFLightQueryResult = DbHelper.GetQueryData(GetFlightQuery);

                if (GetFLightQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + GetFLightQueryResult.Message);
                    return;
                }

                cmbPassengerBookingFlightName.Text = Convert.ToString(GetFLightQueryResult.Data.Rows[0]["flightNo"]);
                txtPassengerBookingFlightOrigin.Text = Convert.ToString(GetFLightQueryResult.Data.Rows[0]["origin"]);
                txtPassengerBookingFlightDestination.Text = Convert.ToString(GetFLightQueryResult.Data.Rows[0]["destination"]);


                // making combobox readonly
                cmbPassengerBookingFlightName.Enabled = false;


                string GetFlightSeatsQuery = "SELECT seatNo FROM FlightSeats WHERE userId = '" + PassengerId + "' AND paymentId = '" + PaymentId + "';";

                var GetFlightSeatsQueryResult = DbHelper.GetQueryData(GetFlightSeatsQuery);

                if (GetFlightSeatsQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + GetFlightSeatsQueryResult.Message);
                    return;
                }

                List<string> bookedSeats = new List<string>();

                foreach (DataRow row in GetFlightSeatsQueryResult.Data.Rows)
                {
                    bookedSeats.Add(row["seatNo"].ToString());
                }

                txtPassengerBookingBookedSeats.Text = string.Join(", ", bookedSeats);


                //updating payment status
                string getBookingStatusQuery = "SELECT paymentStatus FROM Payment WHERE paymentId = '" + PaymentId + "';";

                var getBookingStatusQueryResult = DbHelper.GetQueryData(getBookingStatusQuery);

                if (getBookingStatusQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + getBookingStatusQueryResult.Message);
                    return;
                }

                string paymentStatus = Convert.ToString(getBookingStatusQueryResult.Data.Rows[0]["paymentStatus"]);

                if (paymentStatus == "Paid")
                {
                    txtPassengerBookingPaymentStatus.Text = "Paid";
                    rdbConfirmed.Checked = true;
                    rdbConfirmed.Enabled = true;
                    rdbCancelled.Enabled = false;
                    rdbPending.Enabled = false;
                }
                else if (paymentStatus == "Cancelled")
                {
                    txtPassengerBookingPaymentStatus.Text = "Cancelled";
                    rdbCancelled.Checked = true;
                    rdbCancelled.Enabled = true;
                    rdbPending.Enabled = false;
                    rdbConfirmed.Enabled = false;
                }
                else
                {
                    txtPassengerBookingPaymentStatus.Text = "Pending";
                    rdbPending.Checked = true;
                    rdbPending.Enabled = true;
                    rdbCancelled.Enabled = false;
                    rdbConfirmed.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }


        // Flight Seats button Click Event
        private void btnPassengerBookingFlightSeat_Click(object sender, EventArgs e)
        {
            string FlightNo = cmbPassengerBookingFlightName.Text;

            if (string.IsNullOrWhiteSpace(FlightNo))
            {
                MessageBox.Show("Error: Select flight no First");
                return;
            }

            AdminFlightSeats flightSeats = new AdminFlightSeats(FlightNo, txtPassengerBookingBookedSeats);
            flightSeats.ShowDialog();
        }


        // Add Button Click Event
        private void btnPassengerBookingAdd_Click(object sender, EventArgs e)
        {
            // Checking if any field is empty
            if (string.IsNullOrWhiteSpace(txtPassengerBookingPassengerId.Text))
            {
                MessageBox.Show("Error: Enter Passenger ID");
                return;
            }

            if (cmbPassengerBookingFlightName.SelectedItem == null || cmbPassengerBookingFlightName.SelectedIndex == -1)
            {
                MessageBox.Show("Error: Select Flight No");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassengerBookingBookedSeats.Text))
            {
                MessageBox.Show("Error: Select Seats");
                return;
            }

            if (!rdbConfirmed.Checked)
            {
                if (!rdbPending.Checked)
                {
                    if (!rdbCancelled.Checked)
                    {
                        MessageBox.Show("Error: Select Booking Status");
                        return;
                    }
                }
            }


            // Getting data from input fields
            int userId = Convert.ToInt32(txtPassengerBookingPassengerId.Text);
            DateTime BookingDate = dtpPassengerBookingDate.Value;
            string BookingStatus = "";


            // Getting Booking Status
            if (rdbConfirmed.Checked)
            {
                BookingStatus = rdbConfirmed.Text;
            }
            else if (rdbPending.Checked)
            {
                BookingStatus = rdbPending.Text;
            }
            else if (rdbCancelled.Checked)
            {
                BookingStatus = rdbCancelled.Text;
            }


            // Checking if the passenger exists
            string getUserIdQuery = "SELECT * FROM UserInfo WHERE userId = '" + userId + "';";

            var getUserIdQueryResult = DbHelper.GetQueryData(getUserIdQuery);

            if (getUserIdQueryResult.HasError)
            {
                MessageBox.Show("Error : " + getUserIdQueryResult.Message);
                return;
            }

            if (getUserIdQueryResult.Data.Rows.Count < 1)
            {
                MessageBox.Show("Error: Passenger not found. Please enter a valid Passenger Name or Add a Passenger first.");
                ClearBookingSelection();
                return;
            }


            // getting flightSeats id from txtPassengerBookingBookedSeats
            string bookedSeats = txtPassengerBookingBookedSeats.Text.Trim();


            // Cheacking if any other user has already booked the same seats on the same flight
            string checkSeatAvailabilityQuery = "SELECT * FROM FlightSeats WHERE seatNo IN ('" + string.Join("','", bookedSeats.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)) + "') AND flightId = (SELECT flightId FROM Flight WHERE flightNo = '" + cmbPassengerBookingFlightName.SelectedItem.ToString() + "') AND flightSeatStatus = 'Booked';";

            var checkSeatAvailabilityQueryResult = DbHelper.GetQueryData(checkSeatAvailabilityQuery);

            if (checkSeatAvailabilityQueryResult.HasError)
            {
                MessageBox.Show("Error : " + checkSeatAvailabilityQueryResult.Message);
                return;
            }

            if (checkSeatAvailabilityQueryResult.Data.Rows.Count > 0)
            {
                List<string> alreadyBookedSeats = new List<string>();
                foreach (DataRow row in checkSeatAvailabilityQueryResult.Data.Rows)
                {
                    alreadyBookedSeats.Add(row["seatNo"].ToString());
                }

                MessageBox.Show("Error: The following seats are already booked: " + string.Join(", ", alreadyBookedSeats) + ". Please select different seats.");
                txtPassengerBookingBookedSeats.Text = "";
                return;
            }


            // Inserting Booking data into the database
            try
            {
                // getting flightId from flight table based on selected flightNo
                string getFlightIdQuery = "SELECT * FROM Flight WHERE flightNo = '" + cmbPassengerBookingFlightName.SelectedItem.ToString() + "';";

                var getFlightIdQueryResult = DbHelper.GetQueryData(getFlightIdQuery);

                if (getFlightIdQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + getFlightIdQueryResult.Message);
                    return;
                }

                if (getFlightIdQueryResult.Data.Rows.Count < 1)
                {
                    MessageBox.Show("Error: Flight not found. Please select a valid Flight No.");
                    ClearBookingSelection();
                    return;
                }


                // stroing flightId
                int flightId = Convert.ToInt32(getFlightIdQueryResult.Data.Rows[0]["flightId"]);


                string getFlightSeatIdQuery = "SELECT * FROM FlightSeats WHERE flightId = '" + flightId + "' AND seatNo IN ('" + string.Join("','", bookedSeats.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)) + "');";

                var getFlightSeatIdQueryResult = DbHelper.GetQueryData(getFlightSeatIdQuery);

                if (getFlightSeatIdQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + getFlightSeatIdQueryResult.Message);
                    return;
                }


                // storing flightSeatIds in a list
                List<int> flightSeatIds = new List<int>();

                foreach (DataRow row in getFlightSeatIdQueryResult.Data.Rows)
                {
                    flightSeatIds.Add(Convert.ToInt32(row["flightSeatId"]));
                }


                // Calculating amount for payment
                int seatCount = bookedSeats.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                int amount = (100 * seatCount);


                // Inserting payment record
                string insertPaymentQuery = "INSERT INTO Payment (amount, paymentDate, paymentType, paymentStatus, userId) " + "VALUES ('" + amount + "', '" + BookingDate + "', 'Cash', 'Pending', '" + userId + "');";

                var insertPaymentQueryResult = DbHelper.ExecuteNonResultQuery(insertPaymentQuery);
                if (insertPaymentQueryResult.HasError)
                {
                    MessageBox.Show("Error: " + insertPaymentQueryResult.Message);
                    return;
                }


                // Get the paymentId of the newly created payment record
                string getPaymentIdQuery = "SELECT TOP 1 paymentId FROM Payment WHERE userId = '" + userId + "' ORDER BY paymentId DESC;";

                var getPaymentIdQueryResult = DbHelper.GetQueryData(getPaymentIdQuery);

                if (getPaymentIdQueryResult.HasError)
                {
                    MessageBox.Show("Error: " + getPaymentIdQueryResult.Message);
                    return;
                }

                int paymentId = Convert.ToInt32(getPaymentIdQueryResult.Data.Rows[0]["paymentId"]);


                // Inserting booking records and updating flightSeats status
                foreach (int seatId in flightSeatIds)
                {
                    // Inserting booking record
                    string insertBookingQuery = "INSERT INTO Book (bookingDate, userId, bookingStatus, flightSeatId, flightId, paymentId) " + "VALUES ('" + BookingDate.ToString("yyyy-MM-dd") + "', '" + userId + "', '" + BookingStatus + "', '" + seatId + "', '" + flightId + "', '" + paymentId + "');";

                    var insertBookingQueryResult = DbHelper.ExecuteNonResultQuery(insertBookingQuery);

                    if (insertBookingQueryResult.HasError)
                    {
                        MessageBox.Show("Error: " + insertBookingQueryResult.Message);
                        return;
                    }


                    // Updating flightSeat status to 'Booked' and assigning userId
                    string updateFlightSeatStatusQuery = "UPDATE FlightSeats SET flightSeatStatus = 'Booked', userId = '" + userId + "', paymentId = '" + paymentId + "' WHERE flightSeatId = '" + seatId + "';";

                    var updateFlightSeatStatusQueryResult = DbHelper.ExecuteNonResultQuery(updateFlightSeatStatusQuery);

                    if (updateFlightSeatStatusQueryResult.HasError)
                    {
                        MessageBox.Show("Error: " + updateFlightSeatStatusQueryResult.Message);
                        return;
                    }
                }

                // Getting the newly created bookingId
                string getBookingIdQuery = "SELECT TOP 1 bookingId FROM Book WHERE userId = '" + userId + "' ORDER BY bookingId DESC;";

                var getBookingIdQueryResult = DbHelper.GetQueryData(getBookingIdQuery);

                if (getBookingIdQueryResult.HasError)
                {
                    MessageBox.Show("Error: " + getBookingIdQueryResult.Message);
                    return;
                }


                // storing bookingId
                int bookingId = Convert.ToInt32(getBookingIdQueryResult.Data.Rows[0]["bookingId"]);


                // updating payment record with the bookingId
                string updatePaymentWithBookingIdQuery = "UPDATE Payment SET bookingId = '" + bookingId + "' WHERE paymentId = '" + paymentId + "';";

                var updatePaymentWithBookingIdQueryResult = DbHelper.ExecuteNonResultQuery(updatePaymentWithBookingIdQuery);

                if (updatePaymentWithBookingIdQueryResult.HasError)
                {
                    MessageBox.Show("Error: " + updatePaymentWithBookingIdQueryResult.Message);
                    return;
                }


                MessageBox.Show("Message: Booking Added Successfully.");

                ClearBookingSelection();
                ShowBookingInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
                return;
            }
        }


        // Delete Button Click Event
        private void btnPassengerBookingDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string bookedSeats = txtPassengerBookingBookedSeats.Text.Trim();
                if (string.IsNullOrWhiteSpace(bookedSeats))
                {
                    MessageBox.Show("Error: No seats selected.");
                    return;
                }

                if (!int.TryParse(txtPassengerBookingPassengerId.Text, out int userId))
                {
                    MessageBox.Show("Error: Invalid passenger id.");
                    return;
                }

                // Get the flightSeatIds for the selected seatNos
                string seatList = "'" + string.Join("','", bookedSeats.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)) + "'";
                string flightNo = cmbPassengerBookingFlightName.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(flightNo))
                {
                    MessageBox.Show("Error: Flight not selected.");
                    return;
                }

                string getBookingDataQuery = "SELECT flightSeatId, seatNo FROM FlightSeats " +
                                             "WHERE seatNo IN (" + seatList + ") " +
                                             "AND flightId = (SELECT flightId FROM Flight WHERE flightNo = '" + flightNo + "') " +
                                             "AND flightSeatStatus = 'Booked';";

                var getBookingDataQueryResult = DbHelper.GetQueryData(getBookingDataQuery);
                if (getBookingDataQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + getBookingDataQueryResult.Message);
                    return;
                }

                if (getBookingDataQueryResult.Data.Rows.Count == 0)
                {
                    MessageBox.Show("No booked seats found for the selected seats/flight.");
                    return;
                }

                var bookedSeatIds = new List<int>();
                foreach (DataRow r in getBookingDataQueryResult.Data.Rows)
                    bookedSeatIds.Add(Convert.ToInt32(r["flightSeatId"]));

                // Collect paymentIds encountered so we can evaluate deletion later
                var paymentIdsEncountered = new HashSet<int>();

                foreach (int seatId in bookedSeatIds)
                {
                    // Find booking(s) for this flightSeatId and user
                    string getBookingInfo = "SELECT bookingId, paymentId FROM Book WHERE flightSeatId = " + seatId + " AND userId = " + userId + ";";
                    var getBookingInfoResult = DbHelper.GetQueryData(getBookingInfo);

                    if (getBookingInfoResult.HasError)
                    {
                        MessageBox.Show("Error : " + getBookingInfoResult.Message);
                        continue; // move to next seat
                    }

                    if (getBookingInfoResult.Data.Rows.Count == 0)
                    {
                        // no Book rows for this seat+user — skip it
                        continue;
                    }

                    // gather bookingIds & paymentIds for the seat (usually one)
                    var bookingIds = new List<int>();
                    foreach (DataRow br in getBookingInfoResult.Data.Rows)
                    {
                        if (br["bookingId"] != DBNull.Value) bookingIds.Add(Convert.ToInt32(br["bookingId"]));
                        if (br["paymentId"] != DBNull.Value) paymentIdsEncountered.Add(Convert.ToInt32(br["paymentId"]));
                    }

                    // 1) Update FlightSeats by flightSeatId (do NOT require paymentId)
                    string updateFlightSeatStatusQuery = "UPDATE FlightSeats SET flightSeatStatus = 'Available', userId = NULL, paymentId = NULL WHERE flightSeatId = " + seatId + ";";
                    var updateFlightSeatStatusQueryResult = DbHelper.ExecuteNonResultQuery(updateFlightSeatStatusQuery);
                    if (updateFlightSeatStatusQueryResult.HasError)
                    {
                        MessageBox.Show("Error updating FlightSeats for seatId " + seatId + " : " + updateFlightSeatStatusQueryResult.Message);
                        // continue trying other seats
                    }

                    // 2) Delete Book rows for this seat (all bookingIds found)
                    foreach (int bookingId in bookingIds)
                    {
                        string deleteBookingRecordQuery = "DELETE FROM Book WHERE bookingId = " + bookingId + ";";
                        var deleteBookingRecordQueryResult = DbHelper.ExecuteNonResultQuery(deleteBookingRecordQuery);
                        if (deleteBookingRecordQueryResult.HasError)
                        {
                            MessageBox.Show("Error deleting Book record " + bookingId + " : " + deleteBookingRecordQueryResult.Message);
                            // continue with other bookingIds
                        }
                    }
                } // end foreach seatId

                // After processing seats, safely delete payment records only if no Book references them
                foreach (int pid in paymentIdsEncountered)
                {
                    try
                    {
                        if (pid <= 0) continue;

                        string checkPaymentRefQuery = "SELECT COUNT(*) AS cnt FROM Book WHERE paymentId = " + pid + ";";
                        var checkPaymentRefResult = DbHelper.GetQueryData(checkPaymentRefQuery);
                        if (checkPaymentRefResult.HasError)
                        {
                            MessageBox.Show("Error checking payment references for paymentId " + pid + " : " + checkPaymentRefResult.Message);
                            continue;
                        }

                        int cnt = 0;
                        if (checkPaymentRefResult.Data.Rows.Count > 0 && checkPaymentRefResult.Data.Rows[0]["cnt"] != DBNull.Value)
                            cnt = Convert.ToInt32(checkPaymentRefResult.Data.Rows[0]["cnt"]);

                        if (cnt == 0)
                        {
                            string deletePaymentQuery = "DELETE FROM Payment WHERE paymentId = " + pid + ";";
                            var deletePaymentQueryResult = DbHelper.ExecuteNonResultQuery(deletePaymentQuery);
                            if (deletePaymentQueryResult.HasError)
                            {
                                MessageBox.Show("Error deleting payment " + pid + " : " + deletePaymentQueryResult.Message);
                            }
                        }
                        // else: payment still referenced by other Book rows - do not delete
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error handling payment " + pid + " : " + ex.Message);
                        continue;
                    }
                }

                ClearBookingSelection();
                ShowBookingInfo();
                MessageBox.Show("Message: Booking Deleted Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }
    }
}
