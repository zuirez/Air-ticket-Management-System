namespace Air_Ticket_Management_System.Passenger
{
    partial class PassengerFlightForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPassengerFlight = new System.Windows.Forms.DataGridView();
            this.lblPassengerFlightDepartureTIme = new System.Windows.Forms.Label();
            this.lblPassengerFlightArrivalTime = new System.Windows.Forms.Label();
            this.dtpPassengerFlightDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.lblPassengerFlightStatus = new System.Windows.Forms.Label();
            this.txtPassengerFlightDestination = new System.Windows.Forms.TextBox();
            this.lblPassengerFlightDestination = new System.Windows.Forms.Label();
            this.txtPassengerFlightOrigin = new System.Windows.Forms.TextBox();
            this.lblPassengerFlightOrigin = new System.Windows.Forms.Label();
            this.txtPassengerFlightNo = new System.Windows.Forms.TextBox();
            this.lblPassengerFlightNo = new System.Windows.Forms.Label();
            this.txtPassengerFlightId = new System.Windows.Forms.TextBox();
            this.dtpPassengerFlightArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.rdbCancelled = new System.Windows.Forms.RadioButton();
            this.rdbDelayed = new System.Windows.Forms.RadioButton();
            this.rdbOnTime = new System.Windows.Forms.RadioButton();
            this.lblPassengerFlightId = new System.Windows.Forms.Label();
            this.lblPassengerFlightInfo = new System.Windows.Forms.Label();
            this.pnlPassengerFlightManage = new System.Windows.Forms.Panel();
            this.txtFlightSearch = new System.Windows.Forms.TextBox();
            this.btnFlightSearch = new System.Windows.Forms.Button();
            this.btnFlightRefresh = new System.Windows.Forms.Button();
            this.pnlFlightSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerFlight)).BeginInit();
            this.pnlPassengerFlightManage.SuspendLayout();
            this.pnlFlightSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPassengerFlight
            // 
            this.dgvPassengerFlight.AllowUserToAddRows = false;
            this.dgvPassengerFlight.AllowUserToDeleteRows = false;
            this.dgvPassengerFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPassengerFlight.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPassengerFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPassengerFlight.Location = new System.Drawing.Point(4, 126);
            this.dgvPassengerFlight.Name = "dgvPassengerFlight";
            this.dgvPassengerFlight.ReadOnly = true;
            this.dgvPassengerFlight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengerFlight.Size = new System.Drawing.Size(744, 521);
            this.dgvPassengerFlight.TabIndex = 4;
            this.dgvPassengerFlight.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAPassengerFlight_CellDoubleClick);
            this.dgvPassengerFlight.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPassengerFlight_DataBindingComplete);
            // 
            // lblPassengerFlightDepartureTIme
            // 
            this.lblPassengerFlightDepartureTIme.AutoSize = true;
            this.lblPassengerFlightDepartureTIme.Location = new System.Drawing.Point(5, 232);
            this.lblPassengerFlightDepartureTIme.Name = "lblPassengerFlightDepartureTIme";
            this.lblPassengerFlightDepartureTIme.Size = new System.Drawing.Size(131, 20);
            this.lblPassengerFlightDepartureTIme.TabIndex = 14;
            this.lblPassengerFlightDepartureTIme.Text = "Departure Time : ";
            // 
            // lblPassengerFlightArrivalTime
            // 
            this.lblPassengerFlightArrivalTime.AutoSize = true;
            this.lblPassengerFlightArrivalTime.Location = new System.Drawing.Point(34, 271);
            this.lblPassengerFlightArrivalTime.Name = "lblPassengerFlightArrivalTime";
            this.lblPassengerFlightArrivalTime.Size = new System.Drawing.Size(102, 20);
            this.lblPassengerFlightArrivalTime.TabIndex = 13;
            this.lblPassengerFlightArrivalTime.Text = "Arrival Time : ";
            // 
            // dtpPassengerFlightDepartureTime
            // 
            this.dtpPassengerFlightDepartureTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpPassengerFlightDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPassengerFlightDepartureTime.Location = new System.Drawing.Point(138, 230);
            this.dtpPassengerFlightDepartureTime.Name = "dtpPassengerFlightDepartureTime";
            this.dtpPassengerFlightDepartureTime.Size = new System.Drawing.Size(251, 26);
            this.dtpPassengerFlightDepartureTime.TabIndex = 12;
            // 
            // lblPassengerFlightStatus
            // 
            this.lblPassengerFlightStatus.AutoSize = true;
            this.lblPassengerFlightStatus.Location = new System.Drawing.Point(25, 193);
            this.lblPassengerFlightStatus.Name = "lblPassengerFlightStatus";
            this.lblPassengerFlightStatus.Size = new System.Drawing.Size(111, 20);
            this.lblPassengerFlightStatus.TabIndex = 10;
            this.lblPassengerFlightStatus.Text = "Flight Status : ";
            // 
            // txtPassengerFlightDestination
            // 
            this.txtPassengerFlightDestination.Location = new System.Drawing.Point(138, 152);
            this.txtPassengerFlightDestination.Name = "txtPassengerFlightDestination";
            this.txtPassengerFlightDestination.ReadOnly = true;
            this.txtPassengerFlightDestination.Size = new System.Drawing.Size(251, 26);
            this.txtPassengerFlightDestination.TabIndex = 7;
            // 
            // lblPassengerFlightDestination
            // 
            this.lblPassengerFlightDestination.AutoSize = true;
            this.lblPassengerFlightDestination.Location = new System.Drawing.Point(34, 154);
            this.lblPassengerFlightDestination.Name = "lblPassengerFlightDestination";
            this.lblPassengerFlightDestination.Size = new System.Drawing.Size(102, 20);
            this.lblPassengerFlightDestination.TabIndex = 6;
            this.lblPassengerFlightDestination.Text = "Destination : ";
            // 
            // txtPassengerFlightOrigin
            // 
            this.txtPassengerFlightOrigin.Location = new System.Drawing.Point(138, 112);
            this.txtPassengerFlightOrigin.Name = "txtPassengerFlightOrigin";
            this.txtPassengerFlightOrigin.ReadOnly = true;
            this.txtPassengerFlightOrigin.Size = new System.Drawing.Size(251, 26);
            this.txtPassengerFlightOrigin.TabIndex = 5;
            // 
            // lblPassengerFlightOrigin
            // 
            this.lblPassengerFlightOrigin.AutoSize = true;
            this.lblPassengerFlightOrigin.Location = new System.Drawing.Point(74, 115);
            this.lblPassengerFlightOrigin.Name = "lblPassengerFlightOrigin";
            this.lblPassengerFlightOrigin.Size = new System.Drawing.Size(62, 20);
            this.lblPassengerFlightOrigin.TabIndex = 4;
            this.lblPassengerFlightOrigin.Text = "Origin : ";
            // 
            // txtPassengerFlightNo
            // 
            this.txtPassengerFlightNo.Location = new System.Drawing.Point(138, 73);
            this.txtPassengerFlightNo.Name = "txtPassengerFlightNo";
            this.txtPassengerFlightNo.ReadOnly = true;
            this.txtPassengerFlightNo.Size = new System.Drawing.Size(251, 26);
            this.txtPassengerFlightNo.TabIndex = 3;
            // 
            // lblPassengerFlightNo
            // 
            this.lblPassengerFlightNo.AutoSize = true;
            this.lblPassengerFlightNo.Location = new System.Drawing.Point(52, 76);
            this.lblPassengerFlightNo.Name = "lblPassengerFlightNo";
            this.lblPassengerFlightNo.Size = new System.Drawing.Size(84, 20);
            this.lblPassengerFlightNo.TabIndex = 2;
            this.lblPassengerFlightNo.Text = "Flight No : ";
            // 
            // txtPassengerFlightId
            // 
            this.txtPassengerFlightId.Location = new System.Drawing.Point(138, 34);
            this.txtPassengerFlightId.Name = "txtPassengerFlightId";
            this.txtPassengerFlightId.ReadOnly = true;
            this.txtPassengerFlightId.Size = new System.Drawing.Size(251, 26);
            this.txtPassengerFlightId.TabIndex = 1;
            // 
            // dtpPassengerFlightArrivalTime
            // 
            this.dtpPassengerFlightArrivalTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpPassengerFlightArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPassengerFlightArrivalTime.Location = new System.Drawing.Point(138, 269);
            this.dtpPassengerFlightArrivalTime.Name = "dtpPassengerFlightArrivalTime";
            this.dtpPassengerFlightArrivalTime.Size = new System.Drawing.Size(251, 26);
            this.dtpPassengerFlightArrivalTime.TabIndex = 15;
            // 
            // rdbCancelled
            // 
            this.rdbCancelled.AutoSize = true;
            this.rdbCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCancelled.Location = new System.Drawing.Point(304, 193);
            this.rdbCancelled.Name = "rdbCancelled";
            this.rdbCancelled.Size = new System.Drawing.Size(88, 21);
            this.rdbCancelled.TabIndex = 19;
            this.rdbCancelled.TabStop = true;
            this.rdbCancelled.Text = "Cancelled";
            this.rdbCancelled.UseVisualStyleBackColor = true;
            // 
            // rdbDelayed
            // 
            this.rdbDelayed.AutoSize = true;
            this.rdbDelayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDelayed.Location = new System.Drawing.Point(219, 193);
            this.rdbDelayed.Name = "rdbDelayed";
            this.rdbDelayed.Size = new System.Drawing.Size(78, 21);
            this.rdbDelayed.TabIndex = 18;
            this.rdbDelayed.TabStop = true;
            this.rdbDelayed.Text = "Delayed";
            this.rdbDelayed.UseVisualStyleBackColor = true;
            // 
            // rdbOnTime
            // 
            this.rdbOnTime.AutoSize = true;
            this.rdbOnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOnTime.Location = new System.Drawing.Point(134, 193);
            this.rdbOnTime.Name = "rdbOnTime";
            this.rdbOnTime.Size = new System.Drawing.Size(80, 21);
            this.rdbOnTime.TabIndex = 17;
            this.rdbOnTime.TabStop = true;
            this.rdbOnTime.Text = "On Time";
            this.rdbOnTime.UseVisualStyleBackColor = true;
            // 
            // lblPassengerFlightId
            // 
            this.lblPassengerFlightId.AutoSize = true;
            this.lblPassengerFlightId.Location = new System.Drawing.Point(55, 37);
            this.lblPassengerFlightId.Name = "lblPassengerFlightId";
            this.lblPassengerFlightId.Size = new System.Drawing.Size(81, 20);
            this.lblPassengerFlightId.TabIndex = 0;
            this.lblPassengerFlightId.Text = "Flight ID : ";
            // 
            // lblPassengerFlightInfo
            // 
            this.lblPassengerFlightInfo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblPassengerFlightInfo, 2);
            this.lblPassengerFlightInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassengerFlightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerFlightInfo.Location = new System.Drawing.Point(4, 72);
            this.lblPassengerFlightInfo.Name = "lblPassengerFlightInfo";
            this.lblPassengerFlightInfo.Size = new System.Drawing.Size(1157, 50);
            this.lblPassengerFlightInfo.TabIndex = 0;
            this.lblPassengerFlightInfo.Text = "Flight Info";
            this.lblPassengerFlightInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPassengerFlightManage
            // 
            this.pnlPassengerFlightManage.Controls.Add(this.rdbCancelled);
            this.pnlPassengerFlightManage.Controls.Add(this.rdbDelayed);
            this.pnlPassengerFlightManage.Controls.Add(this.rdbOnTime);
            this.pnlPassengerFlightManage.Controls.Add(this.dtpPassengerFlightArrivalTime);
            this.pnlPassengerFlightManage.Controls.Add(this.lblPassengerFlightDepartureTIme);
            this.pnlPassengerFlightManage.Controls.Add(this.lblPassengerFlightArrivalTime);
            this.pnlPassengerFlightManage.Controls.Add(this.dtpPassengerFlightDepartureTime);
            this.pnlPassengerFlightManage.Controls.Add(this.lblPassengerFlightStatus);
            this.pnlPassengerFlightManage.Controls.Add(this.txtPassengerFlightDestination);
            this.pnlPassengerFlightManage.Controls.Add(this.lblPassengerFlightDestination);
            this.pnlPassengerFlightManage.Controls.Add(this.txtPassengerFlightOrigin);
            this.pnlPassengerFlightManage.Controls.Add(this.lblPassengerFlightOrigin);
            this.pnlPassengerFlightManage.Controls.Add(this.txtPassengerFlightNo);
            this.pnlPassengerFlightManage.Controls.Add(this.lblPassengerFlightNo);
            this.pnlPassengerFlightManage.Controls.Add(this.txtPassengerFlightId);
            this.pnlPassengerFlightManage.Controls.Add(this.lblPassengerFlightId);
            this.pnlPassengerFlightManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPassengerFlightManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPassengerFlightManage.Location = new System.Drawing.Point(755, 126);
            this.pnlPassengerFlightManage.Name = "pnlPassengerFlightManage";
            this.pnlPassengerFlightManage.Size = new System.Drawing.Size(406, 521);
            this.pnlPassengerFlightManage.TabIndex = 3;
            // 
            // txtFlightSearch
            // 
            this.txtFlightSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFlightSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightSearch.Location = new System.Drawing.Point(8, 11);
            this.txtFlightSearch.Multiline = true;
            this.txtFlightSearch.Name = "txtFlightSearch";
            this.txtFlightSearch.Size = new System.Drawing.Size(801, 42);
            this.txtFlightSearch.TabIndex = 0;
            // 
            // btnFlightSearch
            // 
            this.btnFlightSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFlightSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFlightSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlightSearch.Location = new System.Drawing.Point(822, 11);
            this.btnFlightSearch.Name = "btnFlightSearch";
            this.btnFlightSearch.Size = new System.Drawing.Size(154, 42);
            this.btnFlightSearch.TabIndex = 1;
            this.btnFlightSearch.Text = "Search";
            this.btnFlightSearch.UseVisualStyleBackColor = false;
            this.btnFlightSearch.Click += new System.EventHandler(this.btnFlightSearch_Click);
            // 
            // btnFlightRefresh
            // 
            this.btnFlightRefresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFlightRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFlightRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlightRefresh.Location = new System.Drawing.Point(987, 11);
            this.btnFlightRefresh.Name = "btnFlightRefresh";
            this.btnFlightRefresh.Size = new System.Drawing.Size(154, 42);
            this.btnFlightRefresh.TabIndex = 2;
            this.btnFlightRefresh.Text = "Refresh";
            this.btnFlightRefresh.UseVisualStyleBackColor = false;
            this.btnFlightRefresh.Click += new System.EventHandler(this.btnFlightRefresh_Click);
            // 
            // pnlFlightSearch
            // 
            this.pnlFlightSearch.ColumnCount = 7;
            this.tableLayoutPanel1.SetColumnSpan(this.pnlFlightSearch, 2);
            this.pnlFlightSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlFlightSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.073F));
            this.pnlFlightSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9269989F));
            this.pnlFlightSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlFlightSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlFlightSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlFlightSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.pnlFlightSearch.Controls.Add(this.txtFlightSearch, 1, 1);
            this.pnlFlightSearch.Controls.Add(this.btnFlightSearch, 3, 1);
            this.pnlFlightSearch.Controls.Add(this.btnFlightRefresh, 5, 1);
            this.pnlFlightSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFlightSearch.Location = new System.Drawing.Point(4, 4);
            this.pnlFlightSearch.Name = "pnlFlightSearch";
            this.pnlFlightSearch.RowCount = 3;
            this.pnlFlightSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlFlightSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlFlightSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlFlightSearch.Size = new System.Drawing.Size(1157, 64);
            this.pnlFlightSearch.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 412F));
            this.tableLayoutPanel1.Controls.Add(this.pnlFlightSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPassengerFlightInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPassengerFlightManage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvPassengerFlight, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1165, 651);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PassengerFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PassengerFlightForm";
            this.Text = "PassengerFlightForm";
            this.Load += new System.EventHandler(this.PassengerFlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerFlight)).EndInit();
            this.pnlPassengerFlightManage.ResumeLayout(false);
            this.pnlPassengerFlightManage.PerformLayout();
            this.pnlFlightSearch.ResumeLayout(false);
            this.pnlFlightSearch.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPassengerFlight;
        private System.Windows.Forms.Label lblPassengerFlightDepartureTIme;
        private System.Windows.Forms.Label lblPassengerFlightArrivalTime;
        private System.Windows.Forms.DateTimePicker dtpPassengerFlightDepartureTime;
        private System.Windows.Forms.Label lblPassengerFlightStatus;
        private System.Windows.Forms.TextBox txtPassengerFlightDestination;
        private System.Windows.Forms.Label lblPassengerFlightDestination;
        private System.Windows.Forms.TextBox txtPassengerFlightOrigin;
        private System.Windows.Forms.Label lblPassengerFlightOrigin;
        private System.Windows.Forms.TextBox txtPassengerFlightNo;
        private System.Windows.Forms.Label lblPassengerFlightNo;
        private System.Windows.Forms.TextBox txtPassengerFlightId;
        private System.Windows.Forms.DateTimePicker dtpPassengerFlightArrivalTime;
        private System.Windows.Forms.RadioButton rdbCancelled;
        private System.Windows.Forms.RadioButton rdbDelayed;
        private System.Windows.Forms.RadioButton rdbOnTime;
        private System.Windows.Forms.Label lblPassengerFlightId;
        private System.Windows.Forms.Label lblPassengerFlightInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel pnlFlightSearch;
        private System.Windows.Forms.TextBox txtFlightSearch;
        private System.Windows.Forms.Button btnFlightSearch;
        private System.Windows.Forms.Button btnFlightRefresh;
        private System.Windows.Forms.Panel pnlPassengerFlightManage;
    }
}