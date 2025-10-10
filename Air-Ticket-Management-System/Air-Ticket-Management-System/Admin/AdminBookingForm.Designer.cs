namespace Air_Ticket_Management_System
{
    partial class AdminBookingForm
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
            this.dgvAdminBooking = new System.Windows.Forms.DataGridView();
            this.lblAdminBookingDate = new System.Windows.Forms.Label();
            this.dtpAdminBookingDate = new System.Windows.Forms.DateTimePicker();
            this.txtAdminBookingId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdminBookingAdd = new System.Windows.Forms.Button();
            this.btnAdminBookingUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdminBookingDelete = new System.Windows.Forms.Button();
            this.lblAdminBookingId = new System.Windows.Forms.Label();
            this.lblAdminBookingManage = new System.Windows.Forms.Label();
            this.lblAdminBookingInfo = new System.Windows.Forms.Label();
            this.pnlAdminBookingManage = new System.Windows.Forms.Panel();
            this.txtAdminBookingBookedSeats = new System.Windows.Forms.TextBox();
            this.txtAdminBookingFlightId = new System.Windows.Forms.TextBox();
            this.lblAdminBookingFlightId = new System.Windows.Forms.Label();
            this.txtAdminBookingPaymentStatus = new System.Windows.Forms.TextBox();
            this.lblAdminBookingPaymentStatus = new System.Windows.Forms.Label();
            this.cmbAdminBookingFlightName = new System.Windows.Forms.ComboBox();
            this.txtAdminBookingFlightDestination = new System.Windows.Forms.TextBox();
            this.lblAdminBookingFlightDestination = new System.Windows.Forms.Label();
            this.txtAdminBookingFlightOrigin = new System.Windows.Forms.TextBox();
            this.lblAdminBookingFlightOrigin = new System.Windows.Forms.Label();
            this.btnAdminBookingFlightSeat = new System.Windows.Forms.Button();
            this.lblAdminBookingFlightSeat = new System.Windows.Forms.Label();
            this.rdbCancelled = new System.Windows.Forms.RadioButton();
            this.rdbPending = new System.Windows.Forms.RadioButton();
            this.rdbConfirmed = new System.Windows.Forms.RadioButton();
            this.txtAdminBookingPassengerId = new System.Windows.Forms.TextBox();
            this.lblAdminBookingPassengerId = new System.Windows.Forms.Label();
            this.lblAdminBookingFlightNo = new System.Windows.Forms.Label();
            this.lblAdminBookingStatus = new System.Windows.Forms.Label();
            this.txtBookingSearch = new System.Windows.Forms.TextBox();
            this.btnBookingSearch = new System.Windows.Forms.Button();
            this.btnBookingRefresh = new System.Windows.Forms.Button();
            this.pnlBookingSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminBooking)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlAdminBookingManage.SuspendLayout();
            this.pnlBookingSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdminBooking
            // 
            this.dgvAdminBooking.AllowUserToAddRows = false;
            this.dgvAdminBooking.AllowUserToDeleteRows = false;
            this.dgvAdminBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdminBooking.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdminBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminBooking.Location = new System.Drawing.Point(4, 126);
            this.dgvAdminBooking.Name = "dgvAdminBooking";
            this.dgvAdminBooking.ReadOnly = true;
            this.dgvAdminBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminBooking.Size = new System.Drawing.Size(739, 521);
            this.dgvAdminBooking.TabIndex = 4;
            this.dgvAdminBooking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminBooking_CellDoubleClick);
            // 
            // lblAdminBookingDate
            // 
            this.lblAdminBookingDate.AutoSize = true;
            this.lblAdminBookingDate.Location = new System.Drawing.Point(31, 65);
            this.lblAdminBookingDate.Name = "lblAdminBookingDate";
            this.lblAdminBookingDate.Size = new System.Drawing.Size(118, 20);
            this.lblAdminBookingDate.TabIndex = 14;
            this.lblAdminBookingDate.Text = "Booking Date : ";
            // 
            // dtpAdminBookingDate
            // 
            this.dtpAdminBookingDate.CustomFormat = "yyyy-MM-dd";
            this.dtpAdminBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdminBookingDate.Location = new System.Drawing.Point(149, 62);
            this.dtpAdminBookingDate.Name = "dtpAdminBookingDate";
            this.dtpAdminBookingDate.Size = new System.Drawing.Size(238, 26);
            this.dtpAdminBookingDate.TabIndex = 12;
            // 
            // txtAdminBookingId
            // 
            this.txtAdminBookingId.Location = new System.Drawing.Point(149, 24);
            this.txtAdminBookingId.Name = "txtAdminBookingId";
            this.txtAdminBookingId.ReadOnly = true;
            this.txtAdminBookingId.Size = new System.Drawing.Size(238, 26);
            this.txtAdminBookingId.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(123, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 34);
            this.panel2.TabIndex = 1;
            // 
            // btnAdminBookingAdd
            // 
            this.btnAdminBookingAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdminBookingAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminBookingAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminBookingAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdminBookingAdd.Name = "btnAdminBookingAdd";
            this.btnAdminBookingAdd.Size = new System.Drawing.Size(114, 34);
            this.btnAdminBookingAdd.TabIndex = 2;
            this.btnAdminBookingAdd.Text = "Add";
            this.btnAdminBookingAdd.UseVisualStyleBackColor = false;
            this.btnAdminBookingAdd.Click += new System.EventHandler(this.btnAdminFlightAdd_Click_1);
            // 
            // btnAdminBookingUpdate
            // 
            this.btnAdminBookingUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdminBookingUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminBookingUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminBookingUpdate.Location = new System.Drawing.Point(130, 3);
            this.btnAdminBookingUpdate.Name = "btnAdminBookingUpdate";
            this.btnAdminBookingUpdate.Size = new System.Drawing.Size(114, 34);
            this.btnAdminBookingUpdate.TabIndex = 3;
            this.btnAdminBookingUpdate.Text = "Update";
            this.btnAdminBookingUpdate.UseVisualStyleBackColor = false;
            this.btnAdminBookingUpdate.Click += new System.EventHandler(this.btnAdminFlightUpdate_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdminBookingAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdminBookingUpdate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdminBookingDelete, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 422);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 40);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // btnAdminBookingDelete
            // 
            this.btnAdminBookingDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnAdminBookingDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminBookingDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminBookingDelete.Location = new System.Drawing.Point(257, 3);
            this.btnAdminBookingDelete.Name = "btnAdminBookingDelete";
            this.btnAdminBookingDelete.Size = new System.Drawing.Size(114, 34);
            this.btnAdminBookingDelete.TabIndex = 4;
            this.btnAdminBookingDelete.Text = "Delete";
            this.btnAdminBookingDelete.UseVisualStyleBackColor = false;
            this.btnAdminBookingDelete.Click += new System.EventHandler(this.btnAdminFlightDelete_Click);
            // 
            // lblAdminBookingId
            // 
            this.lblAdminBookingId.AutoSize = true;
            this.lblAdminBookingId.Location = new System.Drawing.Point(49, 27);
            this.lblAdminBookingId.Name = "lblAdminBookingId";
            this.lblAdminBookingId.Size = new System.Drawing.Size(100, 20);
            this.lblAdminBookingId.TabIndex = 0;
            this.lblAdminBookingId.Text = "Booking ID : ";
            // 
            // lblAdminBookingManage
            // 
            this.lblAdminBookingManage.AutoSize = true;
            this.lblAdminBookingManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminBookingManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminBookingManage.Location = new System.Drawing.Point(750, 72);
            this.lblAdminBookingManage.Name = "lblAdminBookingManage";
            this.lblAdminBookingManage.Size = new System.Drawing.Size(411, 50);
            this.lblAdminBookingManage.TabIndex = 1;
            this.lblAdminBookingManage.Text = "Manage Bookings";
            this.lblAdminBookingManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminBookingInfo
            // 
            this.lblAdminBookingInfo.AutoSize = true;
            this.lblAdminBookingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminBookingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminBookingInfo.Location = new System.Drawing.Point(4, 72);
            this.lblAdminBookingInfo.Name = "lblAdminBookingInfo";
            this.lblAdminBookingInfo.Size = new System.Drawing.Size(739, 50);
            this.lblAdminBookingInfo.TabIndex = 0;
            this.lblAdminBookingInfo.Text = "Bookings";
            this.lblAdminBookingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAdminBookingManage
            // 
            this.pnlAdminBookingManage.Controls.Add(this.txtAdminBookingBookedSeats);
            this.pnlAdminBookingManage.Controls.Add(this.txtAdminBookingFlightId);
            this.pnlAdminBookingManage.Controls.Add(this.lblAdminBookingFlightId);
            this.pnlAdminBookingManage.Controls.Add(this.txtAdminBookingPaymentStatus);
            this.pnlAdminBookingManage.Controls.Add(this.lblAdminBookingPaymentStatus);
            this.pnlAdminBookingManage.Controls.Add(this.cmbAdminBookingFlightName);
            this.pnlAdminBookingManage.Controls.Add(this.txtAdminBookingFlightDestination);
            this.pnlAdminBookingManage.Controls.Add(this.lblAdminBookingFlightDestination);
            this.pnlAdminBookingManage.Controls.Add(this.txtAdminBookingFlightOrigin);
            this.pnlAdminBookingManage.Controls.Add(this.lblAdminBookingFlightOrigin);
            this.pnlAdminBookingManage.Controls.Add(this.btnAdminBookingFlightSeat);
            this.pnlAdminBookingManage.Controls.Add(this.lblAdminBookingFlightSeat);
            this.pnlAdminBookingManage.Controls.Add(this.rdbCancelled);
            this.pnlAdminBookingManage.Controls.Add(this.rdbPending);
            this.pnlAdminBookingManage.Controls.Add(this.rdbConfirmed);
            this.pnlAdminBookingManage.Controls.Add(this.txtAdminBookingPassengerId);
            this.pnlAdminBookingManage.Controls.Add(this.lblAdminBookingPassengerId);
            this.pnlAdminBookingManage.Controls.Add(this.lblAdminBookingFlightNo);
            this.pnlAdminBookingManage.Controls.Add(this.tableLayoutPanel2);
            this.pnlAdminBookingManage.Controls.Add(this.dtpAdminBookingDate);
            this.pnlAdminBookingManage.Controls.Add(this.txtAdminBookingId);
            this.pnlAdminBookingManage.Controls.Add(this.lblAdminBookingId);
            this.pnlAdminBookingManage.Controls.Add(this.lblAdminBookingDate);
            this.pnlAdminBookingManage.Controls.Add(this.lblAdminBookingStatus);
            this.pnlAdminBookingManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminBookingManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdminBookingManage.Location = new System.Drawing.Point(750, 126);
            this.pnlAdminBookingManage.Name = "pnlAdminBookingManage";
            this.pnlAdminBookingManage.Size = new System.Drawing.Size(411, 521);
            this.pnlAdminBookingManage.TabIndex = 3;
            // 
            // txtAdminBookingBookedSeats
            // 
            this.txtAdminBookingBookedSeats.Location = new System.Drawing.Point(149, 209);
            this.txtAdminBookingBookedSeats.Name = "txtAdminBookingBookedSeats";
            this.txtAdminBookingBookedSeats.ReadOnly = true;
            this.txtAdminBookingBookedSeats.Size = new System.Drawing.Size(115, 26);
            this.txtAdminBookingBookedSeats.TabIndex = 36;
            // 
            // txtAdminBookingFlightId
            // 
            this.txtAdminBookingFlightId.Location = new System.Drawing.Point(149, 173);
            this.txtAdminBookingFlightId.Name = "txtAdminBookingFlightId";
            this.txtAdminBookingFlightId.ReadOnly = true;
            this.txtAdminBookingFlightId.Size = new System.Drawing.Size(238, 26);
            this.txtAdminBookingFlightId.TabIndex = 35;
            // 
            // lblAdminBookingFlightId
            // 
            this.lblAdminBookingFlightId.AutoSize = true;
            this.lblAdminBookingFlightId.Location = new System.Drawing.Point(65, 175);
            this.lblAdminBookingFlightId.Name = "lblAdminBookingFlightId";
            this.lblAdminBookingFlightId.Size = new System.Drawing.Size(81, 20);
            this.lblAdminBookingFlightId.TabIndex = 34;
            this.lblAdminBookingFlightId.Text = "Flight ID : ";
            // 
            // txtAdminBookingPaymentStatus
            // 
            this.txtAdminBookingPaymentStatus.Location = new System.Drawing.Point(149, 323);
            this.txtAdminBookingPaymentStatus.Name = "txtAdminBookingPaymentStatus";
            this.txtAdminBookingPaymentStatus.ReadOnly = true;
            this.txtAdminBookingPaymentStatus.Size = new System.Drawing.Size(238, 26);
            this.txtAdminBookingPaymentStatus.TabIndex = 33;
            // 
            // lblAdminBookingPaymentStatus
            // 
            this.lblAdminBookingPaymentStatus.AutoSize = true;
            this.lblAdminBookingPaymentStatus.Location = new System.Drawing.Point(14, 326);
            this.lblAdminBookingPaymentStatus.Name = "lblAdminBookingPaymentStatus";
            this.lblAdminBookingPaymentStatus.Size = new System.Drawing.Size(134, 20);
            this.lblAdminBookingPaymentStatus.TabIndex = 32;
            this.lblAdminBookingPaymentStatus.Text = "Payment Status : ";
            // 
            // cmbAdminBookingFlightName
            // 
            this.cmbAdminBookingFlightName.FormattingEnabled = true;
            this.cmbAdminBookingFlightName.Location = new System.Drawing.Point(149, 137);
            this.cmbAdminBookingFlightName.Name = "cmbAdminBookingFlightName";
            this.cmbAdminBookingFlightName.Size = new System.Drawing.Size(238, 28);
            this.cmbAdminBookingFlightName.TabIndex = 31;
            this.cmbAdminBookingFlightName.SelectedIndexChanged += new System.EventHandler(this.cmbAdminBookingFlightName_SelectedIndexChanged_1);
            // 
            // txtAdminBookingFlightDestination
            // 
            this.txtAdminBookingFlightDestination.Location = new System.Drawing.Point(149, 286);
            this.txtAdminBookingFlightDestination.Name = "txtAdminBookingFlightDestination";
            this.txtAdminBookingFlightDestination.ReadOnly = true;
            this.txtAdminBookingFlightDestination.Size = new System.Drawing.Size(238, 26);
            this.txtAdminBookingFlightDestination.TabIndex = 30;
            // 
            // lblAdminBookingFlightDestination
            // 
            this.lblAdminBookingFlightDestination.AutoSize = true;
            this.lblAdminBookingFlightDestination.Location = new System.Drawing.Point(46, 289);
            this.lblAdminBookingFlightDestination.Name = "lblAdminBookingFlightDestination";
            this.lblAdminBookingFlightDestination.Size = new System.Drawing.Size(102, 20);
            this.lblAdminBookingFlightDestination.TabIndex = 29;
            this.lblAdminBookingFlightDestination.Text = "Destination : ";
            // 
            // txtAdminBookingFlightOrigin
            // 
            this.txtAdminBookingFlightOrigin.Location = new System.Drawing.Point(149, 248);
            this.txtAdminBookingFlightOrigin.Name = "txtAdminBookingFlightOrigin";
            this.txtAdminBookingFlightOrigin.ReadOnly = true;
            this.txtAdminBookingFlightOrigin.Size = new System.Drawing.Size(238, 26);
            this.txtAdminBookingFlightOrigin.TabIndex = 28;
            // 
            // lblAdminBookingFlightOrigin
            // 
            this.lblAdminBookingFlightOrigin.AutoSize = true;
            this.lblAdminBookingFlightOrigin.Location = new System.Drawing.Point(86, 251);
            this.lblAdminBookingFlightOrigin.Name = "lblAdminBookingFlightOrigin";
            this.lblAdminBookingFlightOrigin.Size = new System.Drawing.Size(62, 20);
            this.lblAdminBookingFlightOrigin.TabIndex = 27;
            this.lblAdminBookingFlightOrigin.Text = "Origin : ";
            // 
            // btnAdminBookingFlightSeat
            // 
            this.btnAdminBookingFlightSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdminBookingFlightSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminBookingFlightSeat.Location = new System.Drawing.Point(270, 207);
            this.btnAdminBookingFlightSeat.Name = "btnAdminBookingFlightSeat";
            this.btnAdminBookingFlightSeat.Size = new System.Drawing.Size(117, 32);
            this.btnAdminBookingFlightSeat.TabIndex = 26;
            this.btnAdminBookingFlightSeat.Text = "Choose Seat";
            this.btnAdminBookingFlightSeat.UseVisualStyleBackColor = false;
            this.btnAdminBookingFlightSeat.Click += new System.EventHandler(this.btnAdminBookingFlightSeat_Click);
            // 
            // lblAdminBookingFlightSeat
            // 
            this.lblAdminBookingFlightSeat.AutoSize = true;
            this.lblAdminBookingFlightSeat.Location = new System.Drawing.Point(93, 212);
            this.lblAdminBookingFlightSeat.Name = "lblAdminBookingFlightSeat";
            this.lblAdminBookingFlightSeat.Size = new System.Drawing.Size(55, 20);
            this.lblAdminBookingFlightSeat.TabIndex = 25;
            this.lblAdminBookingFlightSeat.Text = "Seat : ";
            // 
            // rdbCancelled
            // 
            this.rdbCancelled.AutoSize = true;
            this.rdbCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCancelled.Location = new System.Drawing.Point(309, 363);
            this.rdbCancelled.Name = "rdbCancelled";
            this.rdbCancelled.Size = new System.Drawing.Size(88, 21);
            this.rdbCancelled.TabIndex = 24;
            this.rdbCancelled.TabStop = true;
            this.rdbCancelled.Text = "Cancelled";
            this.rdbCancelled.UseVisualStyleBackColor = true;
            // 
            // rdbPending
            // 
            this.rdbPending.AutoSize = true;
            this.rdbPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPending.Location = new System.Drawing.Point(232, 363);
            this.rdbPending.Name = "rdbPending";
            this.rdbPending.Size = new System.Drawing.Size(78, 21);
            this.rdbPending.TabIndex = 23;
            this.rdbPending.TabStop = true;
            this.rdbPending.Text = "Pending";
            this.rdbPending.UseVisualStyleBackColor = true;
            // 
            // rdbConfirmed
            // 
            this.rdbConfirmed.AutoSize = true;
            this.rdbConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConfirmed.Location = new System.Drawing.Point(143, 363);
            this.rdbConfirmed.Name = "rdbConfirmed";
            this.rdbConfirmed.Size = new System.Drawing.Size(90, 21);
            this.rdbConfirmed.TabIndex = 21;
            this.rdbConfirmed.TabStop = true;
            this.rdbConfirmed.Text = "Confirmed";
            this.rdbConfirmed.UseVisualStyleBackColor = true;
            // 
            // txtAdminBookingPassengerId
            // 
            this.txtAdminBookingPassengerId.Location = new System.Drawing.Point(149, 100);
            this.txtAdminBookingPassengerId.Name = "txtAdminBookingPassengerId";
            this.txtAdminBookingPassengerId.Size = new System.Drawing.Size(238, 26);
            this.txtAdminBookingPassengerId.TabIndex = 20;
            // 
            // lblAdminBookingPassengerId
            // 
            this.lblAdminBookingPassengerId.AutoSize = true;
            this.lblAdminBookingPassengerId.Location = new System.Drawing.Point(30, 103);
            this.lblAdminBookingPassengerId.Name = "lblAdminBookingPassengerId";
            this.lblAdminBookingPassengerId.Size = new System.Drawing.Size(118, 20);
            this.lblAdminBookingPassengerId.TabIndex = 19;
            this.lblAdminBookingPassengerId.Text = "Passenger ID : ";
            // 
            // lblAdminBookingFlightNo
            // 
            this.lblAdminBookingFlightNo.AutoSize = true;
            this.lblAdminBookingFlightNo.Location = new System.Drawing.Point(65, 141);
            this.lblAdminBookingFlightNo.Name = "lblAdminBookingFlightNo";
            this.lblAdminBookingFlightNo.Size = new System.Drawing.Size(84, 20);
            this.lblAdminBookingFlightNo.TabIndex = 17;
            this.lblAdminBookingFlightNo.Text = "Flight No : ";
            // 
            // lblAdminBookingStatus
            // 
            this.lblAdminBookingStatus.AutoSize = true;
            this.lblAdminBookingStatus.Location = new System.Drawing.Point(17, 362);
            this.lblAdminBookingStatus.Name = "lblAdminBookingStatus";
            this.lblAdminBookingStatus.Size = new System.Drawing.Size(130, 20);
            this.lblAdminBookingStatus.TabIndex = 22;
            this.lblAdminBookingStatus.Text = "Booking Status : ";
            // 
            // txtBookingSearch
            // 
            this.txtBookingSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBookingSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingSearch.Location = new System.Drawing.Point(8, 11);
            this.txtBookingSearch.Multiline = true;
            this.txtBookingSearch.Name = "txtBookingSearch";
            this.txtBookingSearch.Size = new System.Drawing.Size(796, 42);
            this.txtBookingSearch.TabIndex = 0;
            // 
            // btnBookingSearch
            // 
            this.btnBookingSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBookingSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBookingSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingSearch.Location = new System.Drawing.Point(817, 11);
            this.btnBookingSearch.Name = "btnBookingSearch";
            this.btnBookingSearch.Size = new System.Drawing.Size(154, 42);
            this.btnBookingSearch.TabIndex = 1;
            this.btnBookingSearch.Text = "Search";
            this.btnBookingSearch.UseVisualStyleBackColor = false;
            this.btnBookingSearch.Click += new System.EventHandler(this.btnBookingSearch_Click);
            // 
            // btnBookingRefresh
            // 
            this.btnBookingRefresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBookingRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBookingRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingRefresh.Location = new System.Drawing.Point(982, 11);
            this.btnBookingRefresh.Name = "btnBookingRefresh";
            this.btnBookingRefresh.Size = new System.Drawing.Size(154, 42);
            this.btnBookingRefresh.TabIndex = 2;
            this.btnBookingRefresh.Text = "Refresh";
            this.btnBookingRefresh.UseVisualStyleBackColor = false;
            this.btnBookingRefresh.Click += new System.EventHandler(this.btnBookingRefresh_Click);
            // 
            // pnlBookingSearch
            // 
            this.pnlBookingSearch.ColumnCount = 7;
            this.tableLayoutPanel1.SetColumnSpan(this.pnlBookingSearch, 2);
            this.pnlBookingSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlBookingSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.073F));
            this.pnlBookingSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9269989F));
            this.pnlBookingSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlBookingSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlBookingSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlBookingSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.pnlBookingSearch.Controls.Add(this.txtBookingSearch, 1, 1);
            this.pnlBookingSearch.Controls.Add(this.btnBookingSearch, 3, 1);
            this.pnlBookingSearch.Controls.Add(this.btnBookingRefresh, 5, 1);
            this.pnlBookingSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBookingSearch.Location = new System.Drawing.Point(4, 4);
            this.pnlBookingSearch.Name = "pnlBookingSearch";
            this.pnlBookingSearch.RowCount = 3;
            this.pnlBookingSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlBookingSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlBookingSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlBookingSearch.Size = new System.Drawing.Size(1157, 64);
            this.pnlBookingSearch.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 417F));
            this.tableLayoutPanel1.Controls.Add(this.pnlBookingSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminBookingManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminBookingInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlAdminBookingManage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvAdminBooking, 0, 2);
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
            // AdminBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminBookingForm";
            this.Text = "AdminBookingForm";
            this.Load += new System.EventHandler(this.AdminBookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminBooking)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlAdminBookingManage.ResumeLayout(false);
            this.pnlAdminBookingManage.PerformLayout();
            this.pnlBookingSearch.ResumeLayout(false);
            this.pnlBookingSearch.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminBooking;
        private System.Windows.Forms.Label lblAdminBookingDate;
        private System.Windows.Forms.DateTimePicker dtpAdminBookingDate;
        private System.Windows.Forms.TextBox txtAdminBookingId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdminBookingAdd;
        private System.Windows.Forms.Button btnAdminBookingUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdminBookingDelete;
        private System.Windows.Forms.Label lblAdminBookingId;
        private System.Windows.Forms.Label lblAdminBookingManage;
        private System.Windows.Forms.Label lblAdminBookingInfo;
        private System.Windows.Forms.Panel pnlAdminBookingManage;
        private System.Windows.Forms.TextBox txtBookingSearch;
        private System.Windows.Forms.Button btnBookingSearch;
        private System.Windows.Forms.Button btnBookingRefresh;
        private System.Windows.Forms.TableLayoutPanel pnlBookingSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAdminBookingFlightNo;
        private System.Windows.Forms.Label lblAdminBookingPassengerId;
        private System.Windows.Forms.TextBox txtAdminBookingPassengerId;
        private System.Windows.Forms.RadioButton rdbCancelled;
        private System.Windows.Forms.RadioButton rdbPending;
        private System.Windows.Forms.RadioButton rdbConfirmed;
        private System.Windows.Forms.Label lblAdminBookingStatus;
        private System.Windows.Forms.Button btnAdminBookingFlightSeat;
        private System.Windows.Forms.Label lblAdminBookingFlightSeat;
        private System.Windows.Forms.ComboBox cmbAdminBookingFlightName;
        private System.Windows.Forms.TextBox txtAdminBookingFlightDestination;
        private System.Windows.Forms.Label lblAdminBookingFlightDestination;
        private System.Windows.Forms.TextBox txtAdminBookingFlightOrigin;
        private System.Windows.Forms.Label lblAdminBookingFlightOrigin;
        private System.Windows.Forms.Label lblAdminBookingPaymentStatus;
        private System.Windows.Forms.TextBox txtAdminBookingPaymentStatus;
        private System.Windows.Forms.TextBox txtAdminBookingFlightId;
        private System.Windows.Forms.Label lblAdminBookingFlightId;
        private System.Windows.Forms.TextBox txtAdminBookingBookedSeats;
    }
}