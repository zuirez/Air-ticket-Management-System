namespace Air_Ticket_Management_System.Employee
{
    partial class EmployeeFlightForm
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
            this.dgvEmployeeFlight = new System.Windows.Forms.DataGridView();
            this.lblEmployeeFlightDepartureTIme = new System.Windows.Forms.Label();
            this.lblEmployeeFlightArrivalTime = new System.Windows.Forms.Label();
            this.dtpEmployeeFlightDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeFlightStatus = new System.Windows.Forms.Label();
            this.txtEmployeeFlightDestination = new System.Windows.Forms.TextBox();
            this.lblEmployeeFlightDestination = new System.Windows.Forms.Label();
            this.txtEmployeeFlightOrigin = new System.Windows.Forms.TextBox();
            this.lblEmployeeFlightOrigin = new System.Windows.Forms.Label();
            this.txtEmployeeFlightNo = new System.Windows.Forms.TextBox();
            this.lblEmployeeFlightNo = new System.Windows.Forms.Label();
            this.txtEmployeeFlightId = new System.Windows.Forms.TextBox();
            this.dtpEmployeeFlightArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.rdbCancelled = new System.Windows.Forms.RadioButton();
            this.rdbDelayed = new System.Windows.Forms.RadioButton();
            this.rdbOnTime = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmployeeFlightId = new System.Windows.Forms.Label();
            this.lblEmployeeFlightManage = new System.Windows.Forms.Label();
            this.lblEmployeeFlightInfo = new System.Windows.Forms.Label();
            this.pnlEmployeeFlightManage = new System.Windows.Forms.Panel();
            this.txtFlightSearch = new System.Windows.Forms.TextBox();
            this.btnFlightSearch = new System.Windows.Forms.Button();
            this.btnFlightRefresh = new System.Windows.Forms.Button();
            this.pnlFlightSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEmployeeFlightUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeFlight)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlEmployeeFlightManage.SuspendLayout();
            this.pnlFlightSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployeeFlight
            // 
            this.dgvEmployeeFlight.AllowUserToAddRows = false;
            this.dgvEmployeeFlight.AllowUserToDeleteRows = false;
            this.dgvEmployeeFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeFlight.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeFlight.Location = new System.Drawing.Point(4, 126);
            this.dgvEmployeeFlight.Name = "dgvEmployeeFlight";
            this.dgvEmployeeFlight.ReadOnly = true;
            this.dgvEmployeeFlight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeFlight.Size = new System.Drawing.Size(744, 521);
            this.dgvEmployeeFlight.TabIndex = 4;
            this.dgvEmployeeFlight.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeFlight_CellDoubleClick);
            this.dgvEmployeeFlight.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEmployeeFlight_DataBindingComplete);
            // 
            // lblEmployeeFlightDepartureTIme
            // 
            this.lblEmployeeFlightDepartureTIme.AutoSize = true;
            this.lblEmployeeFlightDepartureTIme.Location = new System.Drawing.Point(5, 232);
            this.lblEmployeeFlightDepartureTIme.Name = "lblEmployeeFlightDepartureTIme";
            this.lblEmployeeFlightDepartureTIme.Size = new System.Drawing.Size(131, 20);
            this.lblEmployeeFlightDepartureTIme.TabIndex = 14;
            this.lblEmployeeFlightDepartureTIme.Text = "Departure Time : ";
            // 
            // lblEmployeeFlightArrivalTime
            // 
            this.lblEmployeeFlightArrivalTime.AutoSize = true;
            this.lblEmployeeFlightArrivalTime.Location = new System.Drawing.Point(34, 271);
            this.lblEmployeeFlightArrivalTime.Name = "lblEmployeeFlightArrivalTime";
            this.lblEmployeeFlightArrivalTime.Size = new System.Drawing.Size(102, 20);
            this.lblEmployeeFlightArrivalTime.TabIndex = 13;
            this.lblEmployeeFlightArrivalTime.Text = "Arrival Time : ";
            // 
            // dtpEmployeeFlightDepartureTime
            // 
            this.dtpEmployeeFlightDepartureTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpEmployeeFlightDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmployeeFlightDepartureTime.Location = new System.Drawing.Point(138, 230);
            this.dtpEmployeeFlightDepartureTime.Name = "dtpEmployeeFlightDepartureTime";
            this.dtpEmployeeFlightDepartureTime.Size = new System.Drawing.Size(251, 26);
            this.dtpEmployeeFlightDepartureTime.TabIndex = 12;
            // 
            // lblEmployeeFlightStatus
            // 
            this.lblEmployeeFlightStatus.AutoSize = true;
            this.lblEmployeeFlightStatus.Location = new System.Drawing.Point(25, 193);
            this.lblEmployeeFlightStatus.Name = "lblEmployeeFlightStatus";
            this.lblEmployeeFlightStatus.Size = new System.Drawing.Size(111, 20);
            this.lblEmployeeFlightStatus.TabIndex = 10;
            this.lblEmployeeFlightStatus.Text = "Flight Status : ";
            // 
            // txtEmployeeFlightDestination
            // 
            this.txtEmployeeFlightDestination.Location = new System.Drawing.Point(138, 152);
            this.txtEmployeeFlightDestination.Name = "txtEmployeeFlightDestination";
            this.txtEmployeeFlightDestination.ReadOnly = true;
            this.txtEmployeeFlightDestination.Size = new System.Drawing.Size(251, 26);
            this.txtEmployeeFlightDestination.TabIndex = 7;
            // 
            // lblEmployeeFlightDestination
            // 
            this.lblEmployeeFlightDestination.AutoSize = true;
            this.lblEmployeeFlightDestination.Location = new System.Drawing.Point(34, 154);
            this.lblEmployeeFlightDestination.Name = "lblEmployeeFlightDestination";
            this.lblEmployeeFlightDestination.Size = new System.Drawing.Size(102, 20);
            this.lblEmployeeFlightDestination.TabIndex = 6;
            this.lblEmployeeFlightDestination.Text = "Destination : ";
            // 
            // txtEmployeeFlightOrigin
            // 
            this.txtEmployeeFlightOrigin.Location = new System.Drawing.Point(138, 112);
            this.txtEmployeeFlightOrigin.Name = "txtEmployeeFlightOrigin";
            this.txtEmployeeFlightOrigin.ReadOnly = true;
            this.txtEmployeeFlightOrigin.Size = new System.Drawing.Size(251, 26);
            this.txtEmployeeFlightOrigin.TabIndex = 5;
            // 
            // lblEmployeeFlightOrigin
            // 
            this.lblEmployeeFlightOrigin.AutoSize = true;
            this.lblEmployeeFlightOrigin.Location = new System.Drawing.Point(74, 115);
            this.lblEmployeeFlightOrigin.Name = "lblEmployeeFlightOrigin";
            this.lblEmployeeFlightOrigin.Size = new System.Drawing.Size(62, 20);
            this.lblEmployeeFlightOrigin.TabIndex = 4;
            this.lblEmployeeFlightOrigin.Text = "Origin : ";
            // 
            // txtEmployeeFlightNo
            // 
            this.txtEmployeeFlightNo.Location = new System.Drawing.Point(138, 73);
            this.txtEmployeeFlightNo.Name = "txtEmployeeFlightNo";
            this.txtEmployeeFlightNo.ReadOnly = true;
            this.txtEmployeeFlightNo.Size = new System.Drawing.Size(251, 26);
            this.txtEmployeeFlightNo.TabIndex = 3;
            // 
            // lblEmployeeFlightNo
            // 
            this.lblEmployeeFlightNo.AutoSize = true;
            this.lblEmployeeFlightNo.Location = new System.Drawing.Point(52, 76);
            this.lblEmployeeFlightNo.Name = "lblEmployeeFlightNo";
            this.lblEmployeeFlightNo.Size = new System.Drawing.Size(84, 20);
            this.lblEmployeeFlightNo.TabIndex = 2;
            this.lblEmployeeFlightNo.Text = "Flight No : ";
            // 
            // txtEmployeeFlightId
            // 
            this.txtEmployeeFlightId.Location = new System.Drawing.Point(138, 34);
            this.txtEmployeeFlightId.Name = "txtEmployeeFlightId";
            this.txtEmployeeFlightId.ReadOnly = true;
            this.txtEmployeeFlightId.Size = new System.Drawing.Size(251, 26);
            this.txtEmployeeFlightId.TabIndex = 1;
            // 
            // dtpEmployeeFlightArrivalTime
            // 
            this.dtpEmployeeFlightArrivalTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpEmployeeFlightArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmployeeFlightArrivalTime.Location = new System.Drawing.Point(138, 269);
            this.dtpEmployeeFlightArrivalTime.Name = "dtpEmployeeFlightArrivalTime";
            this.dtpEmployeeFlightArrivalTime.Size = new System.Drawing.Size(251, 26);
            this.dtpEmployeeFlightArrivalTime.TabIndex = 15;
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
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnEmployeeFlightUpdate, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 324);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 40);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // lblEmployeeFlightId
            // 
            this.lblEmployeeFlightId.AutoSize = true;
            this.lblEmployeeFlightId.Location = new System.Drawing.Point(55, 37);
            this.lblEmployeeFlightId.Name = "lblEmployeeFlightId";
            this.lblEmployeeFlightId.Size = new System.Drawing.Size(81, 20);
            this.lblEmployeeFlightId.TabIndex = 0;
            this.lblEmployeeFlightId.Text = "Flight ID : ";
            // 
            // lblEmployeeFlightManage
            // 
            this.lblEmployeeFlightManage.AutoSize = true;
            this.lblEmployeeFlightManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmployeeFlightManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeFlightManage.Location = new System.Drawing.Point(755, 72);
            this.lblEmployeeFlightManage.Name = "lblEmployeeFlightManage";
            this.lblEmployeeFlightManage.Size = new System.Drawing.Size(406, 50);
            this.lblEmployeeFlightManage.TabIndex = 1;
            this.lblEmployeeFlightManage.Text = "Manage Flights";
            this.lblEmployeeFlightManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeFlightInfo
            // 
            this.lblEmployeeFlightInfo.AutoSize = true;
            this.lblEmployeeFlightInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmployeeFlightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeFlightInfo.Location = new System.Drawing.Point(4, 72);
            this.lblEmployeeFlightInfo.Name = "lblEmployeeFlightInfo";
            this.lblEmployeeFlightInfo.Size = new System.Drawing.Size(744, 50);
            this.lblEmployeeFlightInfo.TabIndex = 0;
            this.lblEmployeeFlightInfo.Text = "Flight Info";
            this.lblEmployeeFlightInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEmployeeFlightManage
            // 
            this.pnlEmployeeFlightManage.Controls.Add(this.rdbCancelled);
            this.pnlEmployeeFlightManage.Controls.Add(this.rdbDelayed);
            this.pnlEmployeeFlightManage.Controls.Add(this.rdbOnTime);
            this.pnlEmployeeFlightManage.Controls.Add(this.tableLayoutPanel2);
            this.pnlEmployeeFlightManage.Controls.Add(this.dtpEmployeeFlightArrivalTime);
            this.pnlEmployeeFlightManage.Controls.Add(this.lblEmployeeFlightDepartureTIme);
            this.pnlEmployeeFlightManage.Controls.Add(this.lblEmployeeFlightArrivalTime);
            this.pnlEmployeeFlightManage.Controls.Add(this.dtpEmployeeFlightDepartureTime);
            this.pnlEmployeeFlightManage.Controls.Add(this.lblEmployeeFlightStatus);
            this.pnlEmployeeFlightManage.Controls.Add(this.txtEmployeeFlightDestination);
            this.pnlEmployeeFlightManage.Controls.Add(this.lblEmployeeFlightDestination);
            this.pnlEmployeeFlightManage.Controls.Add(this.txtEmployeeFlightOrigin);
            this.pnlEmployeeFlightManage.Controls.Add(this.lblEmployeeFlightOrigin);
            this.pnlEmployeeFlightManage.Controls.Add(this.txtEmployeeFlightNo);
            this.pnlEmployeeFlightManage.Controls.Add(this.lblEmployeeFlightNo);
            this.pnlEmployeeFlightManage.Controls.Add(this.txtEmployeeFlightId);
            this.pnlEmployeeFlightManage.Controls.Add(this.lblEmployeeFlightId);
            this.pnlEmployeeFlightManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployeeFlightManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEmployeeFlightManage.Location = new System.Drawing.Point(755, 126);
            this.pnlEmployeeFlightManage.Name = "pnlEmployeeFlightManage";
            this.pnlEmployeeFlightManage.Size = new System.Drawing.Size(406, 521);
            this.pnlEmployeeFlightManage.TabIndex = 3;
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
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeeFlightManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeeFlightInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlEmployeeFlightManage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvEmployeeFlight, 0, 2);
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
            // btnEmployeeFlightUpdate
            // 
            this.btnEmployeeFlightUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEmployeeFlightUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployeeFlightUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeFlightUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnEmployeeFlightUpdate.Name = "btnEmployeeFlightUpdate";
            this.btnEmployeeFlightUpdate.Size = new System.Drawing.Size(368, 34);
            this.btnEmployeeFlightUpdate.TabIndex = 3;
            this.btnEmployeeFlightUpdate.Text = "Update";
            this.btnEmployeeFlightUpdate.UseVisualStyleBackColor = false;
            this.btnEmployeeFlightUpdate.Click += new System.EventHandler(this.btnEmployeeFlightUpdate_Click);
            // 
            // EmployeeFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeeFlightForm";
            this.Text = "EmployeeFlightForm";
            this.Load += new System.EventHandler(this.EmployeeFlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeFlight)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlEmployeeFlightManage.ResumeLayout(false);
            this.pnlEmployeeFlightManage.PerformLayout();
            this.pnlFlightSearch.ResumeLayout(false);
            this.pnlFlightSearch.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeFlight;
        private System.Windows.Forms.Label lblEmployeeFlightDepartureTIme;
        private System.Windows.Forms.Label lblEmployeeFlightArrivalTime;
        private System.Windows.Forms.DateTimePicker dtpEmployeeFlightDepartureTime;
        private System.Windows.Forms.Label lblEmployeeFlightStatus;
        private System.Windows.Forms.TextBox txtEmployeeFlightDestination;
        private System.Windows.Forms.Label lblEmployeeFlightDestination;
        private System.Windows.Forms.TextBox txtEmployeeFlightOrigin;
        private System.Windows.Forms.Label lblEmployeeFlightOrigin;
        private System.Windows.Forms.TextBox txtEmployeeFlightNo;
        private System.Windows.Forms.Label lblEmployeeFlightNo;
        private System.Windows.Forms.TextBox txtEmployeeFlightId;
        private System.Windows.Forms.DateTimePicker dtpEmployeeFlightArrivalTime;
        private System.Windows.Forms.RadioButton rdbCancelled;
        private System.Windows.Forms.RadioButton rdbDelayed;
        private System.Windows.Forms.RadioButton rdbOnTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnEmployeeFlightUpdate;
        private System.Windows.Forms.Label lblEmployeeFlightId;
        private System.Windows.Forms.Label lblEmployeeFlightManage;
        private System.Windows.Forms.Label lblEmployeeFlightInfo;
        private System.Windows.Forms.Panel pnlEmployeeFlightManage;
        private System.Windows.Forms.TextBox txtFlightSearch;
        private System.Windows.Forms.Button btnFlightSearch;
        private System.Windows.Forms.Button btnFlightRefresh;
        private System.Windows.Forms.TableLayoutPanel pnlFlightSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}