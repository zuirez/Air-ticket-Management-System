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

        private void AdminFlightForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Flight";

            var result = DbHelper.GetQueryData(query);
            if (result.HasError)
            {
                MessageBox.Show("Error: " + result.Message);
                return;
            }

            dgvAdminFlight.DataSource = result.Data;
            dgvAdminFlight.Refresh();
            dgvAdminFlight.ClearSelection();
        }
    }
}
