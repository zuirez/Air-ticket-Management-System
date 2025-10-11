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
                    txtAdminReportBookingStatsTotalBooking.Text = "0";
                }

                if (getBookingDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportTotalBookings.Text = Convert.ToString(getBookingDataResult.Data.Rows[0]["TotalBookings"]);
                    txtAdminReportBookingStatsTotalBooking.Text = Convert.ToString(getBookingDataResult.Data.Rows[0]["TotalBookings"]);
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


            // Total Confirmed Bookings
            try
            {
                string getConfirmedBookingData = "SELECT COUNT(*) AS ConfirmedBookings FROM Book WHERE bookingStatus = 'Paid'";
                var getConfirmedBookingDataResult = DbHelper.GetQueryData(getConfirmedBookingData);
                if (getConfirmedBookingDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getConfirmedBookingDataResult.Message);
                    return;
                }
                if (getConfirmedBookingDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportBookingStatsConfirmedBooking.Text = "0";
                }
                if (getConfirmedBookingDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportBookingStatsConfirmedBooking.Text = Convert.ToString(getConfirmedBookingDataResult.Data.Rows[0]["ConfirmedBookings"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total Cancelled Bookings
            try
            {
                string getCancelledBookingData = "SELECT COUNT(*) AS CancelledBookings FROM Book WHERE bookingStatus = 'Cancelled'";
                var getCancelledBookingDataResult = DbHelper.GetQueryData(getCancelledBookingData);
                if (getCancelledBookingDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getCancelledBookingDataResult.Message);
                    return;
                }
                if (getCancelledBookingDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportBookingStatsCancelledBooking.Text = "0";
                }
                if (getCancelledBookingDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportBookingStatsCancelledBooking.Text = Convert.ToString(getCancelledBookingDataResult.Data.Rows[0]["CancelledBookings"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total Pending Bookings
            try
            {
                string getPendingBookingData = "SELECT COUNT(*) AS PendingBookings FROM Book WHERE bookingStatus = 'Pending'";
                var getPendingBookingDataResult = DbHelper.GetQueryData(getPendingBookingData);
                if (getPendingBookingDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getPendingBookingDataResult.Message);
                    return;
                }
                if (getPendingBookingDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportBookingStatsPendingBooking.Text = "0";
                }
                if (getPendingBookingDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportBookingStatsPendingBooking.Text = Convert.ToString(getPendingBookingDataResult.Data.Rows[0]["PendingBookings"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total number of payments
            try
            {
                string getPaymentData = "SELECT COUNT(*) AS TotalPayments FROM Payment";
                var getPaymentDataResult = DbHelper.GetQueryData(getPaymentData);
                if (getPaymentDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getPaymentDataResult.Message);
                    return;
                }
                if (getPaymentDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportPaymentStatsNoofPayments.Text = "0";
                }
                if (getPaymentDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportPaymentStatsNoofPayments.Text = Convert.ToString(getPaymentDataResult.Data.Rows[0]["TotalPayments"]);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total amount of payments
            try
            {
                string getTotalPaymentAmountData = "SELECT SUM(amount) AS TotalPaymentAmount FROM Payment";
                var getTotalPaymentAmountDataResult = DbHelper.GetQueryData(getTotalPaymentAmountData);
                if (getTotalPaymentAmountDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getTotalPaymentAmountDataResult.Message);
                    return;
                }
                if (getTotalPaymentAmountDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportPaymentStatsPaymentAmount.Text = "0";
                }
                if (getTotalPaymentAmountDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportPaymentStatsPaymentAmount.Text = Convert.ToString(getTotalPaymentAmountDataResult.Data.Rows[0]["TotalPaymentAmount"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Confirmed payments
            try
            {
                string getConfirmedPaymentData = "SELECT COUNT(*) AS ConfirmedPayments FROM Payment WHERE paymentStatus = 'Paid'";
                var getConfirmedPaymentDataResult = DbHelper.GetQueryData(getConfirmedPaymentData);
                if (getConfirmedPaymentDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getConfirmedPaymentDataResult.Message);
                    return;
                }
                if (getConfirmedPaymentDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportPaymentStatsConfirmedPayment.Text = "0";
                }
                if (getConfirmedPaymentDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportPaymentStatsConfirmedPayment.Text = Convert.ToString(getConfirmedPaymentDataResult.Data.Rows[0]["ConfirmedPayments"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Pending payments
            try
            {
                string getPendingPaymentData = "SELECT COUNT(*) AS PendingPayments FROM Payment WHERE paymentStatus = 'Pending'";
                var getPendingPaymentDataResult = DbHelper.GetQueryData(getPendingPaymentData);
                if (getPendingPaymentDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getPendingPaymentDataResult.Message);
                    return;
                }
                if (getPendingPaymentDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportPaymentStatsPendingPayment.Text = "0";
                }
                if (getPendingPaymentDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportPaymentStatsPendingPayment.Text = Convert.ToString(getPendingPaymentDataResult.Data.Rows[0]["PendingPayments"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Cancelled payments
            try
            {
                string getCancelledPaymentData = "SELECT COUNT(*) AS CancelledPayments FROM Payment WHERE paymentStatus = 'Cancelled'";
                var getCancelledPaymentDataResult = DbHelper.GetQueryData(getCancelledPaymentData);
                if (getCancelledPaymentDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getCancelledPaymentDataResult.Message);
                    return;
                }
                if (getCancelledPaymentDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportPaymentStatsCancelledPayment.Text = "0";
                }
                if (getCancelledPaymentDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportPaymentStatsCancelledPayment.Text = Convert.ToString(getCancelledPaymentDataResult.Data.Rows[0]["CancelledPayments"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total number of refunds
            try
            {
                string getRefundData = "SELECT COUNT(*) AS TotalRefunds FROM Refund";
                var getRefundDataResult = DbHelper.GetQueryData(getRefundData);
                if (getRefundDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getRefundDataResult.Message);
                    return;
                }
                if (getRefundDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportRefundStatsNoofRefunds.Text = "0";
                }
                if (getRefundDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportRefundStatsNoofRefunds.Text = Convert.ToString(getRefundDataResult.Data.Rows[0]["TotalRefunds"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total amount of refunds
            try
            {
                string getTotalRefundAmountData = "SELECT SUM(amount) AS TotalRefundAmount FROM Refund WHERE refundStatus = 'Pending'";
                var getTotalRefundAmountDataResult = DbHelper.GetQueryData(getTotalRefundAmountData);
                if (getTotalRefundAmountDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getTotalRefundAmountDataResult.Message);
                    return;
                }
                if (getTotalRefundAmountDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportRefundStatsRefundAmount.Text = "0";
                    txtAdminReportPendingRefunds.Text = "0";
                }
                if (getTotalRefundAmountDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportRefundStatsRefundAmount.Text = Convert.ToString(getTotalRefundAmountDataResult.Data.Rows[0]["TotalRefundAmount"]);
                    txtAdminReportPendingRefunds.Text = Convert.ToString(getTotalRefundAmountDataResult.Data.Rows[0]["TotalRefundAmount"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Confirmed refunds
            try
            {
                string getConfirmedRefundData = "SELECT COUNT(*) AS ConfirmedRefunds FROM Refund WHERE refundStatus = 'Paid'";
                var getConfirmedRefundDataResult = DbHelper.GetQueryData(getConfirmedRefundData);
                if (getConfirmedRefundDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getConfirmedRefundDataResult.Message);
                    return;
                }
                if (getConfirmedRefundDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportRefundStatsConfirmedRefund.Text = "0";
                }
                if (getConfirmedRefundDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportRefundStatsConfirmedRefund.Text = Convert.ToString(getConfirmedRefundDataResult.Data.Rows[0]["ConfirmedRefunds"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Pending refunds
            try
            {
                string getPendingRefundData = "SELECT COUNT(*) AS PendingRefunds FROM Refund WHERE refundStatus = 'Pending'";
                var getPendingRefundDataResult = DbHelper.GetQueryData(getPendingRefundData);
                if (getPendingRefundDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getPendingRefundDataResult.Message);
                    return;
                }
                if (getPendingRefundDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportRefundStatsPendingRefund.Text = "0";
                }
                if (getPendingRefundDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportRefundStatsPendingRefund.Text = Convert.ToString(getPendingRefundDataResult.Data.Rows[0]["PendingRefunds"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Cancelled refunds
            try
            {
                string getCancelledRefundData = "SELECT COUNT(*) AS CancelledRefunds FROM Refund WHERE refundStatus = 'Cancelled'";
                var getCancelledRefundDataResult = DbHelper.GetQueryData(getCancelledRefundData);
                if (getCancelledRefundDataResult.HasError)
                {
                    MessageBox.Show("Error : " + getCancelledRefundDataResult.Message);
                    return;
                }
                if (getCancelledRefundDataResult.Data.Rows.Count == 0)
                {
                    txtAdminReportRefundStatsCancelledRefund.Text = "0";
                }
                if (getCancelledRefundDataResult.Data.Rows.Count > 0)
                {
                    txtAdminReportRefundStatsCancelledRefund.Text = Convert.ToString(getCancelledRefundDataResult.Data.Rows[0]["CancelledRefunds"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }


            // Total revenue
            try
            {
                decimal totalPaymentAmount = 0;
                decimal totalRefundAmount = 0;
                if (txtAdminReportPaymentStatsPaymentAmount.Text != "")
                {
                    totalPaymentAmount = Convert.ToDecimal(txtAdminReportPaymentStatsPaymentAmount.Text);
                }
                if (txtAdminReportRefundStatsRefundAmount.Text != "")
                {
                    totalRefundAmount = Convert.ToDecimal(txtAdminReportRefundStatsRefundAmount.Text);
                }
                decimal totalRevenue = totalPaymentAmount - totalRefundAmount;
                txtAdminReportTotalRevenue.Text = Convert.ToString(totalRevenue);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }
        }
    }
}
