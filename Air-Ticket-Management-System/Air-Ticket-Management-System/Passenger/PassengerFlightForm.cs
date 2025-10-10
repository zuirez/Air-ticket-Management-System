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
    public partial class PassengerFlightForm : Form
    {
        public PassengerFlightForm()
        {
            InitializeComponent();
        }


        // Method to clear all fields after adding or updating a flight
        public void clearFlightSelection()
        {
            txtPassengerFlightNo.Text = "";
            txtPassengerFlightOrigin.Text = "";
            txtPassengerFlightDestination.Text = "";
            dtpPassengerFlightDepartureTime.Value = DateTime.Now;
            dtpPassengerFlightArrivalTime.Value = DateTime.Now;
            rdbOnTime.Checked = false;
            rdbDelayed.Checked = false;
            rdbCancelled.Checked = false;
        }


        // Method to display flight information in the DataGridView
        public void ShowFlightInfo()
        {
            txtPassengerFlightId.Text = "Auto Generated";

            string query = "SELECT * FROM Flight;";

            var result = DbHelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show("Error : " + result.Message);
                return;
            }

            dgvPassengerFlight.DataSource = result.Data;
            dgvPassengerFlight.Refresh();
            dgvPassengerFlight.ClearSelection();
        }


        // DataGridView DataBindingComplete Event to clear selection
        private void dgvPassengerFlight_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPassengerFlight.ClearSelection();
        }


        // Form Load Event
        private void PassengerFlightForm_Load(object sender, EventArgs e)
        {
            ShowFlightInfo();
        }


        // Flight Search Button Click Event
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

            dgvPassengerFlight.DataSource = result.Data;
            dgvPassengerFlight.Refresh();
            dgvPassengerFlight.ClearSelection();

            txtFlightSearch.Text = "";
        }


        // Flight Refresh Button Click Event
        private void btnFlightRefresh_Click(object sender, EventArgs e)
        {
            txtFlightSearch.Text = "";
            clearFlightSelection();
            ShowFlightInfo();
        }


        // DataGridView Cell Double Click Event
        private void dgvAPassengerFlight_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    dgvPassengerFlight.ClearSelection();
                    return;
                }

                int FlightId = Convert.ToInt32(dgvPassengerFlight.Rows[e.RowIndex].Cells["flightId"].Value);

                string query = "SELECT * FROM Flight WHERE flightId = '" + FlightId + "'";

                var result = DbHelper.GetQueryData(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                txtPassengerFlightId.Text = Convert.ToString(result.Data.Rows[0]["flightId"]);
                txtPassengerFlightNo.Text = Convert.ToString(result.Data.Rows[0]["flightNo"]);
                txtPassengerFlightOrigin.Text = Convert.ToString(result.Data.Rows[0]["origin"]);
                txtPassengerFlightDestination.Text = Convert.ToString(result.Data.Rows[0]["destination"]);
                string status = Convert.ToString(result.Data.Rows[0]["flightStatus"]);
                dtpPassengerFlightDepartureTime.Value = Convert.ToDateTime(result.Data.Rows[0]["departureTime"]);
                dtpPassengerFlightArrivalTime.Value = Convert.ToDateTime(result.Data.Rows[0]["arrivalTime"]);

                if (status == "On Time")
                {
                    rdbOnTime.Checked = true;
                    rdbOnTime.Enabled = true;
                    rdbDelayed.Enabled = false;
                    rdbCancelled.Enabled = false;
                }
                else if (status == "Delayed")
                {
                    rdbDelayed.Checked = true;
                    rdbDelayed.Enabled = true;
                    rdbOnTime.Enabled = false;
                    rdbCancelled.Enabled = false;
                }
                else if (status == "Cancelled")
                {
                    rdbCancelled.Checked = true;
                    rdbCancelled.Enabled = true;
                    rdbOnTime.Enabled = false;
                    rdbDelayed.Enabled = false;
                }

                dtpPassengerFlightArrivalTime.Enabled = false;
                dtpPassengerFlightDepartureTime.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }
        }
    }
}
