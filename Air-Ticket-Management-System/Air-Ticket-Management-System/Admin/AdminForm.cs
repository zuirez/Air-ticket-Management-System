using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Air_Ticket_Management_System
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }


        // Method to load flight data into the panel
        public void LoadEvent()
        {
            this.pnlAdminShowInfo.Controls.Clear();
            AdminFlightForm flight = new AdminFlightForm();
            flight.TopLevel = false;
            flight.FormBorderStyle = FormBorderStyle.None;
            flight.Dock = DockStyle.Fill;
            this.pnlAdminShowInfo.Controls.Add(flight);
            flight.Show();
        }


        // Form Load Event
        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();

            LoadEvent();
        }


        // Form Closed Event
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }


        // Flight Button Click Event
        private void btnAdminFlight_Click(object sender, EventArgs e)
        {
            LoadEvent();
        }


        // Booking Button Click Event
        private void btnAdminBooking_Click(object sender, EventArgs e)
        {
            this.pnlAdminShowInfo.Controls.Clear();
            AdminBookingForm booking = new AdminBookingForm();
            booking.TopLevel = false;
            booking.FormBorderStyle = FormBorderStyle.None;
            booking.Dock = DockStyle.Fill;
            this.pnlAdminShowInfo.Controls.Add(booking);
            booking.Show();
        }


        // Admin Button Click Event
        private void btnAdminAdmin_Click(object sender, EventArgs e)
        {
            //will be added later
        }


        // Employee Button Click Event
        private void btnAdminEmployee_Click(object sender, EventArgs e)
        {
            //will be added later
        }


        // Passenger Button Click Event
        private void btnAdminPassenger_Click(object sender, EventArgs e)
        {
            //will be added later
        }


        // Payment Button Click Event
        private void btnAdminPayment_Click(object sender, EventArgs e)
        {
            //will be added later
        }


        // Report Button Click Event
        private void btnAdminReport_Click(object sender, EventArgs e)
        {
            //will be added later
        }



        // Sign Out Button Click Event
        private void btnAdminSignOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do You Want to Sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
