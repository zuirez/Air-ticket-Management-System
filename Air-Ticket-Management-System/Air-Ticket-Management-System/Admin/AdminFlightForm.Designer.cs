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
            this.pnlFlightSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtFlightSearch = new System.Windows.Forms.TextBox();
            this.btnFlightSearch = new System.Windows.Forms.Button();
            this.btnFlightRefresh = new System.Windows.Forms.Button();
            this.lblAdminFlightManage = new System.Windows.Forms.Label();
            this.lblAdminFlightInfo = new System.Windows.Forms.Label();
            this.pnlAdminFlightManage = new System.Windows.Forms.Panel();
            this.rdbCancelled = new System.Windows.Forms.RadioButton();
            this.rdbDelayed = new System.Windows.Forms.RadioButton();
            this.rdbOnTime = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdminFlightAdd = new System.Windows.Forms.Button();
            this.btnAdminFlightUpdate = new System.Windows.Forms.Button();
            this.btnAdminFlightDelete = new System.Windows.Forms.Button();
            this.dtpAdminFlightArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.lblAdminFlightDepartureTIme = new System.Windows.Forms.Label();
            this.lblAdminFlightArrivalTime = new System.Windows.Forms.Label();
            this.dtpAdminFlightDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.lblAdminFlightStatus = new System.Windows.Forms.Label();
            this.txtAdminFlightDestination = new System.Windows.Forms.TextBox();
            this.lblAdminFlightDestination = new System.Windows.Forms.Label();
            this.txtAdminFlightOrigin = new System.Windows.Forms.TextBox();
            this.lblAdminFlightOrigin = new System.Windows.Forms.Label();
            this.txtAdminFlightNo = new System.Windows.Forms.TextBox();
            this.lblAdminFlightNo = new System.Windows.Forms.Label();
            this.txtAdminFlightId = new System.Windows.Forms.TextBox();
            this.lblAdminFlightId = new System.Windows.Forms.Label();
            this.dgvAdminFlight = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlFlightSearch.SuspendLayout();
            this.pnlAdminFlightManage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.tableLayoutPanel1.Controls.Add(this.pnlFlightSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminFlightManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminFlightInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlAdminFlightManage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvAdminFlight, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1165, 651);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.pnlFlightSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
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
            // txtFlightSearch
            // 
            this.txtFlightSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFlightSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightSearch.Location = new System.Drawing.Point(8, 11);
            this.txtFlightSearch.Multiline = true;
            this.txtFlightSearch.Name = "txtFlightSearch";
            this.txtFlightSearch.Size = new System.Drawing.Size(800, 42);
            this.txtFlightSearch.TabIndex = 0;
            // 
            // btnFlightSearch
            // 
            this.btnFlightSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFlightSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFlightSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlightSearch.Location = new System.Drawing.Point(821, 11);
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
            this.btnFlightRefresh.Location = new System.Drawing.Point(986, 11);
            this.btnFlightRefresh.Name = "btnFlightRefresh";
            this.btnFlightRefresh.Size = new System.Drawing.Size(154, 42);
            this.btnFlightRefresh.TabIndex = 2;
            this.btnFlightRefresh.Text = "Refresh";
            this.btnFlightRefresh.UseVisualStyleBackColor = false;
            this.btnFlightRefresh.Click += new System.EventHandler(this.btnFlightRefresh_Click);
            // 
            // lblAdminFlightManage
            // 
            this.lblAdminFlightManage.AutoSize = true;
            this.lblAdminFlightManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminFlightManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminFlightManage.Location = new System.Drawing.Point(754, 72);
            this.lblAdminFlightManage.Name = "lblAdminFlightManage";
            this.lblAdminFlightManage.Size = new System.Drawing.Size(407, 50);
            this.lblAdminFlightManage.TabIndex = 1;
            this.lblAdminFlightManage.Text = "Manage Flights";
            this.lblAdminFlightManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminFlightInfo
            // 
            this.lblAdminFlightInfo.AutoSize = true;
            this.lblAdminFlightInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminFlightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminFlightInfo.Location = new System.Drawing.Point(4, 72);
            this.lblAdminFlightInfo.Name = "lblAdminFlightInfo";
            this.lblAdminFlightInfo.Size = new System.Drawing.Size(743, 50);
            this.lblAdminFlightInfo.TabIndex = 0;
            this.lblAdminFlightInfo.Text = "Flight Info";
            this.lblAdminFlightInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAdminFlightManage
            // 
            this.pnlAdminFlightManage.Controls.Add(this.rdbCancelled);
            this.pnlAdminFlightManage.Controls.Add(this.rdbDelayed);
            this.pnlAdminFlightManage.Controls.Add(this.rdbOnTime);
            this.pnlAdminFlightManage.Controls.Add(this.tableLayoutPanel2);
            this.pnlAdminFlightManage.Controls.Add(this.dtpAdminFlightArrivalTime);
            this.pnlAdminFlightManage.Controls.Add(this.lblAdminFlightDepartureTIme);
            this.pnlAdminFlightManage.Controls.Add(this.lblAdminFlightArrivalTime);
            this.pnlAdminFlightManage.Controls.Add(this.dtpAdminFlightDepartureTime);
            this.pnlAdminFlightManage.Controls.Add(this.lblAdminFlightStatus);
            this.pnlAdminFlightManage.Controls.Add(this.txtAdminFlightDestination);
            this.pnlAdminFlightManage.Controls.Add(this.lblAdminFlightDestination);
            this.pnlAdminFlightManage.Controls.Add(this.txtAdminFlightOrigin);
            this.pnlAdminFlightManage.Controls.Add(this.lblAdminFlightOrigin);
            this.pnlAdminFlightManage.Controls.Add(this.txtAdminFlightNo);
            this.pnlAdminFlightManage.Controls.Add(this.lblAdminFlightNo);
            this.pnlAdminFlightManage.Controls.Add(this.txtAdminFlightId);
            this.pnlAdminFlightManage.Controls.Add(this.lblAdminFlightId);
            this.pnlAdminFlightManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminFlightManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdminFlightManage.Location = new System.Drawing.Point(754, 126);
            this.pnlAdminFlightManage.Name = "pnlAdminFlightManage";
            this.pnlAdminFlightManage.Size = new System.Drawing.Size(407, 521);
            this.pnlAdminFlightManage.TabIndex = 3;
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
            this.tableLayoutPanel2.Controls.Add(this.btnAdminFlightAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdminFlightUpdate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdminFlightDelete, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 324);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 40);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(123, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 34);
            this.panel2.TabIndex = 1;
            // 
            // btnAdminFlightAdd
            // 
            this.btnAdminFlightAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdminFlightAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminFlightAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminFlightAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdminFlightAdd.Name = "btnAdminFlightAdd";
            this.btnAdminFlightAdd.Size = new System.Drawing.Size(114, 34);
            this.btnAdminFlightAdd.TabIndex = 2;
            this.btnAdminFlightAdd.Text = "Add";
            this.btnAdminFlightAdd.UseVisualStyleBackColor = false;
            this.btnAdminFlightAdd.Click += new System.EventHandler(this.btnAdminFlightAdd_Click);
            // 
            // btnAdminFlightUpdate
            // 
            this.btnAdminFlightUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdminFlightUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminFlightUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminFlightUpdate.Location = new System.Drawing.Point(130, 3);
            this.btnAdminFlightUpdate.Name = "btnAdminFlightUpdate";
            this.btnAdminFlightUpdate.Size = new System.Drawing.Size(114, 34);
            this.btnAdminFlightUpdate.TabIndex = 3;
            this.btnAdminFlightUpdate.Text = "Update";
            this.btnAdminFlightUpdate.UseVisualStyleBackColor = false;
            this.btnAdminFlightUpdate.Click += new System.EventHandler(this.btnAdminFlightUpdate_Click);
            // 
            // btnAdminFlightDelete
            // 
            this.btnAdminFlightDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnAdminFlightDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminFlightDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminFlightDelete.Location = new System.Drawing.Point(257, 3);
            this.btnAdminFlightDelete.Name = "btnAdminFlightDelete";
            this.btnAdminFlightDelete.Size = new System.Drawing.Size(114, 34);
            this.btnAdminFlightDelete.TabIndex = 4;
            this.btnAdminFlightDelete.Text = "Delete";
            this.btnAdminFlightDelete.UseVisualStyleBackColor = false;
            this.btnAdminFlightDelete.Click += new System.EventHandler(this.btnAdminFlightDelete_Click);
            // 
            // dtpAdminFlightArrivalTime
            // 
            this.dtpAdminFlightArrivalTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpAdminFlightArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdminFlightArrivalTime.Location = new System.Drawing.Point(138, 229);
            this.dtpAdminFlightArrivalTime.Name = "dtpAdminFlightArrivalTime";
            this.dtpAdminFlightArrivalTime.Size = new System.Drawing.Size(251, 26);
            this.dtpAdminFlightArrivalTime.TabIndex = 15;
            // 
            // lblAdminFlightDepartureTIme
            // 
            this.lblAdminFlightDepartureTIme.AutoSize = true;
            this.lblAdminFlightDepartureTIme.Location = new System.Drawing.Point(6, 271);
            this.lblAdminFlightDepartureTIme.Name = "lblAdminFlightDepartureTIme";
            this.lblAdminFlightDepartureTIme.Size = new System.Drawing.Size(131, 20);
            this.lblAdminFlightDepartureTIme.TabIndex = 14;
            this.lblAdminFlightDepartureTIme.Text = "Departure Time : ";
            // 
            // lblAdminFlightArrivalTime
            // 
            this.lblAdminFlightArrivalTime.AutoSize = true;
            this.lblAdminFlightArrivalTime.Location = new System.Drawing.Point(34, 231);
            this.lblAdminFlightArrivalTime.Name = "lblAdminFlightArrivalTime";
            this.lblAdminFlightArrivalTime.Size = new System.Drawing.Size(102, 20);
            this.lblAdminFlightArrivalTime.TabIndex = 13;
            this.lblAdminFlightArrivalTime.Text = "Arrival Time : ";
            // 
            // dtpAdminFlightDepartureTime
            // 
            this.dtpAdminFlightDepartureTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpAdminFlightDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdminFlightDepartureTime.Location = new System.Drawing.Point(139, 269);
            this.dtpAdminFlightDepartureTime.Name = "dtpAdminFlightDepartureTime";
            this.dtpAdminFlightDepartureTime.Size = new System.Drawing.Size(251, 26);
            this.dtpAdminFlightDepartureTime.TabIndex = 12;
            // 
            // lblAdminFlightStatus
            // 
            this.lblAdminFlightStatus.AutoSize = true;
            this.lblAdminFlightStatus.Location = new System.Drawing.Point(25, 193);
            this.lblAdminFlightStatus.Name = "lblAdminFlightStatus";
            this.lblAdminFlightStatus.Size = new System.Drawing.Size(111, 20);
            this.lblAdminFlightStatus.TabIndex = 10;
            this.lblAdminFlightStatus.Text = "Flight Status : ";
            // 
            // txtAdminFlightDestination
            // 
            this.txtAdminFlightDestination.Location = new System.Drawing.Point(138, 152);
            this.txtAdminFlightDestination.Name = "txtAdminFlightDestination";
            this.txtAdminFlightDestination.Size = new System.Drawing.Size(251, 26);
            this.txtAdminFlightDestination.TabIndex = 7;
            // 
            // lblAdminFlightDestination
            // 
            this.lblAdminFlightDestination.AutoSize = true;
            this.lblAdminFlightDestination.Location = new System.Drawing.Point(34, 154);
            this.lblAdminFlightDestination.Name = "lblAdminFlightDestination";
            this.lblAdminFlightDestination.Size = new System.Drawing.Size(102, 20);
            this.lblAdminFlightDestination.TabIndex = 6;
            this.lblAdminFlightDestination.Text = "Destination : ";
            // 
            // txtAdminFlightOrigin
            // 
            this.txtAdminFlightOrigin.Location = new System.Drawing.Point(138, 112);
            this.txtAdminFlightOrigin.Name = "txtAdminFlightOrigin";
            this.txtAdminFlightOrigin.Size = new System.Drawing.Size(251, 26);
            this.txtAdminFlightOrigin.TabIndex = 5;
            // 
            // lblAdminFlightOrigin
            // 
            this.lblAdminFlightOrigin.AutoSize = true;
            this.lblAdminFlightOrigin.Location = new System.Drawing.Point(74, 115);
            this.lblAdminFlightOrigin.Name = "lblAdminFlightOrigin";
            this.lblAdminFlightOrigin.Size = new System.Drawing.Size(62, 20);
            this.lblAdminFlightOrigin.TabIndex = 4;
            this.lblAdminFlightOrigin.Text = "Origin : ";
            // 
            // txtAdminFlightNo
            // 
            this.txtAdminFlightNo.Location = new System.Drawing.Point(138, 73);
            this.txtAdminFlightNo.Name = "txtAdminFlightNo";
            this.txtAdminFlightNo.Size = new System.Drawing.Size(251, 26);
            this.txtAdminFlightNo.TabIndex = 3;
            // 
            // lblAdminFlightNo
            // 
            this.lblAdminFlightNo.AutoSize = true;
            this.lblAdminFlightNo.Location = new System.Drawing.Point(52, 76);
            this.lblAdminFlightNo.Name = "lblAdminFlightNo";
            this.lblAdminFlightNo.Size = new System.Drawing.Size(84, 20);
            this.lblAdminFlightNo.TabIndex = 2;
            this.lblAdminFlightNo.Text = "Flight No : ";
            // 
            // txtAdminFlightId
            // 
            this.txtAdminFlightId.Location = new System.Drawing.Point(138, 34);
            this.txtAdminFlightId.Name = "txtAdminFlightId";
            this.txtAdminFlightId.ReadOnly = true;
            this.txtAdminFlightId.Size = new System.Drawing.Size(251, 26);
            this.txtAdminFlightId.TabIndex = 1;
            // 
            // lblAdminFlightId
            // 
            this.lblAdminFlightId.AutoSize = true;
            this.lblAdminFlightId.Location = new System.Drawing.Point(55, 37);
            this.lblAdminFlightId.Name = "lblAdminFlightId";
            this.lblAdminFlightId.Size = new System.Drawing.Size(81, 20);
            this.lblAdminFlightId.TabIndex = 0;
            this.lblAdminFlightId.Text = "Flight ID : ";
            // 
            // dgvAdminFlight
            // 
            this.dgvAdminFlight.AllowUserToAddRows = false;
            this.dgvAdminFlight.AllowUserToDeleteRows = false;
            this.dgvAdminFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdminFlight.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdminFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminFlight.Location = new System.Drawing.Point(4, 126);
            this.dgvAdminFlight.Name = "dgvAdminFlight";
            this.dgvAdminFlight.ReadOnly = true;
            this.dgvAdminFlight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminFlight.Size = new System.Drawing.Size(743, 521);
            this.dgvAdminFlight.TabIndex = 4;
            this.dgvAdminFlight.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminFlight_CellDoubleClick);
            // 
            // AdminFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminFlightForm";
            this.Text = "AdminFlightForm";
            this.Load += new System.EventHandler(this.AdminFlightForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlFlightSearch.ResumeLayout(false);
            this.pnlFlightSearch.PerformLayout();
            this.pnlAdminFlightManage.ResumeLayout(false);
            this.pnlAdminFlightManage.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminFlight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAdminFlightManage;
        private System.Windows.Forms.Label lblAdminFlightInfo;
        private System.Windows.Forms.Panel pnlAdminFlightManage;
        private System.Windows.Forms.Label lblAdminFlightId;
        private System.Windows.Forms.Label lblAdminFlightStatus;
        private System.Windows.Forms.Label lblAdminFlightDestination;
        private System.Windows.Forms.Label lblAdminFlightOrigin;
        private System.Windows.Forms.Label lblAdminFlightNo;
        private System.Windows.Forms.Label lblAdminFlightArrivalTime;
        private System.Windows.Forms.Label lblAdminFlightDepartureTIme;
        private System.Windows.Forms.DataGridView dgvAdminFlight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdminFlightAdd;
        private System.Windows.Forms.Button btnAdminFlightUpdate;
        private System.Windows.Forms.Button btnAdminFlightDelete;
        private System.Windows.Forms.TableLayoutPanel pnlFlightSearch;
        private System.Windows.Forms.TextBox txtFlightSearch;
        private System.Windows.Forms.Button btnFlightSearch;
        private System.Windows.Forms.Button btnFlightRefresh;
        private System.Windows.Forms.RadioButton rdbCancelled;
        private System.Windows.Forms.RadioButton rdbDelayed;
        private System.Windows.Forms.RadioButton rdbOnTime;
        private System.Windows.Forms.DateTimePicker dtpAdminFlightArrivalTime;
        private System.Windows.Forms.DateTimePicker dtpAdminFlightDepartureTime;
        private System.Windows.Forms.TextBox txtAdminFlightDestination;
        private System.Windows.Forms.TextBox txtAdminFlightOrigin;
        private System.Windows.Forms.TextBox txtAdminFlightNo;
        private System.Windows.Forms.TextBox txtAdminFlightId;
    }
}