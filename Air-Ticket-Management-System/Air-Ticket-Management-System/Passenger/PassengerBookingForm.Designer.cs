namespace Air_Ticket_Management_System.Passenger
{
    partial class PassengerBookingForm
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
            this.pnlBookingSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtBookingSearch = new System.Windows.Forms.TextBox();
            this.btnBookingSearch = new System.Windows.Forms.Button();
            this.btnBookingRefresh = new System.Windows.Forms.Button();
            this.lblPassengerBookingManage = new System.Windows.Forms.Label();
            this.lblPassengerBookingInfo = new System.Windows.Forms.Label();
            this.pnlPassengerBookingManage = new System.Windows.Forms.Panel();
            this.txtPassengerBookingBookedSeats = new System.Windows.Forms.TextBox();
            this.txtPassengerBookingFlightId = new System.Windows.Forms.TextBox();
            this.lblPassengerBookingFlightId = new System.Windows.Forms.Label();
            this.txtPassengerBookingPaymentStatus = new System.Windows.Forms.TextBox();
            this.lblPassengerBookingPaymentStatus = new System.Windows.Forms.Label();
            this.cmbPassengerBookingFlightName = new System.Windows.Forms.ComboBox();
            this.txtPassengerBookingFlightDestination = new System.Windows.Forms.TextBox();
            this.lblPassengerBookingFlightDestination = new System.Windows.Forms.Label();
            this.txtPassengerBookingFlightOrigin = new System.Windows.Forms.TextBox();
            this.lblPassengerBookingFlightOrigin = new System.Windows.Forms.Label();
            this.btnPassengerBookingFlightSeat = new System.Windows.Forms.Button();
            this.lblPassengerBookingFlightSeat = new System.Windows.Forms.Label();
            this.rdbCancelled = new System.Windows.Forms.RadioButton();
            this.rdbPending = new System.Windows.Forms.RadioButton();
            this.rdbConfirmed = new System.Windows.Forms.RadioButton();
            this.txtPassengerBookingPassengerId = new System.Windows.Forms.TextBox();
            this.lblPassengerBookingPassengerId = new System.Windows.Forms.Label();
            this.lblPassengerBookingFlightNo = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPassengerBookingAdd = new System.Windows.Forms.Button();
            this.btnPassengerBookingDelete = new System.Windows.Forms.Button();
            this.dtpPassengerBookingDate = new System.Windows.Forms.DateTimePicker();
            this.txtPassengerBookingId = new System.Windows.Forms.TextBox();
            this.lblPassengerBookingId = new System.Windows.Forms.Label();
            this.lblPassengerBookingDate = new System.Windows.Forms.Label();
            this.lblPassengerBookingStatus = new System.Windows.Forms.Label();
            this.dgvPassengerBooking = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBookingSearch.SuspendLayout();
            this.pnlPassengerBookingManage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 419F));
            this.tableLayoutPanel1.Controls.Add(this.pnlBookingSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPassengerBookingManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPassengerBookingInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPassengerBookingManage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvPassengerBooking, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1165, 651);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.pnlBookingSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
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
            // txtBookingSearch
            // 
            this.txtBookingSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBookingSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingSearch.Location = new System.Drawing.Point(8, 11);
            this.txtBookingSearch.Multiline = true;
            this.txtBookingSearch.Name = "txtBookingSearch";
            this.txtBookingSearch.Size = new System.Drawing.Size(794, 42);
            this.txtBookingSearch.TabIndex = 0;
            // 
            // btnBookingSearch
            // 
            this.btnBookingSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBookingSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBookingSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingSearch.Location = new System.Drawing.Point(815, 11);
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
            this.btnBookingRefresh.Location = new System.Drawing.Point(980, 11);
            this.btnBookingRefresh.Name = "btnBookingRefresh";
            this.btnBookingRefresh.Size = new System.Drawing.Size(154, 42);
            this.btnBookingRefresh.TabIndex = 2;
            this.btnBookingRefresh.Text = "Refresh";
            this.btnBookingRefresh.UseVisualStyleBackColor = false;
            this.btnBookingRefresh.Click += new System.EventHandler(this.btnBookingRefresh_Click);
            // 
            // lblPassengerBookingManage
            // 
            this.lblPassengerBookingManage.AutoSize = true;
            this.lblPassengerBookingManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassengerBookingManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerBookingManage.Location = new System.Drawing.Point(748, 72);
            this.lblPassengerBookingManage.Name = "lblPassengerBookingManage";
            this.lblPassengerBookingManage.Size = new System.Drawing.Size(413, 50);
            this.lblPassengerBookingManage.TabIndex = 1;
            this.lblPassengerBookingManage.Text = "Manage Bookings";
            this.lblPassengerBookingManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassengerBookingInfo
            // 
            this.lblPassengerBookingInfo.AutoSize = true;
            this.lblPassengerBookingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassengerBookingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerBookingInfo.Location = new System.Drawing.Point(4, 72);
            this.lblPassengerBookingInfo.Name = "lblPassengerBookingInfo";
            this.lblPassengerBookingInfo.Size = new System.Drawing.Size(737, 50);
            this.lblPassengerBookingInfo.TabIndex = 0;
            this.lblPassengerBookingInfo.Text = "Bookings";
            this.lblPassengerBookingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPassengerBookingManage
            // 
            this.pnlPassengerBookingManage.Controls.Add(this.txtPassengerBookingBookedSeats);
            this.pnlPassengerBookingManage.Controls.Add(this.txtPassengerBookingFlightId);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingFlightId);
            this.pnlPassengerBookingManage.Controls.Add(this.txtPassengerBookingPaymentStatus);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingPaymentStatus);
            this.pnlPassengerBookingManage.Controls.Add(this.cmbPassengerBookingFlightName);
            this.pnlPassengerBookingManage.Controls.Add(this.txtPassengerBookingFlightDestination);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingFlightDestination);
            this.pnlPassengerBookingManage.Controls.Add(this.txtPassengerBookingFlightOrigin);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingFlightOrigin);
            this.pnlPassengerBookingManage.Controls.Add(this.btnPassengerBookingFlightSeat);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingFlightSeat);
            this.pnlPassengerBookingManage.Controls.Add(this.rdbCancelled);
            this.pnlPassengerBookingManage.Controls.Add(this.rdbPending);
            this.pnlPassengerBookingManage.Controls.Add(this.rdbConfirmed);
            this.pnlPassengerBookingManage.Controls.Add(this.txtPassengerBookingPassengerId);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingPassengerId);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingFlightNo);
            this.pnlPassengerBookingManage.Controls.Add(this.tableLayoutPanel2);
            this.pnlPassengerBookingManage.Controls.Add(this.dtpPassengerBookingDate);
            this.pnlPassengerBookingManage.Controls.Add(this.txtPassengerBookingId);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingId);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingDate);
            this.pnlPassengerBookingManage.Controls.Add(this.lblPassengerBookingStatus);
            this.pnlPassengerBookingManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPassengerBookingManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPassengerBookingManage.Location = new System.Drawing.Point(748, 126);
            this.pnlPassengerBookingManage.Name = "pnlPassengerBookingManage";
            this.pnlPassengerBookingManage.Size = new System.Drawing.Size(413, 521);
            this.pnlPassengerBookingManage.TabIndex = 3;
            // 
            // txtPassengerBookingBookedSeats
            // 
            this.txtPassengerBookingBookedSeats.Location = new System.Drawing.Point(149, 209);
            this.txtPassengerBookingBookedSeats.Name = "txtPassengerBookingBookedSeats";
            this.txtPassengerBookingBookedSeats.ReadOnly = true;
            this.txtPassengerBookingBookedSeats.Size = new System.Drawing.Size(115, 26);
            this.txtPassengerBookingBookedSeats.TabIndex = 36;
            // 
            // txtPassengerBookingFlightId
            // 
            this.txtPassengerBookingFlightId.Location = new System.Drawing.Point(149, 173);
            this.txtPassengerBookingFlightId.Name = "txtPassengerBookingFlightId";
            this.txtPassengerBookingFlightId.ReadOnly = true;
            this.txtPassengerBookingFlightId.Size = new System.Drawing.Size(238, 26);
            this.txtPassengerBookingFlightId.TabIndex = 35;
            // 
            // lblPassengerBookingFlightId
            // 
            this.lblPassengerBookingFlightId.AutoSize = true;
            this.lblPassengerBookingFlightId.Location = new System.Drawing.Point(65, 175);
            this.lblPassengerBookingFlightId.Name = "lblPassengerBookingFlightId";
            this.lblPassengerBookingFlightId.Size = new System.Drawing.Size(81, 20);
            this.lblPassengerBookingFlightId.TabIndex = 34;
            this.lblPassengerBookingFlightId.Text = "Flight ID : ";
            // 
            // txtPassengerBookingPaymentStatus
            // 
            this.txtPassengerBookingPaymentStatus.Location = new System.Drawing.Point(149, 323);
            this.txtPassengerBookingPaymentStatus.Name = "txtPassengerBookingPaymentStatus";
            this.txtPassengerBookingPaymentStatus.ReadOnly = true;
            this.txtPassengerBookingPaymentStatus.Size = new System.Drawing.Size(238, 26);
            this.txtPassengerBookingPaymentStatus.TabIndex = 33;
            // 
            // lblPassengerBookingPaymentStatus
            // 
            this.lblPassengerBookingPaymentStatus.AutoSize = true;
            this.lblPassengerBookingPaymentStatus.Location = new System.Drawing.Point(14, 326);
            this.lblPassengerBookingPaymentStatus.Name = "lblPassengerBookingPaymentStatus";
            this.lblPassengerBookingPaymentStatus.Size = new System.Drawing.Size(134, 20);
            this.lblPassengerBookingPaymentStatus.TabIndex = 32;
            this.lblPassengerBookingPaymentStatus.Text = "Payment Status : ";
            // 
            // cmbPassengerBookingFlightName
            // 
            this.cmbPassengerBookingFlightName.FormattingEnabled = true;
            this.cmbPassengerBookingFlightName.Location = new System.Drawing.Point(149, 137);
            this.cmbPassengerBookingFlightName.Name = "cmbPassengerBookingFlightName";
            this.cmbPassengerBookingFlightName.Size = new System.Drawing.Size(238, 28);
            this.cmbPassengerBookingFlightName.TabIndex = 31;
            this.cmbPassengerBookingFlightName.SelectedIndexChanged += new System.EventHandler(this.cmbPassengerBookingFlightName_SelectedIndexChanged);
            // 
            // txtPassengerBookingFlightDestination
            // 
            this.txtPassengerBookingFlightDestination.Location = new System.Drawing.Point(149, 286);
            this.txtPassengerBookingFlightDestination.Name = "txtPassengerBookingFlightDestination";
            this.txtPassengerBookingFlightDestination.ReadOnly = true;
            this.txtPassengerBookingFlightDestination.Size = new System.Drawing.Size(238, 26);
            this.txtPassengerBookingFlightDestination.TabIndex = 30;
            // 
            // lblPassengerBookingFlightDestination
            // 
            this.lblPassengerBookingFlightDestination.AutoSize = true;
            this.lblPassengerBookingFlightDestination.Location = new System.Drawing.Point(46, 289);
            this.lblPassengerBookingFlightDestination.Name = "lblPassengerBookingFlightDestination";
            this.lblPassengerBookingFlightDestination.Size = new System.Drawing.Size(102, 20);
            this.lblPassengerBookingFlightDestination.TabIndex = 29;
            this.lblPassengerBookingFlightDestination.Text = "Destination : ";
            // 
            // txtPassengerBookingFlightOrigin
            // 
            this.txtPassengerBookingFlightOrigin.Location = new System.Drawing.Point(149, 248);
            this.txtPassengerBookingFlightOrigin.Name = "txtPassengerBookingFlightOrigin";
            this.txtPassengerBookingFlightOrigin.ReadOnly = true;
            this.txtPassengerBookingFlightOrigin.Size = new System.Drawing.Size(238, 26);
            this.txtPassengerBookingFlightOrigin.TabIndex = 28;
            // 
            // lblPassengerBookingFlightOrigin
            // 
            this.lblPassengerBookingFlightOrigin.AutoSize = true;
            this.lblPassengerBookingFlightOrigin.Location = new System.Drawing.Point(86, 251);
            this.lblPassengerBookingFlightOrigin.Name = "lblPassengerBookingFlightOrigin";
            this.lblPassengerBookingFlightOrigin.Size = new System.Drawing.Size(62, 20);
            this.lblPassengerBookingFlightOrigin.TabIndex = 27;
            this.lblPassengerBookingFlightOrigin.Text = "Origin : ";
            // 
            // btnPassengerBookingFlightSeat
            // 
            this.btnPassengerBookingFlightSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPassengerBookingFlightSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerBookingFlightSeat.Location = new System.Drawing.Point(270, 207);
            this.btnPassengerBookingFlightSeat.Name = "btnPassengerBookingFlightSeat";
            this.btnPassengerBookingFlightSeat.Size = new System.Drawing.Size(117, 32);
            this.btnPassengerBookingFlightSeat.TabIndex = 26;
            this.btnPassengerBookingFlightSeat.Text = "Choose Seat";
            this.btnPassengerBookingFlightSeat.UseVisualStyleBackColor = false;
            this.btnPassengerBookingFlightSeat.Click += new System.EventHandler(this.btnPassengerBookingFlightSeat_Click);
            // 
            // lblPassengerBookingFlightSeat
            // 
            this.lblPassengerBookingFlightSeat.AutoSize = true;
            this.lblPassengerBookingFlightSeat.Location = new System.Drawing.Point(93, 212);
            this.lblPassengerBookingFlightSeat.Name = "lblPassengerBookingFlightSeat";
            this.lblPassengerBookingFlightSeat.Size = new System.Drawing.Size(55, 20);
            this.lblPassengerBookingFlightSeat.TabIndex = 25;
            this.lblPassengerBookingFlightSeat.Text = "Seat : ";
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
            // txtPassengerBookingPassengerId
            // 
            this.txtPassengerBookingPassengerId.Location = new System.Drawing.Point(149, 100);
            this.txtPassengerBookingPassengerId.Name = "txtPassengerBookingPassengerId";
            this.txtPassengerBookingPassengerId.ReadOnly = true;
            this.txtPassengerBookingPassengerId.Size = new System.Drawing.Size(238, 26);
            this.txtPassengerBookingPassengerId.TabIndex = 20;
            // 
            // lblPassengerBookingPassengerId
            // 
            this.lblPassengerBookingPassengerId.AutoSize = true;
            this.lblPassengerBookingPassengerId.Location = new System.Drawing.Point(30, 103);
            this.lblPassengerBookingPassengerId.Name = "lblPassengerBookingPassengerId";
            this.lblPassengerBookingPassengerId.Size = new System.Drawing.Size(118, 20);
            this.lblPassengerBookingPassengerId.TabIndex = 19;
            this.lblPassengerBookingPassengerId.Text = "Passenger ID : ";
            // 
            // lblPassengerBookingFlightNo
            // 
            this.lblPassengerBookingFlightNo.AutoSize = true;
            this.lblPassengerBookingFlightNo.Location = new System.Drawing.Point(65, 141);
            this.lblPassengerBookingFlightNo.Name = "lblPassengerBookingFlightNo";
            this.lblPassengerBookingFlightNo.Size = new System.Drawing.Size(84, 20);
            this.lblPassengerBookingFlightNo.TabIndex = 17;
            this.lblPassengerBookingFlightNo.Text = "Flight No : ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPassengerBookingAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPassengerBookingDelete, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 420);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 40);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(185, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 34);
            this.panel2.TabIndex = 1;
            // 
            // btnPassengerBookingAdd
            // 
            this.btnPassengerBookingAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPassengerBookingAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassengerBookingAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerBookingAdd.Location = new System.Drawing.Point(3, 3);
            this.btnPassengerBookingAdd.Name = "btnPassengerBookingAdd";
            this.btnPassengerBookingAdd.Size = new System.Drawing.Size(176, 34);
            this.btnPassengerBookingAdd.TabIndex = 2;
            this.btnPassengerBookingAdd.Text = "Add";
            this.btnPassengerBookingAdd.UseVisualStyleBackColor = false;
            this.btnPassengerBookingAdd.Click += new System.EventHandler(this.btnPassengerBookingAdd_Click);
            // 
            // btnPassengerBookingDelete
            // 
            this.btnPassengerBookingDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnPassengerBookingDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassengerBookingDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerBookingDelete.Location = new System.Drawing.Point(195, 3);
            this.btnPassengerBookingDelete.Name = "btnPassengerBookingDelete";
            this.btnPassengerBookingDelete.Size = new System.Drawing.Size(176, 34);
            this.btnPassengerBookingDelete.TabIndex = 4;
            this.btnPassengerBookingDelete.Text = "Delete";
            this.btnPassengerBookingDelete.UseVisualStyleBackColor = false;
            this.btnPassengerBookingDelete.Click += new System.EventHandler(this.btnPassengerBookingDelete_Click);
            // 
            // dtpPassengerBookingDate
            // 
            this.dtpPassengerBookingDate.CustomFormat = "yyyy-MM-dd";
            this.dtpPassengerBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPassengerBookingDate.Location = new System.Drawing.Point(149, 62);
            this.dtpPassengerBookingDate.Name = "dtpPassengerBookingDate";
            this.dtpPassengerBookingDate.Size = new System.Drawing.Size(238, 26);
            this.dtpPassengerBookingDate.TabIndex = 12;
            // 
            // txtPassengerBookingId
            // 
            this.txtPassengerBookingId.Location = new System.Drawing.Point(149, 24);
            this.txtPassengerBookingId.Name = "txtPassengerBookingId";
            this.txtPassengerBookingId.ReadOnly = true;
            this.txtPassengerBookingId.Size = new System.Drawing.Size(238, 26);
            this.txtPassengerBookingId.TabIndex = 1;
            // 
            // lblPassengerBookingId
            // 
            this.lblPassengerBookingId.AutoSize = true;
            this.lblPassengerBookingId.Location = new System.Drawing.Point(49, 27);
            this.lblPassengerBookingId.Name = "lblPassengerBookingId";
            this.lblPassengerBookingId.Size = new System.Drawing.Size(100, 20);
            this.lblPassengerBookingId.TabIndex = 0;
            this.lblPassengerBookingId.Text = "Booking ID : ";
            // 
            // lblPassengerBookingDate
            // 
            this.lblPassengerBookingDate.AutoSize = true;
            this.lblPassengerBookingDate.Location = new System.Drawing.Point(31, 65);
            this.lblPassengerBookingDate.Name = "lblPassengerBookingDate";
            this.lblPassengerBookingDate.Size = new System.Drawing.Size(118, 20);
            this.lblPassengerBookingDate.TabIndex = 14;
            this.lblPassengerBookingDate.Text = "Booking Date : ";
            // 
            // lblPassengerBookingStatus
            // 
            this.lblPassengerBookingStatus.AutoSize = true;
            this.lblPassengerBookingStatus.Location = new System.Drawing.Point(17, 362);
            this.lblPassengerBookingStatus.Name = "lblPassengerBookingStatus";
            this.lblPassengerBookingStatus.Size = new System.Drawing.Size(130, 20);
            this.lblPassengerBookingStatus.TabIndex = 22;
            this.lblPassengerBookingStatus.Text = "Booking Status : ";
            // 
            // dgvPassengerBooking
            // 
            this.dgvPassengerBooking.AllowUserToAddRows = false;
            this.dgvPassengerBooking.AllowUserToDeleteRows = false;
            this.dgvPassengerBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPassengerBooking.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPassengerBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPassengerBooking.Location = new System.Drawing.Point(4, 126);
            this.dgvPassengerBooking.Name = "dgvPassengerBooking";
            this.dgvPassengerBooking.ReadOnly = true;
            this.dgvPassengerBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengerBooking.Size = new System.Drawing.Size(737, 521);
            this.dgvPassengerBooking.TabIndex = 4;
            this.dgvPassengerBooking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPassengerBooking_CellDoubleClick);
            // 
            // PassengerBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PassengerBookingForm";
            this.Text = "PassengerBookingForm";
            this.Load += new System.EventHandler(this.PassengerBookingForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlBookingSearch.ResumeLayout(false);
            this.pnlBookingSearch.PerformLayout();
            this.pnlPassengerBookingManage.ResumeLayout(false);
            this.pnlPassengerBookingManage.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel pnlBookingSearch;
        private System.Windows.Forms.TextBox txtBookingSearch;
        private System.Windows.Forms.Button btnBookingSearch;
        private System.Windows.Forms.Button btnBookingRefresh;
        private System.Windows.Forms.Label lblPassengerBookingManage;
        private System.Windows.Forms.Label lblPassengerBookingInfo;
        private System.Windows.Forms.Panel pnlPassengerBookingManage;
        private System.Windows.Forms.TextBox txtPassengerBookingBookedSeats;
        private System.Windows.Forms.TextBox txtPassengerBookingFlightId;
        private System.Windows.Forms.Label lblPassengerBookingFlightId;
        private System.Windows.Forms.TextBox txtPassengerBookingPaymentStatus;
        private System.Windows.Forms.Label lblPassengerBookingPaymentStatus;
        private System.Windows.Forms.ComboBox cmbPassengerBookingFlightName;
        private System.Windows.Forms.TextBox txtPassengerBookingFlightDestination;
        private System.Windows.Forms.Label lblPassengerBookingFlightDestination;
        private System.Windows.Forms.TextBox txtPassengerBookingFlightOrigin;
        private System.Windows.Forms.Label lblPassengerBookingFlightOrigin;
        private System.Windows.Forms.Button btnPassengerBookingFlightSeat;
        private System.Windows.Forms.Label lblPassengerBookingFlightSeat;
        private System.Windows.Forms.RadioButton rdbCancelled;
        private System.Windows.Forms.RadioButton rdbPending;
        private System.Windows.Forms.RadioButton rdbConfirmed;
        private System.Windows.Forms.TextBox txtPassengerBookingPassengerId;
        private System.Windows.Forms.Label lblPassengerBookingPassengerId;
        private System.Windows.Forms.Label lblPassengerBookingFlightNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPassengerBookingAdd;
        private System.Windows.Forms.Button btnPassengerBookingDelete;
        private System.Windows.Forms.DateTimePicker dtpPassengerBookingDate;
        private System.Windows.Forms.TextBox txtPassengerBookingId;
        private System.Windows.Forms.Label lblPassengerBookingId;
        private System.Windows.Forms.Label lblPassengerBookingDate;
        private System.Windows.Forms.Label lblPassengerBookingStatus;
        private System.Windows.Forms.DataGridView dgvPassengerBooking;
    }
}