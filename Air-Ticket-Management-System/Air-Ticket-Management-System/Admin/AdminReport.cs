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
    public partial class AdminReport : Form
    {
        public AdminReport()
        {
            InitializeComponent();
        }


        // Form Load Event
        private void AdminReport_Load(object sender, EventArgs e)
        {
            // Total users
            try
            {
                string getUserData = "SELECT COUNT(*) AS TotalUsers FROM userInfo";

                var getUserDataResult = DbHelper.GetQueryData(getUserData);

                if(getUserDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getUserDataResult.Message);
                    return;
                }

                if (getUserDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportTotalUsers.Text = "0";
                    txtAdminReportUserStatsTotalUsers.Text = "0";
                }

                if (getUserDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportTotalUsers.Text = Convert.ToString(getUserDataResult.Data.Rows[0]["TotalUsers"]);
                    txtAdminReportUserStatsTotalUsers.Text = Convert.ToString(getUserDataResult.Data.Rows[0]["TotalUsers"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total flights
            try
            {
                string getFlightData = "SELECT COUNT(*) AS TotalFlight FROM Flight";

                var getFlightDataResult = DbHelper.GetQueryData(getFlightData);

                if (getFlightDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getFlightDataResult.Message);
                    return;
                }

                if (getFlightDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportTotalFlights.Text = "0";
                    txtAdminReportFlightStatsTotalFlights.Text = "0";
                }

                if (getFlightDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportTotalFlights.Text = Convert.ToString(getFlightDataResult.Data.Rows[0]["TotalFlight"]);
                    txtAdminReportFlightStatsTotalFlights.Text = Convert.ToString(getFlightDataResult.Data.Rows[0]["TotalFlight"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total bookings
            try
            {
                string getBookingData = "SELECT COUNT(*) AS TotalBookings FROM Book";

                var getBookingDataResult = DbHelper.GetQueryData(getBookingData);

                if (getBookingDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getBookingDataResult.Message);
                    return;
                }

                if (getBookingDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportTotalBookings.Text = "0";
                }

                if (getBookingDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportTotalBookings.Text = Convert.ToString(getBookingDataResult.Data.Rows[0]["TotalBookings"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total On time flights
            try
            {
                string getFlightOnTimeData = "SELECT COUNT(*) AS OnTimeFlights FROM Flight WHERE flightStatus = 'On Time';";

                var getFlightOnTimeDataResult = DbHelper.GetQueryData(getFlightOnTimeData);

                if (getFlightOnTimeDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getFlightOnTimeDataResult.Message);
                    return;
                }

                if (getFlightOnTimeDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportFlightStatsOnTimeFlights.Text = "0";
                }

                if (getFlightOnTimeDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportFlightStatsOnTimeFlights.Text = Convert.ToString(getFlightOnTimeDataResult.Data.Rows[0]["OnTimeFlights"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total Delayed flights
            try
            {
                string getFlightDelayedData = "SELECT COUNT(*) AS DelayedFlights FROM Flight WHERE flightStatus = 'Delayed'";

                var getFlightDelayedDataResult = DbHelper.GetQueryData(getFlightDelayedData);

                if (getFlightDelayedDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getFlightDelayedDataResult.Message);
                    return;
                }

                if (getFlightDelayedDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportFlightStatsDelayedFlights.Text = "0";
                }

                if (getFlightDelayedDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportFlightStatsDelayedFlights.Text = Convert.ToString(getFlightDelayedDataResult.Data.Rows[0]["DelayedFlights"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total Cancelled flights
            try
            {
                string getFlightCancelledData = "SELECT COUNT(*) AS CancelledFlights FROM Flight WHERE flightStatus = 'Cancelled'";

                var getFlightCancelledDataResult = DbHelper.GetQueryData(getFlightCancelledData);

                if (getFlightCancelledDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getFlightCancelledDataResult.Message);
                    return;
                }

                if (getFlightCancelledDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportFlightStatsCancelledFlights.Text = "0";
                }

                if (getFlightCancelledDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportFlightStatsCancelledFlights.Text = Convert.ToString(getFlightCancelledDataResult.Data.Rows[0]["CancelledFlights"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total Passenger
            try
            {
                string getPassengerData = "SELECT COUNT(*) AS TotalPassenger FROM userInfo WHERE userIdType = 3";

                var getPassengerDataResult = DbHelper.GetQueryData(getPassengerData);

                if (getPassengerDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getPassengerDataResult.Message);
                    return;
                }

                if (getPassengerDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportUserStatsTotalPassenger.Text = "0";
                }

                if (getPassengerDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportUserStatsTotalPassenger.Text = Convert.ToString(getPassengerDataResult.Data.Rows[0]["TotalPassenger"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total Employee
            try
            {
                string getEmployeeData = "SELECT COUNT(*) AS TotalEmployee FROM userInfo WHERE userIdType = 2";

                var getEmployeeDataResult = DbHelper.GetQueryData(getEmployeeData);

                if (getEmployeeDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getEmployeeDataResult.Message);
                    return;
                }

                if (getEmployeeDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportUserStatsTotalEmployee.Text = "0";
                }

                if (getEmployeeDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportUserStatsTotalEmployee.Text = Convert.ToString(getEmployeeDataResult.Data.Rows[0]["TotalEmployee"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total Admin
            try
            {
                string getAdmineData = "SELECT COUNT(*) AS TotalAdmin FROM userInfo WHERE userIdType = 1";

                var getAdmineDataResult = DbHelper.GetQueryData(getAdmineData);

                if (getAdmineDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getAdmineDataResult.Message);
                    return;
                }

                if (getAdmineDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportUserStatsTotalAdmin.Text = "0";
                }

                if (getAdmineDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportUserStatsTotalAdmin.Text = Convert.ToString(getAdmineDataResult.Data.Rows[0]["TotalAdmin"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }
        }
    }
}
