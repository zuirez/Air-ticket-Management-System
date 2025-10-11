using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Ticket_Management_System.Employee
{
    public partial class EmployeeFlightForm : Form
    {
        public EmployeeFlightForm()
        {
            InitializeComponent();
        }


        // Method to clear all fields after adding or updating a flight
        public void clearFlightSelection()
        {
            txtEmployeeFlightNo.Text = "";
            txtEmployeeFlightOrigin.Text = "";
            txtEmployeeFlightDestination.Text = "";
            dtpEmployeeFlightDepartureTime.Value = DateTime.Now;
            dtpEmployeeFlightArrivalTime.Value = DateTime.Now;
            rdbOnTime.Checked = false;
            rdbDelayed.Checked = false;
            rdbCancelled.Checked = false;
        }


        // Method to display flight information in the DataGridView
        public void ShowFlightInfo()
        {
            txtEmployeeFlightId.Text = "Auto Generated";

            string query = "SELECT * FROM Flight;";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            dgvEmployeeFlight.DataSource = result.Data;
            dgvEmployeeFlight.Refresh();
            dgvEmployeeFlight.ClearSelection();
        }


        // Form Load Event
        private void EmployeeFlightForm_Load(object sender, EventArgs e)
        {
            ShowFlightInfo();
        }


        // DataGridView DataBindingComplete Event to clear selection
        private void dgvEmployeeFlight_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvEmployeeFlight.ClearSelection();
        }


        // DataGridView cell double click event
        private void dgvEmployeeFlight_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    dgvEmployeeFlight.ClearSelection();
                    return;
                }

                int FlightId = Convert.ToInt32(dgvEmployeeFlight.Rows[e.RowIndex].Cells["flightId"].Value);

                string query = "SELECT * FROM Flight WHERE flightId = '" + FlightId + "'";

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                txtEmployeeFlightId.Text = Convert.ToString(result.Data.Rows[0]["flightId"]);
                txtEmployeeFlightNo.Text = Convert.ToString(result.Data.Rows[0]["flightNo"]);
                txtEmployeeFlightOrigin.Text = Convert.ToString(result.Data.Rows[0]["origin"]);
                txtEmployeeFlightDestination.Text = Convert.ToString(result.Data.Rows[0]["destination"]);
                string status = Convert.ToString(result.Data.Rows[0]["flightStatus"]);
                dtpEmployeeFlightDepartureTime.Value = Convert.ToDateTime(result.Data.Rows[0]["departureTime"]);
                dtpEmployeeFlightArrivalTime.Value = Convert.ToDateTime(result.Data.Rows[0]["arrivalTime"]);

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


        // Search Button Click Event
        private void btnFlightSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtFlightSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Error: Enter Flight Number/ Flight Id/ Flight origin/ Flight destination/ Flight status.");
                txtFlightSearch.Text = "";
                return;
            }

            string query = "SELECT * FROM Flight WHERE flightNo = '" + searchText + "' OR CAST(flightId AS VARCHAR) = '" + searchText + "' OR origin = '" + searchText + "' OR destination = '" + searchText + "' OR flightStatus = '" + searchText + "';";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message); txtFlightSearch.Text = "";
                return;
            }

            dgvEmployeeFlight.DataSource = result.Data;
            dgvEmployeeFlight.Refresh();
            dgvEmployeeFlight.ClearSelection();

            txtFlightSearch.Text = "";
        }


        // Refresh Button Click Event
        private void btnFlightRefresh_Click(object sender, EventArgs e)
        {
            txtFlightSearch.Text = "";
            clearFlightSelection();
            ShowFlightInfo();
        }


        // Update Button Click Event
        private void btnEmployeeFlightUpdate_Click(object sender, EventArgs e)
        {
            int FlightId = Convert.ToInt32(txtEmployeeFlightId.Text);
            string FlightNo = txtEmployeeFlightNo.Text;
            string FlightStatus = "";
            DateTime FlightDepartureTime = dtpEmployeeFlightDepartureTime.Value;
            DateTime FlightArrivalTime = dtpEmployeeFlightArrivalTime.Value;

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


            // Validating that departure time is unique
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
                string query = "UPDATE Flight SET FlightNo = '" + FlightNo + "', DepartureTime = '" + FlightDepartureTime + "', ArrivalTime = '" + FlightArrivalTime + "', FlightStatus = '" + FlightStatus + "' WHERE FlightID = '" + FlightId + "';";

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                MessageBox.Show("Message: Flight Updated Successfully.");

                clearFlightSelection();
                ShowFlightInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);

            }
        }
    }
}
