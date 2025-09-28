namespace Air_Ticket_Management_System
{
    partial class AdminFlightForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAdminFlightManage = new System.Windows.Forms.Label();
            this.lblAdminFlightInfo = new System.Windows.Forms.Label();
            this.pnlAdminFlightManage = new System.Windows.Forms.Panel();
            this.txtAdminFlightStatus = new System.Windows.Forms.TextBox();
            this.lblAdminFlightStatus = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblAdminFlightDestination = new System.Windows.Forms.Label();
            this.txtAdminFlightOrigin = new System.Windows.Forms.TextBox();
            this.lblAdminFlightOrigin = new System.Windows.Forms.Label();
            this.txtAdminFlightNo = new System.Windows.Forms.TextBox();
            this.lblAdminFlightNo = new System.Windows.Forms.Label();
            this.txtAdminFlightId = new System.Windows.Forms.TextBox();
            this.lblAdminFlightId = new System.Windows.Forms.Label();
            this.dtpAdminFlightDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.lblAdminFlightArrivalTime = new System.Windows.Forms.Label();
            this.lblAdminFlightDepartureTIme = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvAdminFlight = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlAdminFlightManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.Controls.Add(this.lblAdminFlightManage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminFlightInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlAdminFlightManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvAdminFlight, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 576);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAdminFlightManage
            // 
            this.lblAdminFlightManage.AutoSize = true;
            this.lblAdminFlightManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminFlightManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminFlightManage.Location = new System.Drawing.Point(599, 1);
            this.lblAdminFlightManage.Name = "lblAdminFlightManage";
            this.lblAdminFlightManage.Size = new System.Drawing.Size(394, 50);
            this.lblAdminFlightManage.TabIndex = 1;
            this.lblAdminFlightManage.Text = "Manage Flights";
            this.lblAdminFlightManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminFlightInfo
            // 
            this.lblAdminFlightInfo.AutoSize = true;
            this.lblAdminFlightInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminFlightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminFlightInfo.Location = new System.Drawing.Point(4, 1);
            this.lblAdminFlightInfo.Name = "lblAdminFlightInfo";
            this.lblAdminFlightInfo.Size = new System.Drawing.Size(588, 50);
            this.lblAdminFlightInfo.TabIndex = 0;
            this.lblAdminFlightInfo.Text = "Flight Info";
            this.lblAdminFlightInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAdminFlightManage
            // 
            this.pnlAdminFlightManage.Controls.Add(this.dateTimePicker1);
            this.pnlAdminFlightManage.Controls.Add(this.lblAdminFlightDepartureTIme);
            this.pnlAdminFlightManage.Controls.Add(this.lblAdminFlightArrivalTime);
            this.pnlAdminFlightManage.Controls.Add(this.dtpAdminFlightDepartureTime);
            this.pnlAdminFlightManage.Controls.Add(this.txtAdminFlightStatus);
            this.pnlAdminFlightManage.Controls.Add(this.lblAdminFlightStatus);
            this.pnlAdminFlightManage.Controls.Add(this.textBox3);
            this.pnlAdminFlightManage.Controls.Add(this.lblAdminFlightDestination);
            this.pnlAdminFlightManage.Controls.Add(this.txtAdminFlightOrigin);
            this.pnlAdminFlightManage.Controls.Add(this.lblAdminFlightOrigin);
            this.pnlAdminFlightManage.Controls.Add(this.txtAdminFlightNo);
            this.pnlAdminFlightManage.Controls.Add(this.lblAdminFlightNo);
            this.pnlAdminFlightManage.Controls.Add(this.txtAdminFlightId);
            this.pnlAdminFlightManage.Controls.Add(this.lblAdminFlightId);
            this.pnlAdminFlightManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminFlightManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdminFlightManage.Location = new System.Drawing.Point(599, 55);
            this.pnlAdminFlightManage.Name = "pnlAdminFlightManage";
            this.pnlAdminFlightManage.Size = new System.Drawing.Size(394, 517);
            this.pnlAdminFlightManage.TabIndex = 3;
            // 
            // txtAdminFlightStatus
            // 
            this.txtAdminFlightStatus.Location = new System.Drawing.Point(150, 171);
            this.txtAdminFlightStatus.Name = "txtAdminFlightStatus";
            this.txtAdminFlightStatus.Size = new System.Drawing.Size(224, 26);
            this.txtAdminFlightStatus.TabIndex = 11;
            // 
            // lblAdminFlightStatus
            // 
            this.lblAdminFlightStatus.AutoSize = true;
            this.lblAdminFlightStatus.Location = new System.Drawing.Point(37, 174);
            this.lblAdminFlightStatus.Name = "lblAdminFlightStatus";
            this.lblAdminFlightStatus.Size = new System.Drawing.Size(111, 20);
            this.lblAdminFlightStatus.TabIndex = 10;
            this.lblAdminFlightStatus.Text = "Flight Status : ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 26);
            this.textBox3.TabIndex = 7;
            // 
            // lblAdminFlightDestination
            // 
            this.lblAdminFlightDestination.AutoSize = true;
            this.lblAdminFlightDestination.Location = new System.Drawing.Point(45, 137);
            this.lblAdminFlightDestination.Name = "lblAdminFlightDestination";
            this.lblAdminFlightDestination.Size = new System.Drawing.Size(102, 20);
            this.lblAdminFlightDestination.TabIndex = 6;
            this.lblAdminFlightDestination.Text = "Destination : ";
            // 
            // txtAdminFlightOrigin
            // 
            this.txtAdminFlightOrigin.Location = new System.Drawing.Point(150, 97);
            this.txtAdminFlightOrigin.Name = "txtAdminFlightOrigin";
            this.txtAdminFlightOrigin.Size = new System.Drawing.Size(224, 26);
            this.txtAdminFlightOrigin.TabIndex = 5;
            // 
            // lblAdminFlightOrigin
            // 
            this.lblAdminFlightOrigin.AutoSize = true;
            this.lblAdminFlightOrigin.Location = new System.Drawing.Point(85, 100);
            this.lblAdminFlightOrigin.Name = "lblAdminFlightOrigin";
            this.lblAdminFlightOrigin.Size = new System.Drawing.Size(62, 20);
            this.lblAdminFlightOrigin.TabIndex = 4;
            this.lblAdminFlightOrigin.Text = "Origin : ";
            // 
            // txtAdminFlightNo
            // 
            this.txtAdminFlightNo.Location = new System.Drawing.Point(150, 60);
            this.txtAdminFlightNo.Name = "txtAdminFlightNo";
            this.txtAdminFlightNo.Size = new System.Drawing.Size(224, 26);
            this.txtAdminFlightNo.TabIndex = 3;
            // 
            // lblAdminFlightNo
            // 
            this.lblAdminFlightNo.AutoSize = true;
            this.lblAdminFlightNo.Location = new System.Drawing.Point(64, 63);
            this.lblAdminFlightNo.Name = "lblAdminFlightNo";
            this.lblAdminFlightNo.Size = new System.Drawing.Size(84, 20);
            this.lblAdminFlightNo.TabIndex = 2;
            this.lblAdminFlightNo.Text = "Flight No : ";
            // 
            // txtAdminFlightId
            // 
            this.txtAdminFlightId.Location = new System.Drawing.Point(150, 23);
            this.txtAdminFlightId.Name = "txtAdminFlightId";
            this.txtAdminFlightId.Size = new System.Drawing.Size(224, 26);
            this.txtAdminFlightId.TabIndex = 1;
            // 
            // lblAdminFlightId
            // 
            this.lblAdminFlightId.AutoSize = true;
            this.lblAdminFlightId.Location = new System.Drawing.Point(67, 26);
            this.lblAdminFlightId.Name = "lblAdminFlightId";
            this.lblAdminFlightId.Size = new System.Drawing.Size(81, 20);
            this.lblAdminFlightId.TabIndex = 0;
            this.lblAdminFlightId.Text = "Flight ID : ";
            // 
            // dtpAdminFlightDepartureTime
            // 
            this.dtpAdminFlightDepartureTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpAdminFlightDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdminFlightDepartureTime.Location = new System.Drawing.Point(150, 210);
            this.dtpAdminFlightDepartureTime.Name = "dtpAdminFlightDepartureTime";
            this.dtpAdminFlightDepartureTime.Size = new System.Drawing.Size(224, 26);
            this.dtpAdminFlightDepartureTime.TabIndex = 12;
            // 
            // lblAdminFlightArrivalTime
            // 
            this.lblAdminFlightArrivalTime.AutoSize = true;
            this.lblAdminFlightArrivalTime.Location = new System.Drawing.Point(50, 252);
            this.lblAdminFlightArrivalTime.Name = "lblAdminFlightArrivalTime";
            this.lblAdminFlightArrivalTime.Size = new System.Drawing.Size(97, 20);
            this.lblAdminFlightArrivalTime.TabIndex = 13;
            this.lblAdminFlightArrivalTime.Text = "Arival Time : ";
            // 
            // lblAdminFlightDepartureTIme
            // 
            this.lblAdminFlightDepartureTIme.AutoSize = true;
            this.lblAdminFlightDepartureTIme.Location = new System.Drawing.Point(16, 213);
            this.lblAdminFlightDepartureTIme.Name = "lblAdminFlightDepartureTIme";
            this.lblAdminFlightDepartureTIme.Size = new System.Drawing.Size(131, 20);
            this.lblAdminFlightDepartureTIme.TabIndex = 14;
            this.lblAdminFlightDepartureTIme.Text = "Departure Time : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 249);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 26);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dgvAdminFlight
            // 
            this.dgvAdminFlight.AllowUserToAddRows = false;
            this.dgvAdminFlight.AllowUserToDeleteRows = false;
            this.dgvAdminFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdminFlight.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdminFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminFlight.Location = new System.Drawing.Point(4, 55);
            this.dgvAdminFlight.Name = "dgvAdminFlight";
            this.dgvAdminFlight.ReadOnly = true;
            this.dgvAdminFlight.Size = new System.Drawing.Size(588, 517);
            this.dgvAdminFlight.TabIndex = 4;
            // 
            // AdminFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminFlightForm";
            this.Text = "AdminFlightForm";
            this.Load += new System.EventHandler(this.AdminFlightForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlAdminFlightManage.ResumeLayout(false);
            this.pnlAdminFlightManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminFlight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAdminFlightManage;
        private System.Windows.Forms.Label lblAdminFlightInfo;
        private System.Windows.Forms.Panel pnlAdminFlightManage;
        private System.Windows.Forms.TextBox txtAdminFlightId;
        private System.Windows.Forms.Label lblAdminFlightId;
        private System.Windows.Forms.TextBox txtAdminFlightStatus;
        private System.Windows.Forms.Label lblAdminFlightStatus;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblAdminFlightDestination;
        private System.Windows.Forms.TextBox txtAdminFlightOrigin;
        private System.Windows.Forms.Label lblAdminFlightOrigin;
        private System.Windows.Forms.TextBox txtAdminFlightNo;
        private System.Windows.Forms.Label lblAdminFlightNo;
        private System.Windows.Forms.Label lblAdminFlightArrivalTime;
        private System.Windows.Forms.DateTimePicker dtpAdminFlightDepartureTime;
        private System.Windows.Forms.Label lblAdminFlightDepartureTIme;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvAdminFlight;
    }
}