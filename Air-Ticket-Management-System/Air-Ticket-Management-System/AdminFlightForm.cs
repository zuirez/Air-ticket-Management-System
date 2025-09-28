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


        // Method to clear all fields after adding or updating a flight
        public void clearFlightSelection()
        {
            txtAdminFlightId.Text = "Auto Generated";
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
        public void ShowFlightInfo()
        {
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
            txtAdminFlightId.Text = "Auto Generated";
            ShowFlightInfo();
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


            // Inserting flight data into the database
            try
            {
                string query = "INSERT INTO Flight VALUES ('" + FlightNo + "', '" + FlightOrigin + "', '" + FlightDestination + "', '" + FlightDepartureTime + "', '" + FlightArrivalTime + "', '" + FlightStatus + "');";

                var result = DbHelper.ExecuteNonResultQuery(query);

                if (result.HasError)
                {
                    MessageBox.Show("Error : " + result.Message);
                    return;
                }

                MessageBox.Show("Message: Flight Added Successfully.");

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
