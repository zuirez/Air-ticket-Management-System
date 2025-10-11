using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Air_Ticket_Management_System
{
    public partial class AdminBookingForm : Form
    {
        public AdminBookingForm()
        {
            InitializeComponent();
        }


        // Method to clear input fields
        private void ClearBookingSelection()
        {
            txtAdminBookingPassengerId.ReadOnly = false;
            cmbAdminBookingFlightName.Enabled = true;
            dtpAdminBookingDate.Value = DateTime.Now;
            txtAdminBookingPassengerId.Text = "";
            cmbAdminBookingFlightName.SelectedIndex = -1;
            txtAdminBookingFlightOrigin.Text = "";
            txtAdminBookingFlightDestination.Text = "";
            txtAdminBookingPaymentStatus.Text = "";
            txtAdminBookingBookedSeats.Text = "";
            rdbCancelled.Checked = false;
            rdbConfirmed.Checked = false;
            rdbPending.Checked = false;
        }


        // Method to display booking information
        private void ShowBookingInfo()
        {
            txtAdminBookingId.Text = "Auto Generated";
            txtAdminBookingPaymentStatus.Text = "Pending";
            rdbPending.Checked = true;
            rdbCancelled.Enabled = false;
            rdbConfirmed.Enabled = false;

            string query = "SELECT * FROM BOOK";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            dgvAdminBooking.DataSource = result.Data;
            dgvAdminBooking.Refresh();
            dgvAdminBooking.ClearSelection();
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

            cmbAdminBookingFlightName.Items.Clear();

            foreach (DataRow row in result.Data.Rows)
            {
                cmbAdminBookingFlightName.Items.Add(row["flightNo"].ToString());
            }
        }


        // Methode to populate flight origin and destination based on selected flight name
        private void cmbAdminBookingFlightName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbAdminBookingFlightName.SelectedItem == null || cmbAdminBookingFlightName.SelectedIndex == -1)
            {
                txtAdminBookingFlightId.Text = "";
                txtAdminBookingFlightOrigin.Text = "";
                txtAdminBookingFlightDestination.Text = "";
                return;
            }

            string selectedFlightNo = cmbAdminBookingFlightName.SelectedItem.ToString();

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
                    txtAdminBookingFlightId.Text = result.Data.Rows[0]["flightId"].ToString();
                    txtAdminBookingFlightOrigin.Text = result.Data.Rows[0]["origin"].ToString();
                    txtAdminBookingFlightDestination.Text = result.Data.Rows[0]["destination"].ToString();
                }
                else
                {
                    txtAdminBookingFlightId.Text = "";
                    txtAdminBookingFlightOrigin.Text = "";
                    txtAdminBookingFlightDestination.Text = "";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unexpected error: " + exception.Message);
                return;
            }
        }


        // Form Load Event
        private void AdminBookingForm_Load(object sender, EventArgs e)
        {
            ShowBookingInfo();
            ShowFlightNames();
        }


        // Search Button Click Event
        private void btnBookingSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtBookingSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Error: Enter Booking Id/ Booking status/ Passenger ID.");
                txtBookingSearch.Text = "";
                return;
            }

            string searchBookingQuery = "SELECT * FROM BOOK WHERE CAST(bookingId AS VARCHAR) = '" + searchText + "' OR bookingStatus = '" + searchText + "' OR CAST(userId as VARCHAR) = '" + searchText + "';";

            var searchBookingQueryResult = DbHelper.GetQueryData(searchBookingQuery);

            if (searchBookingQueryResult.HasError)
            {
                MessageBox.Show("Error : " + searchBookingQueryResult.Message);
                txtBookingSearch.Text = "";
                return;
            }

            dgvAdminBooking.DataSource = searchBookingQueryResult.Data;
            dgvAdminBooking.Refresh();
            dgvAdminBooking.ClearSelection();

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
        private void dgvAdminBooking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    dgvAdminBooking.ClearSelection();
                    return;
                }

                int BookingId = Convert.ToInt32(dgvAdminBooking.Rows[e.RowIndex].Cells["bookingId"].Value);

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

                txtAdminBookingPassengerId.ReadOnly = true;

                txtAdminBookingId.Text = Convert.ToString(GetBookQueryResult.Data.Rows[0]["bookingId"]);
                string BookingStatus = Convert.ToString(GetBookQueryResult.Data.Rows[0]["bookingStatus"]);
                dtpAdminBookingDate.Value = Convert.ToDateTime(GetBookQueryResult.Data.Rows[0]["bookingDate"]);
                int PassengerId = Convert.ToInt32(GetBookQueryResult.Data.Rows[0]["userId"]);
                txtAdminBookingPassengerId.Text = Convert.ToString(GetBookQueryResult.Data.Rows[0]["userId"]);
                int FlightId = Convert.ToInt32(GetBookQueryResult.Data.Rows[0]["flightId"]);
                txtAdminBookingFlightId.Text = Convert.ToString(GetBookQueryResult.Data.Rows[0]["flightId"]);

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

                cmbAdminBookingFlightName.Text = Convert.ToString(GetFLightQueryResult.Data.Rows[0]["flightNo"]);
                txtAdminBookingFlightOrigin.Text = Convert.ToString(GetFLightQueryResult.Data.Rows[0]["origin"]);
                txtAdminBookingFlightDestination.Text = Convert.ToString(GetFLightQueryResult.Data.Rows[0]["destination"]);


                // making combobox readonly
                cmbAdminBookingFlightName.Enabled = false;


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

                txtAdminBookingBookedSeats.Text = string.Join(", ", bookedSeats);


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
                    txtAdminBookingPaymentStatus.Text = "Paid";
                    rdbConfirmed.Checked = true;
                    rdbConfirmed.Enabled = true;
                    rdbCancelled.Enabled = false;
                    rdbPending.Enabled = false;
                }
                else if (paymentStatus == "Cancelled")
                {
                    txtAdminBookingPaymentStatus.Text = "Cancelled";
                    rdbCancelled.Checked = true;
                    rdbCancelled.Enabled = true;
                    rdbPending.Enabled = false;
                    rdbConfirmed.Enabled = false;
                }
                else
                {
                    txtAdminBookingPaymentStatus.Text = "Pending";
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
        private void btnAdminBookingFlightSeat_Click(object sender, EventArgs e)
        {
            string FlightNo = cmbAdminBookingFlightName.Text;

            if (string.IsNullOrWhiteSpace(FlightNo))
            {
                MessageBox.Show("Error: Select flight no First");
                return;
            }

            AdminFlightSeats flightSeats = new AdminFlightSeats(FlightNo, txtAdminBookingBookedSeats);
            flightSeats.ShowDialog();
        }


        // Add Button Click Event g
        private void btnAdminFlightAdd_Click_1(object sender, EventArgs e)
        {
            // Checking if any field is empty
            if (string.IsNullOrWhiteSpace(txtAdminBookingPassengerId.Text))
            {
                MessageBox.Show("Error: Enter Passenger ID");
                ClearBookingSelection();
                ShowBookingInfo();
                return;
            }

            if (cmbAdminBookingFlightName.SelectedItem == null || cmbAdminBookingFlightName.SelectedIndex == -1)
            {
                MessageBox.Show("Error: Select Flight No");
                ClearBookingSelection();
                ShowBookingInfo();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAdminBookingBookedSeats.Text))
            {
                MessageBox.Show("Error: Select Seats");
                ClearBookingSelection();
                ShowBookingInfo();
                return;
            }


            // Getting data from input fields
            int userId = Convert.ToInt32(txtAdminBookingPassengerId.Text);
            DateTime BookingDate = dtpAdminBookingDate.Value;
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
                ShowBookingInfo();
                return;
            }


            // getting flightSeats id from txtAdminBookingBookedSeats
            string bookedSeats = txtAdminBookingBookedSeats.Text.Trim();


            // Cheacking if any other user has already booked the same seats on the same flight
            string checkSeatAvailabilityQuery = "SELECT * FROM FlightSeats WHERE seatNo IN ('" + string.Join("','", bookedSeats.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)) + "') AND flightId = (SELECT flightId FROM Flight WHERE flightNo = '" + cmbAdminBookingFlightName.SelectedItem.ToString() + "') AND flightSeatStatus = 'Booked';";

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
                txtAdminBookingBookedSeats.Text = "";
                return;
            }


            // Inserting Booking data into the database
            try
            {
                // getting flightId from flight table based on selected flightNo
                string getFlightIdQuery = "SELECT * FROM Flight WHERE flightNo = '" + cmbAdminBookingFlightName.SelectedItem.ToString() + "';";

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


                // getting flightSeatIds from flightSeats table based on flightId and SeatNos 
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


        // Update Button Click Event
        private void btnAdminFlightUpdate_Click(object sender, EventArgs e)
        {
            // if payment status is confirmed then return 
            if (txtAdminBookingPaymentStatus.Text == "Paid")
            {
                MessageBox.Show("Error: Cannot update a confirmed booking.");
                ClearBookingSelection();
                ShowBookingInfo();
                return;
            }

            try
            {
                // Checking if any field is empty
                if (string.IsNullOrWhiteSpace(txtAdminBookingPassengerId.Text))
                {
                    MessageBox.Show("Error: Enter Passenger ID");
                    return;
                }

                if (cmbAdminBookingFlightName.SelectedItem == null || cmbAdminBookingFlightName.SelectedIndex == -1)
                {
                    MessageBox.Show("Error: Select Flight No");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAdminBookingBookedSeats.Text))
                {
                    MessageBox.Show("Error: Select Seats");
                    return;
                }


                int bookingId = Convert.ToInt32(txtAdminBookingId.Text);
                int userId = Convert.ToInt32(txtAdminBookingPassengerId.Text);
                dtpAdminBookingDate.Enabled = false;
                DateTime bookingDate = DateTime.Now;
                string bookedSeats = txtAdminBookingBookedSeats.Text.Trim();


                // Getting paymentId from book table uisng bookingId
                string getPaymentIdQuery = "SELECT paymentId FROM Book WHERE bookingId = '" + bookingId + "';";
                
                var getPaymentIdQueryResult = DbHelper.GetQueryData(getPaymentIdQuery);
                
                if (getPaymentIdQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + getPaymentIdQueryResult.Message);
                    return;
                }
                if (getPaymentIdQueryResult.Data.Rows.Count < 1)
                {
                    MessageBox.Show("Error: Payment record not found for the selected booking.");
                    ClearBookingSelection();
                    return;
                }


                // Storing paymentId
                int paymentId = Convert.ToInt32(getPaymentIdQueryResult.Data.Rows[0]["paymentId"]);


                // Getting flightId from flight table based on selected flightNo
                string getFlightIdQuery = "SELECT flightId FROM Flight WHERE flightNo = '" + cmbAdminBookingFlightName.SelectedItem.ToString() + "';";

                var getFlightIdQueryResult = DbHelper.GetQueryData(getFlightIdQuery);

                if (getFlightIdQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + getFlightIdQueryResult.Message);
                    return;
                }
                if (getFlightIdQueryResult.Data.Rows.Count < 1)
                {
                    MessageBox.Show("Error: Flight not found. Please select a valid Flight No.");
                    return;
                }


                // Storing flightId
                int flightId = Convert.ToInt32(getFlightIdQueryResult.Data.Rows[0]["flightId"]);


                // getting flightSeatIds from flightSeats table based on flightId and SeatNos 
                string getFlightSeatIdQuery = "SELECT * FROM FlightSeats WHERE flightId = '" + flightId + "' AND seatNo IN ('" + string.Join("','", bookedSeats.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)) + "');";

                var getFlightSeatIdQueryResult = DbHelper.GetQueryData(getFlightSeatIdQuery);

                if (getFlightSeatIdQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + getFlightSeatIdQueryResult.Message);
                    return;
                }


                // List to store flightSeatIds
                List<int> updatedFlightSeatIds = new List<int>();

                // storing flightSeatIds in a list
                foreach (DataRow row in getFlightSeatIdQueryResult.Data.Rows)
                {
                    updatedFlightSeatIds.Add(Convert.ToInt32(row["flightSeatId"]));
                }


                // Getting already booked seatIds for this bookingId
                string getExistingSeatsQuery = "SELECT flightSeatId FROM Book WHERE paymentId = '" + paymentId + "';";

                var getExistingSeatsResult = DbHelper.GetQueryData(getExistingSeatsQuery);

                // List to store existing booked seatIds
                List<int> existingSeatIds = new List<int>();

                // storing existing booked seatIds in a list
                foreach (DataRow row in getExistingSeatsResult.Data.Rows)
                {
                    existingSeatIds.Add(Convert.ToInt32(row["flightSeatId"]));
                }


                // Calculating new amount for payment
                int seatCount = bookedSeats.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                int amount = (100 * seatCount);


                // Updating payment record with new amount and booking date
                string updatePaymentQuery = "UPDATE Payment SET amount = '" + amount + "', paymentDate = '" + bookingDate.ToString("yyyy-MM-dd") + "' WHERE bookingId = '" + bookingId + "';";

                var updatePaymentQueryResult = DbHelper.ExecuteNonResultQuery(updatePaymentQuery);

                if (updatePaymentQueryResult.HasError)
                {
                    MessageBox.Show("Error: " + updatePaymentQueryResult.Message);
                    return;
                }


                // Updating booking records and updating flightSeats status
                foreach (int seatId in updatedFlightSeatIds)
                {
                    if (existingSeatIds.Contains(seatId))
                    {
                        // Updating booking record
                        string updateBookingQuery = "UPDATE Book SET bookingDate = '" + bookingDate.ToString("yyyy-MM-dd") + "', userId = '" + userId + "', flightSeatId = '" + seatId + "', flightId = '" + flightId + "', paymentId = '" + paymentId + "' WHERE bookingId = '" + bookingId + "';";

                        var updateBookingQueryResult = DbHelper.ExecuteNonResultQuery(updateBookingQuery);

                        if (updateBookingQueryResult.HasError)
                        {
                            MessageBox.Show("Error: " + updateBookingQueryResult.Message);
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
                    else
                    {
                        // Inserting new booking record
                        string insertBookingQuery = "INSERT INTO Book (bookingDate, userId, bookingStatus, flightSeatId, flightId, paymentId) VALUES ('" + bookingDate.ToString("yyyy-MM-dd") + "', '" + userId + "', 'Pending', '" + seatId + "', '" + flightId + "', '" + paymentId + "');";
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
                }

                MessageBox.Show("Message: Booking Updated Successfully.");
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
        private void btnAdminFlightDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string bookedSeats = txtAdminBookingBookedSeats.Text.Trim();
                int userId = Convert.ToInt32(txtAdminBookingPassengerId.Text);
                string flightNo = cmbAdminBookingFlightName.SelectedItem.ToString();

                // validating inputs
                if (string.IsNullOrWhiteSpace(bookedSeats))
                {
                    MessageBox.Show("Error: No seats selected.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtAdminBookingPassengerId.Text))
                {
                    MessageBox.Show("Error: Invalid passenger ID.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(flightNo))
                {
                    MessageBox.Show("Error: Flight not selected.");
                    return;
                }


                // Getting the booked seats
                string getBookingDataQuery = "SELECT flightSeatId, seatNo FROM FlightSeats WHERE seatNo IN ('" + string.Join("','", bookedSeats.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)) + "') AND flightId = (SELECT flightId FROM Flight WHERE flightNo = '" + flightNo + "') AND flightSeatStatus = 'Booked';";

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


                // Storing booked flightSeatIds
                var bookedSeatIds = new List<int>();

                foreach (DataRow row in getBookingDataQueryResult.Data.Rows)
                {
                    bookedSeatIds.Add(Convert.ToInt32(row["flightSeatId"]));
                }


                // Storing paymentId
                int paymentId = 0;


                // Getting paymentId and bookingIds for the booked seats
                foreach (int seatId in bookedSeatIds)
                {
                    // Find booking(s) for this flightSeatId and user
                    string getBookingInfo = "SELECT bookingId, paymentId FROM Book WHERE flightSeatId = " + seatId + " AND userId = " + userId + ";";
                    var getBookingInfoResult = DbHelper.GetQueryData(getBookingInfo);


                    // Storing paymentId
                    paymentId = Convert.ToInt32(getBookingInfoResult.Data.Rows[0]["paymentId"]);


                    // Gather bookingIds for the seat
                    var bookingIds = new List<int>();

                    foreach (DataRow row in getBookingInfoResult.Data.Rows)
                    {
                        if (row["bookingId"] != DBNull.Value)
                        {
                            bookingIds.Add(Convert.ToInt32(row["bookingId"]));
                        }
                    }


                    // Updating FlightSeats to avaiable
                    string updateFlightSeatStatusQuery = "UPDATE FlightSeats SET flightSeatStatus = 'Available', userId = NULL, paymentId = NULL WHERE flightSeatId = " + seatId + ";";
                    
                    var updateFlightSeatStatusQueryResult = DbHelper.ExecuteNonResultQuery(updateFlightSeatStatusQuery);
                    
                    if (updateFlightSeatStatusQueryResult.HasError)
                    {
                        MessageBox.Show("Error : " + updateFlightSeatStatusQueryResult.Message);
                    }

                    // Deleting Book rows for this seat 
                    foreach (int bookingId in bookingIds)
                    {
                        string deleteBookingRecordQuery = "DELETE FROM Book WHERE bookingId = " + bookingId + ";";

                        var deleteBookingRecordQueryResult = DbHelper.ExecuteNonResultQuery(deleteBookingRecordQuery);

                        if (deleteBookingRecordQueryResult.HasError)
                        {
                            MessageBox.Show("Error : " + deleteBookingRecordQueryResult.Message);
                            return;
                        }
                    }
                }


                // Deleting Payment record
                string deletePaymentQuery = "DELETE FROM Payment WHERE paymentId = " + paymentId + ";";
                var deletePaymentQueryResult = DbHelper.ExecuteNonResultQuery(deletePaymentQuery);
                if (deletePaymentQueryResult.HasError)
                { 
                    MessageBox.Show("Error : " + paymentId + " : " + deletePaymentQueryResult.Message);
                }

                ClearBookingSelection();
                ShowBookingInfo();

                MessageBox.Show("Message: Booking Deleted Successfully.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
                return;
            }
        }
    }
}
