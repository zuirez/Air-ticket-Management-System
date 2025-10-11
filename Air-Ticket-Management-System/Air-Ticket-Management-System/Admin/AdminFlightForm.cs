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
    public partial class AdminFlightForm : Form
    {
        public AdminFlightForm()
        {
            InitializeComponent();
        }


        // Method to clear all fields
        public void clearFlightSelection()
        {
            txtAdminFlightNo.Text = "";
            txtAdminFlightOrigin.Text = "";
            txtAdminFlightDestination.Text = "";
            dtpAdminFlightDepartureTime.Value = DateTime.Now;
            dtpAdminFlightArrivalTime.Value = DateTime.Now;
            rdbOnTime.Checked = false;
            rdbDelayed.Checked = false;
            rdbCancelled.Checked = false;
        }


        // Method to display flight information in the DataGridView
        public void showFlightInfo()
        {
            txtAdminFlightId.Text = "Auto Generated";

            string query = "SELECT * FROM Flight;";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            dgvAdminFlight.DataSource = result.Data;
            dgvAdminFlight.Refresh();
            dgvAdminFlight.ClearSelection();
        }


        // Form Load Event
        private void AdminFlightForm_Load(object sender, EventArgs e)
        {
            showFlightInfo();
        }


        // Search Button Click Event
        private void btnFlightSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtFlightSearch.Text;

            // Checking if search text is empty
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Error: Enter Flight Number/ Flight Id/ Flight origin/ Flight destination/ Flight status.");
                txtFlightSearch.Text = "";
                clearFlightSelection();
                showFlightInfo();
                return;
            }


            // Searching flight data in the database
            string query = "SELECT * FROM Flight WHERE flightNo = '" + searchText + "' OR CAST(flightId AS VARCHAR) = '" + searchText + "' OR origin = '" + searchText + "' OR destination = '" + searchText + "' OR flightStatus = '" + searchText + "';";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message); txtFlightSearch.Text = "";
                return;
            }

            dgvAdminFlight.DataSource = result.Data;
            dgvAdminFlight.Refresh();
            dgvAdminFlight.ClearSelection();

            txtFlightSearch.Text = "";
        }


        // Refresh Button Click Event
        private void btnFlightRefresh_Click(object sender, EventArgs e)
        {
            txtFlightSearch.Text = "";
            clearFlightSelection();
            showFlightInfo();
        }


        // DataGridView Cell Double Click Event
        private void dgvAdminFlight_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    dgvAdminFlight.ClearSelection();
                    return;
                }

                int FlightId = Convert.ToInt32(dgvAdminFlight.Rows[e.RowIndex].Cells["flightId"].Value);


                // Selecting all information of the selected flight
                string query = "SELECT * FROM Flight WHERE flightId = '" + FlightId + "'";

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                txtAdminFlightId.Text = Convert.ToString(result.Data.Rows[0]["flightId"]);
                txtAdminFlightNo.Text = Convert.ToString(result.Data.Rows[0]["flightNo"]);
                txtAdminFlightOrigin.Text = Convert.ToString(result.Data.Rows[0]["origin"]);
                txtAdminFlightDestination.Text = Convert.ToString(result.Data.Rows[0]["destination"]);
                string status = Convert.ToString(result.Data.Rows[0]["flightStatus"]);
                dtpAdminFlightDepartureTime.Value = Convert.ToDateTime(result.Data.Rows[0]["departureTime"]);
                dtpAdminFlightArrivalTime.Value = Convert.ToDateTime(result.Data.Rows[0]["arrivalTime"]);

                if (status == "On Time")
                {
                    rdbOnTime.Checked = true;
                }
                else if (status == "Delayed")
                {
                    rdbDelayed.Checked = true;
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


        // Add Button Click Event
        private void btnAdminFlightAdd_Click(object sender, EventArgs e)
        {
            string FlightNo = txtAdminFlightNo.Text;
            string FlightOrigin = txtAdminFlightOrigin.Text;
            string FlightDestination = txtAdminFlightDestination.Text;
            string FlightStatus = "";
            DateTime FlightDepartureTime = dtpAdminFlightDepartureTime.Value;
            DateTime FlightArrivalTime = dtpAdminFlightArrivalTime.Value;

            if (rdbOnTime.Checked)
            {
                FlightStatus = rdbOnTime.Text;
            }
            else if (rdbDelayed.Checked)
            {
                FlightStatus = rdbDelayed.Text;
            }
            else if (rdbCancelled.Checked)
            {
                FlightStatus = rdbCancelled.Text;
            }


            // Checking if any field is empty
            if (string.IsNullOrWhiteSpace(FlightNo))
            {
                MessageBox.Show("Error: Enter Flight Number");
                return;
            }
            if (string.IsNullOrWhiteSpace(FlightOrigin))
            {
                MessageBox.Show("Error: Enter Flight Origin");
                return;
            }
            if (string.IsNullOrWhiteSpace(FlightDestination))
            {
                MessageBox.Show("Error: Enter Flight Destination");
                return;
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(FlightDepartureTime)))
            {
                MessageBox.Show("Error: Enter Flight Departure Time");
                return;
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(FlightArrivalTime)))
            {
                MessageBox.Show("Error: Enter Flight Arrival Time");
                return;
            }
            if (!rdbOnTime.Checked)
            {
                if (!rdbDelayed.Checked)
                {
                    if (!rdbCancelled.Checked)
                    {
                        MessageBox.Show("Error: Select Flight Status");
                        return;
                    }
                }
            }


            // Validating that flight number is unique
            string checkFlightNo = "SELECT * FROM Flight WHERE flightNo = '" + FlightNo + "';";

            var checkFlightNoResult = DbHelper.GetQueryData(checkFlightNo);

            if (checkFlightNoResult.HasError)
            {
                MessageBox.Show("Error : " + checkFlightNoResult.Message);
                return;
            }
            if (checkFlightNoResult.Data.Rows.Count > 0)
            {
                MessageBox.Show("Error: Flight Number already exists. Please use a different Flight Number.");
                return;
            }


            // Validating that origin and destination are not the same
            if (FlightOrigin == FlightDestination)
            {
                MessageBox.Show("Error: Flight Origin and Destination cannot be the same.");
                return;
            }


            // Validating that departure time is unique
            string checkDepartureTime = "SELECT * FROM Flight WHERE departureTime = '" + FlightDepartureTime.ToString("yyyy-MM-dd HH:mm:ss") + "' AND origin = 'Dhaka';";
            
            var checkDepartureTimeResult = DbHelper.GetQueryData(checkDepartureTime);
            
            if (checkDepartureTimeResult.HasError)
            {
                MessageBox.Show("Error : " + checkDepartureTimeResult.Message);
                return;
            }
            if (checkDepartureTimeResult.Data.Rows.Count > 0)
            {
                MessageBox.Show("Error: Departure Time already exists. Please choose a different Departure Time.");
                return;
            }


            // Validating that arrival time is unique
            string checkArrivalTime = "SELECT * FROM Flight WHERE arrivalTime = '" + FlightArrivalTime.ToString("yyyy-MM-dd HH:mm:ss") + "' AND destination = 'Dhaka';";
            
            var checkArrivalTimeResult = DbHelper.GetQueryData(checkArrivalTime);
            
            if (checkArrivalTimeResult.HasError)
            {
                MessageBox.Show("Error : " + checkArrivalTimeResult.Message);
                return;
            }
            if (checkArrivalTimeResult.Data.Rows.Count > 0)
            {
                MessageBox.Show("Error: Arrival Time already exists. Please choose a different Arrival Time.");
                return;
            }


            // Validating that arrival time is after departure time
            if (FlightArrivalTime <= FlightDepartureTime)
            {
                MessageBox.Show("Error: Arrival time must be after Departure time.");
                return;
            }


            // Inserting flight data into the database
            try
            {
                string query = "INSERT INTO Flight VALUES ('" + FlightNo + "', '" + FlightOrigin + "', '" + FlightDestination + "', '" + FlightArrivalTime + "', '" + FlightDepartureTime + "', '" + FlightStatus + "');";

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                MessageBox.Show("Message: Flight Added Successfully.");


                // Adding flight seats for this flight
                string getFlightIdQuery = "SELECT flightId FROM Flight WHERE flightNo = '" + FlightNo + "';";

                var getFlightIdResult = DbHelper.GetQueryData(getFlightIdQuery);

                if (getFlightIdResult.HasError)
                {
                    MessageBox.Show("Error : " + getFlightIdResult.Message);
                    return;
                }

                int flightId = Convert.ToInt32(getFlightIdResult.Data.Rows[0]["flightId"]);

                char[] rows = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

                int seatsPerRow = 6;

                for (int row = 0; row < rows.Length; row++)
                {
                    for (int seat = 1; seat <= seatsPerRow; seat++)
                    {
                        string seatNo = rows[row].ToString() + seat.ToString();

                        string seatQuery = "INSERT INTO FlightSeats (flightId, seatNo, flightSeatStatus) " + "VALUES ('" + flightId + "', '" + seatNo + "', 'Available');";

                        var seatResult = DbHelper.ExecuteNonResultQuery(seatQuery);

                        if (seatResult.HasError)
                        {
                            MessageBox.Show("Error : " + seatResult.Message);
                            return;
                        }
                    }
                }

                clearFlightSelection();
                showFlightInfo();
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
            int FlightId = Convert.ToInt32(txtAdminFlightId.Text);
            string FlightNo = txtAdminFlightNo.Text;
            string FlightOrigin = txtAdminFlightOrigin.Text;
            string FlightDestination = txtAdminFlightDestination.Text;
            string FlightStatus = "";
            DateTime FlightDepartureTime = dtpAdminFlightDepartureTime.Value;
            DateTime FlightArrivalTime = dtpAdminFlightArrivalTime.Value;

            if (rdbOnTime.Checked)
            {
                FlightStatus = rdbOnTime.Text;
            }
            else if (rdbDelayed.Checked)
            {
                FlightStatus = rdbDelayed.Text;
            }
            else if (rdbCancelled.Checked)
            {
                FlightStatus = rdbCancelled.Text;
            }


            // Checking if any field is empty
            if (string.IsNullOrWhiteSpace(FlightNo))
            {
                MessageBox.Show("Error: Enter Flight Number");
                return;
            }
            if (string.IsNullOrWhiteSpace(FlightOrigin))
            {
                MessageBox.Show("Error: Enter Flight Origin");
                return;
            }
            if (string.IsNullOrWhiteSpace(FlightDestination))
            {
                MessageBox.Show("Error: Enter Flight Destination");
                return;
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(FlightDepartureTime)))
            {
                MessageBox.Show("Error: Enter Flight Departure Time");
                return;
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(FlightArrivalTime)))
            {
                MessageBox.Show("Error: Enter Flight Arrival Time");
                return;
            }
            if (!rdbOnTime.Checked)
            {
                if (!rdbDelayed.Checked)
                {
                    if (!rdbCancelled.Checked)
                    {
                        MessageBox.Show("Error: Select Flight Status");
                        return;
                    }
                }
            }


            // Validating that origin and destination are not the same
            if (FlightOrigin == FlightDestination)
            {
                MessageBox.Show("Error: Flight Origin and Destination cannot be the same.");
                return;
            }


            // Validating that departure time is unique
            if (FlightDestination == null) 
            {
                MessageBox.Show("Error: Flight Destination cannot be null.");
                return;
            }
            string checkDepartureTime = "SELECT * FROM Flight WHERE departureTime = '" + FlightDepartureTime.ToString("yyyy-MM-dd HH:mm:ss") + "' AND flightId != '" + FlightId + "';";
            var checkDepartureTimeResult = DbHelper.GetQueryData(checkDepartureTime);
            if (checkDepartureTimeResult.HasError)
            {
                MessageBox.Show("Error : " + checkDepartureTimeResult.Message);
                return;
            }
            if (checkDepartureTimeResult.Data.Rows.Count > 0)
            {
                MessageBox.Show("Error: Departure Time already exists. Please choose a different Departure Time.");
                return;
            }


            // Validating that arrival time is uquique
            string checkArrivalTime = "SELECT * FROM Flight WHERE arrivalTime = '" + FlightArrivalTime.ToString("yyyy-MM-dd HH:mm:ss") + "' AND flightId != '" + FlightId + "';";
            var checkArrivalTimeResult = DbHelper.GetQueryData(checkArrivalTime);
            if (checkArrivalTimeResult.HasError)
            {
                MessageBox.Show("Error : " + checkArrivalTimeResult.Message);
                return;
            }
            if (checkArrivalTimeResult.Data.Rows.Count > 0)
            {
                MessageBox.Show("Error: Arrival Time already exists. Please choose a different Arrival Time.");
                return;
            }


            // Validating that arrival time is after departure time
            if (FlightArrivalTime <= FlightDepartureTime)
            {
                MessageBox.Show("Error: Arrival time must be after Departure time.");
                return;
            }


            // Updating flight data into the database
            try
            {
                string query = "UPDATE Flight SET FlightNo = '" + FlightNo + "', Origin = '" + FlightOrigin + "', Destination = '" + FlightDestination + "', DepartureTime = '" + FlightDepartureTime + "', ArrivalTime = '" + FlightArrivalTime + "', FlightStatus = '" + FlightStatus + "' WHERE FlightID = '" + FlightId + "';";

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                MessageBox.Show("Message: Flight Updated Successfully.");

                clearFlightSelection();
                showFlightInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);

            }
        }


        // Delete Button Click Event
        private void btnAdminFlightDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int FlightId = Convert.ToInt32(txtAdminFlightId.Text);

                // Deleting flight seats associated with this flight
                string deleteFlightSeatsQuery = "DELETE FROM FlightSeats WHERE flightId = '" + FlightId + "';";

                var deleteFlightSeatsQueryResult = DbHelper.ExecuteNonResultQuery(deleteFlightSeatsQuery);

                if (deleteFlightSeatsQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + deleteFlightSeatsQueryResult.Message);
                    return;
                }


                // Deleting the flight
                string deleteFlightQuery = "DELETE FROM Flight WHERE flightId = '" + FlightId + "';";

                var deleteFlightQueryResult = DbHelper.ExecuteNonResultQuery(deleteFlightQuery);

                if (deleteFlightQueryResult.HasError)
                {
                    MessageBox.Show("Error : " + deleteFlightQueryResult.Message);
                    return;
                }

                clearFlightSelection();
                showFlightInfo();

                MessageBox.Show("Message: Flight Deleted Successfully.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }
    }
}
