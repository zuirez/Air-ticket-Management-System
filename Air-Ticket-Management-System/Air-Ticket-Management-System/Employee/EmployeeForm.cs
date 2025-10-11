using Air_Ticket_Management_System.Passenger;
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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }


        // Method to load flight data into the panel
        public void LoadEvent()
        {
            this.pnlEmployeeShowInfo.Controls.Clear();
            EmployeeFlightForm flight = new EmployeeFlightForm();
            flight.TopLevel = false;
            flight.FormBorderStyle = FormBorderStyle.None;
            flight.Dock = DockStyle.Fill;
            this.pnlEmployeeShowInfo.Controls.Add(flight);
            flight.Show();
        }


        // Form Load Event
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();

            LoadEvent();
        }


        // Form Closed Event
        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }


        // Flight Button Click Event
        private void btnEmployeeFlight_Click(object sender, EventArgs e)
        {
            this.pnlEmployeeShowInfo.Controls.Clear();
            EmployeeFlightForm flight = new EmployeeFlightForm();
            flight.TopLevel = false;
            flight.FormBorderStyle = FormBorderStyle.None;
            flight.Dock = DockStyle.Fill;
            this.pnlEmployeeShowInfo.Controls.Add(flight);
            flight.Show();
        }


        // Booking Button Click Event
        private void btnEmployeeBooking_Click(object sender, EventArgs e)
        {
            this.pnlEmployeeShowInfo.Controls.Clear();
            AdminBookingForm booking = new AdminBookingForm();
            booking.TopLevel = false;
            booking.FormBorderStyle = FormBorderStyle.None;
            booking.Dock = DockStyle.Fill;
            this.pnlEmployeeShowInfo.Controls.Add(booking);
            booking.Show();
        }


        // Payment Button Click Event
        private void btnEmployeePayment_Click(object sender, EventArgs e)
        {
            this.pnlEmployeeShowInfo.Controls.Clear();
            AdminPayment payment = new AdminPayment();
            payment.TopLevel = false;
            payment.FormBorderStyle = FormBorderStyle.None;
            payment.Dock = DockStyle.Fill;
            this.pnlEmployeeShowInfo.Controls.Add(payment);
            payment.Show();
        }


        // Refund Button Click Event
        private void btnEmployeeRefund_Click(object sender, EventArgs e)
        {
            this.pnlEmployeeShowInfo.Controls.Clear();
            AdminRefund refund = new AdminRefund();
            refund.TopLevel = false;
            refund.FormBorderStyle = FormBorderStyle.None;
            refund.Dock = DockStyle.Fill;
            this.pnlEmployeeShowInfo.Controls.Add(refund);
            refund.Show();
        }


        // Sign Out Button Click Event
        private void btnEmployeeSignOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do You Want to Sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
