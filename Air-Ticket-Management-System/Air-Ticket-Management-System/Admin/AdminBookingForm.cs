using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            dtpAdminBookingDate.Value = DateTime.Now;
            txtAdminBookingPassengerId.Text = "";
            cmbAdminBookingFlightName.SelectedIndex = -1;
            txtAdminBookingFlightOrigin.Text = "";
            txtAdminBookingFlightDestination.Text = "";
            txtAdminBookingPaymentStatus.Text = "";
            rdbCanceled.Checked = false;
            rdbConfirmed.Checked = false;
            rdbPending.Checked = false;
        }


        // Method to display booking information
        private void ShowBookingInfo()
        {
            txtAdminBookingId.Text = "Auto Generated";

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

            string searchBookingQuery = "SELECT * FROM BOOK WHERE CAST(bookingId AS VARCHAR) = '" + searchText + "' OR bookingStatus = '" + searchText + "' OR CAST(userId as VARCHAR) = '"+ searchText +"';";

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

                string GetBookQuery = "SELECT * FROM Book WHERE bookingId = '" + BookingId + "'";

                var GetBookQueryResult = DbHelper.GetQueryData(GetBookQuery);

                if (GetBookQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + GetBookQueryResult.Message);
                    return;
                }

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
                    rdbCanceled.Checked = true;
                }

                string GetFlightQuery = "SELECT * FROM FLIGHT WHERE flightId = '" + FlightId + "';";

                var GetFLightQueryResult = DbHelper.GetQueryData(GetFlightQuery);

                if(GetFLightQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + GetFLightQueryResult.Message);
                    return;
                }

                cmbAdminBookingFlightName.Text = Convert.ToString(GetFLightQueryResult.Data.Rows[0]["flightNo"]);
                txtAdminBookingFlightOrigin.Text = Convert.ToString(GetFLightQueryResult.Data.Rows[0]["origin"]);
                txtAdminBookingFlightDestination.Text = Convert.ToString(GetFLightQueryResult.Data.Rows[0]["destination"]);
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


        // Add Button Click Event
        private void btnAdminFlightAdd_Click_1(object sender, EventArgs e)
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

            if (!rdbConfirmed.Checked)
            {
                if (!rdbPending.Checked)
                {
                    if (!rdbCanceled.Checked)
                    {
                        MessageBox.Show("Error: Select Booking Status");
                        return;
                    }
                }
            }

            int userId = Convert.ToInt32(txtAdminBookingPassengerId.Text);
            DateTime BookingDate = dtpAdminBookingDate.Value;
            string BookingStatus = "";

            // Getting userId from userName
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


            // Getting Booking Status
            if (rdbConfirmed.Checked)
            {
                BookingStatus = rdbConfirmed.Text;
            }
            else if (rdbPending.Checked)
            {
                BookingStatus = rdbPending.Text;
            }
            else if (rdbCanceled.Checked)
            {
                BookingStatus = rdbCanceled.Text;
            }


            // Inserting Booking data into the database
            try
            {
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

                int flightId = Convert.ToInt32(getFlightIdQueryResult.Data.Rows[0]["flightId"]);


                // getting flightSeats id from txtAdminBookingBookedSeats
                string bookedSeats = txtAdminBookingBookedSeats.Text.Trim();

                if (string.IsNullOrWhiteSpace(bookedSeats))
                {
                    MessageBox.Show("Error: Please select booked seats.");
                    return;
                }

                string getFlightSeatIdQuery = "SELECT * FROM FlightSeats WHERE flightId = '" + flightId + "' AND seatNo IN ('" + string.Join("','", bookedSeats.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)) + "');";

                var getFlightSeatIdQueryResult = DbHelper.GetQueryData(getFlightSeatIdQuery);

                if (getFlightSeatIdQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + getFlightSeatIdQueryResult.Message);
                    return;
                }

                if (getFlightSeatIdQueryResult.Data.Rows.Count < 1)
                {
                    MessageBox.Show("Error: Selected seats not found. Please select valid seats.");
                    return;
                }

                List<int> flightSeatIds = new List<int>();
                foreach (DataRow row in getFlightSeatIdQueryResult.Data.Rows)
                {
                    flightSeatIds.Add(Convert.ToInt32(row["flightSeatId"]));
                }


                foreach (int seatId in flightSeatIds)
                {
                    string insertBookingQuery = "INSERT INTO Book (bookingDate, userId, bookingStatus, flightSeatId, flightId) " +
                                                "VALUES ('" + BookingDate.ToString("yyyy-MM-dd") + "', '" + userId + "', '" + BookingStatus + "', '" + seatId + "', '" + flightId + "');";

                    var insertBookingQueryResult = DbHelper.ExecuteNonResultQuery(insertBookingQuery);

                    if (insertBookingQueryResult.HasError)
                    {
                        MessageBox.Show("Error: " + insertBookingQueryResult.Message);
                        return;
                    }
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
    }
}
