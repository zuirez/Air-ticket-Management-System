using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Ticket_Management_System
{
    public partial class AdminFlightSeats : Form
    {
        private string FlightNo;
        private List<string> seats = new List<string>();
        private TextBox txtAdminBookingBookedSeats;

        public List<string> Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        public AdminFlightSeats(string flightNo, TextBox bookedSeats)
        {
            InitializeComponent();

            this.FlightNo = flightNo;
            this.txtAdminBookingBookedSeats = bookedSeats;


            // Initialize seats list from the provided TextBox
            if (!string.IsNullOrWhiteSpace(bookedSeats.Text))
            {
                var alreadyBooked = bookedSeats.Text.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim());
                seats.AddRange(alreadyBooked);
            }
        }


        // Load seat data from database and update button colors
        public void seatDataLoading()
        {
            try
            {
                string getFlightIdQuery = "SELECT flightId FROM Flight WHERE flightNo = '" + this.FlightNo + "'";

                var getFlightIdResult = DbHelper.GetQueryData(getFlightIdQuery);

                if (getFlightIdResult.HasError)
                {
                    MessageBox.Show("Error : " + getFlightIdResult.Message);
                    return;
                }

                if (getFlightIdResult.Data.Rows.Count == 0)
                {
                    MessageBox.Show("Error : Flight not found");
                    return;
                }

                // get flightId from result
                int flightId = Convert.ToInt32(getFlightIdResult.Data.Rows[0]["flightId"]);

                string flightSeatsInfoQuery = "SELECT * FROM FlightSeats WHERE flightId = '" + flightId + "'";

                var flightSeatsInfoResult = DbHelper.GetQueryData(flightSeatsInfoQuery);

                if (flightSeatsInfoResult.HasError)
                {
                    MessageBox.Show("Error : " + flightSeatsInfoResult.Message);
                    return;
                }

                DataTable flightSeatsInfo = flightSeatsInfoResult.Data;

                // loop through all buttons in pnlSeats
                foreach (Button seatButton in this.pnlFlightSeats.Controls.OfType<Button>())
                {
                    // inside the foreach loop, replace existing logic with:
                    string seatNo = seatButton.Text;

                    // find DB row as before...
                    DataRow[] rows = flightSeatsInfo.Select("seatNo = '" + seatNo + "'");
                    if (rows.Length > 0)
                    {
                        string status = rows[0]["flightSeatStatus"].ToString();

                        // If the seat is selected locally, show selected color regardless of DB status
                        if (seats.Contains(seatNo))
                        {
                            // Always show seats the user has already selected
                            seatButton.BackColor = Color.LimeGreen;
                        }
                        else if (status == "Available")
                        {
                            seatButton.BackColor = Color.DimGray;
                        }
                        else if (status == "Booked")
                        {
                            seatButton.BackColor = Color.IndianRed;

                            // Only remove if booked by someone else
                            if (seats.Contains(seatNo)) seats.Remove(seatNo);
                        }
                    }
                    else
                    {
                        // No DB row found
                        if (seats.Contains(seatNo))
                            seatButton.BackColor = Color.LimeGreen;
                        else
                            seatButton.BackColor = SystemColors.Control;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception);
            }
        }


        // Handle seat button click event
        public void seatClickEvent(Button seatBtn)
        {
            string seatNo = seatBtn.Text;

            var result = MessageBox.Show("Do you want to select/deselect this seat?", "Select Seat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                string checkSeatStatusQuery = "SELECT flightSeatStatus FROM FlightSeats WHERE seatNo = '" + seatNo + "' AND flightId = (SELECT flightId FROM Flight WHERE flightNo = '" + this.FlightNo + "')";
                var checkSeatStatusResult = DbHelper.GetQueryData(checkSeatStatusQuery);

                if (checkSeatStatusResult.HasError)
                {
                    MessageBox.Show("Error : " + checkSeatStatusResult.Message);
                    return;
                }

                if (checkSeatStatusResult.Data.Rows.Count == 0)
                {
                    MessageBox.Show("Error : Seat not found");
                    return;
                }

                string seatStatus = checkSeatStatusResult.Data.Rows[0]["flightSeatStatus"].ToString();

                if (seatStatus == "Booked")
                {
                    MessageBox.Show("Error : Seat already booked");
                    return;
                }

                if (seats.Contains(seatNo))
                {
                    seats.Remove(seatNo);
                    seatBtn.BackColor = Color.DimGray;
                }
                else
                {
                    seats.Add(seatNo);
                    seatBtn.BackColor = Color.LimeGreen;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error : " + exception.Message);
            }
        }

        private void AdminFlightSeats_Load(object sender, EventArgs e)
        {
            seatDataLoading();
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnA1);
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnA2);
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnA3);
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnE4);
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnA5);
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnA6);
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnB1);
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnB2);
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnB3);
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnB4);
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnB5);
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnB6);
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnC1);
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnC2);
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnC3);
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnC4);
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnC5);
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnC6);
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnD1);
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnD2);
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnD3);
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnD4);
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnD5);
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnD6);
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnE1);
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnE2);
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnE3);
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnA4);
        }

        private void btnE5_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnE5);
        }

        private void btnE6_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnE6);
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnF1);
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnF2);
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnF3);
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnF4);
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnF5);
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnF6);
        }

        private void btnG1_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnG1);
        }

        private void btnG2_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnG2);
        }

        private void btnG3_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnG3);
        }

        private void btnG4_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnG4);
        }

        private void btnG5_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnG5);
        }

        private void btnG6_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnG6);
        }

        private void btnH1_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnH1);
        }

        private void btnH2_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnH2);
        }

        private void btnH3_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnH3);
        }

        private void btnH4_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnH4);
        }

        private void btnH5_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnH5);
        }

        private void btnH6_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnH6);
        }

        private void btnI1_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnI1);
        }

        private void btnI2_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnI2);
        }

        private void btnI3_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnI3);
        }

        private void btnI4_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnI4);
        }

        private void btnI5_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnI5);
        }

        private void btnI6_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnI6);
        }

        private void btnJ1_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnJ1);
        }

        private void btnJ2_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnJ2);
        }

        private void btnJ3_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnJ3);
        }

        private void btnJ4_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnJ4);
        }

        private void btnJ5_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnJ5);
        }

        private void btnJ6_Click(object sender, EventArgs e)
        {
            seatClickEvent(btnJ6);
        }


        // Cancel button click event
        private void btnFlightSeatsCancle_Click(object sender, EventArgs e)
        {
            txtAdminBookingBookedSeats.Text = string.Join(", ", seats);
            this.Close();
        }

        private void AdminFlightSeats_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtAdminBookingBookedSeats.Text = string.Join(", ", seats);
        }
    }
}