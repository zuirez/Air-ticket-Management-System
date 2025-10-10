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
    public partial class PassengerForm : Form
    {
        public PassengerForm()
        {
            InitializeComponent();
        }


        // Method to load flight data into the panel
        public void LoadEvent()
        {
            this.pnlPassengerShowInfo.Controls.Clear();
            PassengerFlightForm flight = new PassengerFlightForm();
            flight.TopLevel = false;
            flight.FormBorderStyle = FormBorderStyle.None;
            flight.Dock = DockStyle.Fill;
            this.pnlPassengerShowInfo.Controls.Add(flight);
            flight.Show();
        }


        // Form Load Event
        private void PassengerForm_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();

            LoadEvent();
        }


        // Form Closed Event
        private void PassengerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }


        // Flight Button Click Event
        private void btnPassengerFlight_Click(object sender, EventArgs e)
        {
            this.pnlPassengerShowInfo.Controls.Clear();
            PassengerFlightForm flight = new PassengerFlightForm();
            flight.TopLevel = false;
            flight.FormBorderStyle = FormBorderStyle.None;
            flight.Dock = DockStyle.Fill;
            this.pnlPassengerShowInfo.Controls.Add(flight);
            flight.Show();
        }


        // Booking Button Click Event
        private void btnPassengerBooking_Click(object sender, EventArgs e)
        {
            this.pnlPassengerShowInfo.Controls.Clear();
            PassengerBookingForm booking = new PassengerBookingForm();
            booking.TopLevel = false;
            booking.FormBorderStyle = FormBorderStyle.None;
            booking.Dock = DockStyle.Fill;
            this.pnlPassengerShowInfo.Controls.Add(booking);
            booking.Show();
        }


        // Payment Button Click Event
        private void btnPassengerPayment_Click(object sender, EventArgs e)
        {
            this.pnlPassengerShowInfo.Controls.Clear();
            PassengerPaymentForm payment = new PassengerPaymentForm();
            payment.TopLevel = false;
            payment.FormBorderStyle = FormBorderStyle.None;
            payment.Dock = DockStyle.Fill;
            this.pnlPassengerShowInfo.Controls.Add(payment);
            payment.Show();
        }


        // Refund Button Click Event
        private void btnPassengerRefund_Click(object sender, EventArgs e)
        {

        }


        // Sign Out Button Click Event
        private void btnPassengerSignOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do You Want to Sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
