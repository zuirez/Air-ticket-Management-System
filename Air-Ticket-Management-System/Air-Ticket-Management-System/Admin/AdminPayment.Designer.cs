namespace Air_Ticket_Management_System
{
    partial class AdminPayment
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
            this.dgvAdminPayment = new System.Windows.Forms.DataGridView();
            this.lblAdminPaymentDate = new System.Windows.Forms.Label();
            this.dtpAdminPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblAdminPaymentStatus = new System.Windows.Forms.Label();
            this.txtAdminPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblAdminPaymentAmount = new System.Windows.Forms.Label();
            this.txtAdminPaymentId = new System.Windows.Forms.TextBox();
            this.btnAdminPaymentUpdate = new System.Windows.Forms.Button();
            this.rdbCancelled = new System.Windows.Forms.RadioButton();
            this.rdbPending = new System.Windows.Forms.RadioButton();
            this.rdbPaid = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdminPaymentDelete = new System.Windows.Forms.Button();
            this.lblAdminPaymentId = new System.Windows.Forms.Label();
            this.lblAdminPaymentManage = new System.Windows.Forms.Label();
            this.lblAdminPaymentInfo = new System.Windows.Forms.Label();
            this.pnlAdminPaymentManage = new System.Windows.Forms.Panel();
            this.cmbAdminPaymentType = new System.Windows.Forms.ComboBox();
            this.lblAdminPaymentType = new System.Windows.Forms.Label();
            this.txtPaymentSearch = new System.Windows.Forms.TextBox();
            this.btnPaymentSearch = new System.Windows.Forms.Button();
            this.btnPaymentRefresh = new System.Windows.Forms.Button();
            this.pnlPaymentSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAdminPaymentPassengerId = new System.Windows.Forms.TextBox();
            this.lblAdminPaymentPassengerId = new System.Windows.Forms.Label();
            this.txtAdminPaymentBookingId = new System.Windows.Forms.TextBox();
            this.lblAdminPaymentBookingId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPayment)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlAdminPaymentManage.SuspendLayout();
            this.pnlPaymentSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdminPayment
            // 
            this.dgvAdminPayment.AllowUserToAddRows = false;
            this.dgvAdminPayment.AllowUserToDeleteRows = false;
            this.dgvAdminPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdminPayment.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdminPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminPayment.Location = new System.Drawing.Point(4, 126);
            this.dgvAdminPayment.Name = "dgvAdminPayment";
            this.dgvAdminPayment.ReadOnly = true;
            this.dgvAdminPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminPayment.Size = new System.Drawing.Size(744, 521);
            this.dgvAdminPayment.TabIndex = 4;
            this.dgvAdminPayment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminPayment_CellDoubleClick);
            // 
            // lblAdminPaymentDate
            // 
            this.lblAdminPaymentDate.AutoSize = true;
            this.lblAdminPaymentDate.Location = new System.Drawing.Point(39, 165);
            this.lblAdminPaymentDate.Name = "lblAdminPaymentDate";
            this.lblAdminPaymentDate.Size = new System.Drawing.Size(122, 20);
            this.lblAdminPaymentDate.TabIndex = 14;
            this.lblAdminPaymentDate.Text = "Payment Date : ";
            // 
            // dtpAdminPaymentDate
            // 
            this.dtpAdminPaymentDate.CustomFormat = "yyyy-MM-dd";
            this.dtpAdminPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdminPaymentDate.Location = new System.Drawing.Point(164, 164);
            this.dtpAdminPaymentDate.Name = "dtpAdminPaymentDate";
            this.dtpAdminPaymentDate.Size = new System.Drawing.Size(222, 26);
            this.dtpAdminPaymentDate.TabIndex = 12;
            // 
            // lblAdminPaymentStatus
            // 
            this.lblAdminPaymentStatus.AutoSize = true;
            this.lblAdminPaymentStatus.Location = new System.Drawing.Point(27, 243);
            this.lblAdminPaymentStatus.Name = "lblAdminPaymentStatus";
            this.lblAdminPaymentStatus.Size = new System.Drawing.Size(134, 20);
            this.lblAdminPaymentStatus.TabIndex = 10;
            this.lblAdminPaymentStatus.Text = "Payment Status : ";
            // 
            // txtAdminPaymentAmount
            // 
            this.txtAdminPaymentAmount.Location = new System.Drawing.Point(164, 123);
            this.txtAdminPaymentAmount.Name = "txtAdminPaymentAmount";
            this.txtAdminPaymentAmount.ReadOnly = true;
            this.txtAdminPaymentAmount.Size = new System.Drawing.Size(222, 26);
            this.txtAdminPaymentAmount.TabIndex = 3;
            // 
            // lblAdminPaymentAmount
            // 
            this.lblAdminPaymentAmount.AutoSize = true;
            this.lblAdminPaymentAmount.Location = new System.Drawing.Point(14, 126);
            this.lblAdminPaymentAmount.Name = "lblAdminPaymentAmount";
            this.lblAdminPaymentAmount.Size = new System.Drawing.Size(147, 20);
            this.lblAdminPaymentAmount.TabIndex = 2;
            this.lblAdminPaymentAmount.Text = "Payment Amount :  ";
            // 
            // txtAdminPaymentId
            // 
            this.txtAdminPaymentId.Location = new System.Drawing.Point(164, 21);
            this.txtAdminPaymentId.Name = "txtAdminPaymentId";
            this.txtAdminPaymentId.ReadOnly = true;
            this.txtAdminPaymentId.Size = new System.Drawing.Size(222, 26);
            this.txtAdminPaymentId.TabIndex = 1;
            // 
            // btnAdminPaymentUpdate
            // 
            this.btnAdminPaymentUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdminPaymentUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminPaymentUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPaymentUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnAdminPaymentUpdate.Name = "btnAdminPaymentUpdate";
            this.btnAdminPaymentUpdate.Size = new System.Drawing.Size(174, 34);
            this.btnAdminPaymentUpdate.TabIndex = 3;
            this.btnAdminPaymentUpdate.Text = "Update";
            this.btnAdminPaymentUpdate.UseVisualStyleBackColor = false;
            this.btnAdminPaymentUpdate.Click += new System.EventHandler(this.btnAdminPaymentUpdate_Click);
            // 
            // rdbCancelled
            // 
            this.rdbCancelled.AutoSize = true;
            this.rdbCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCancelled.Location = new System.Drawing.Point(304, 243);
            this.rdbCancelled.Name = "rdbCancelled";
            this.rdbCancelled.Size = new System.Drawing.Size(88, 21);
            this.rdbCancelled.TabIndex = 19;
            this.rdbCancelled.TabStop = true;
            this.rdbCancelled.Text = "Cancelled";
            this.rdbCancelled.UseVisualStyleBackColor = true;
            // 
            // rdbPending
            // 
            this.rdbPending.AutoSize = true;
            this.rdbPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPending.Location = new System.Drawing.Point(221, 243);
            this.rdbPending.Name = "rdbPending";
            this.rdbPending.Size = new System.Drawing.Size(78, 21);
            this.rdbPending.TabIndex = 18;
            this.rdbPending.TabStop = true;
            this.rdbPending.Text = "Pending";
            this.rdbPending.UseVisualStyleBackColor = true;
            // 
            // rdbPaid
            // 
            this.rdbPaid.AutoSize = true;
            this.rdbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPaid.Location = new System.Drawing.Point(166, 243);
            this.rdbPaid.Name = "rdbPaid";
            this.rdbPaid.Size = new System.Drawing.Size(54, 21);
            this.rdbPaid.TabIndex = 17;
            this.rdbPaid.TabStop = true;
            this.rdbPaid.Text = "Paid";
            this.rdbPaid.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdminPaymentUpdate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdminPaymentDelete, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(19, 300);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(371, 40);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // btnAdminPaymentDelete
            // 
            this.btnAdminPaymentDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnAdminPaymentDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminPaymentDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPaymentDelete.Location = new System.Drawing.Point(193, 3);
            this.btnAdminPaymentDelete.Name = "btnAdminPaymentDelete";
            this.btnAdminPaymentDelete.Size = new System.Drawing.Size(175, 34);
            this.btnAdminPaymentDelete.TabIndex = 4;
            this.btnAdminPaymentDelete.Text = "Delete";
            this.btnAdminPaymentDelete.UseVisualStyleBackColor = false;
            this.btnAdminPaymentDelete.Click += new System.EventHandler(this.btnAdminPaymentDelete_Click);
            // 
            // lblAdminPaymentId
            // 
            this.lblAdminPaymentId.AutoSize = true;
            this.lblAdminPaymentId.Location = new System.Drawing.Point(57, 24);
            this.lblAdminPaymentId.Name = "lblAdminPaymentId";
            this.lblAdminPaymentId.Size = new System.Drawing.Size(104, 20);
            this.lblAdminPaymentId.TabIndex = 0;
            this.lblAdminPaymentId.Text = "Payment ID : ";
            // 
            // lblAdminPaymentManage
            // 
            this.lblAdminPaymentManage.AutoSize = true;
            this.lblAdminPaymentManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminPaymentManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPaymentManage.Location = new System.Drawing.Point(755, 72);
            this.lblAdminPaymentManage.Name = "lblAdminPaymentManage";
            this.lblAdminPaymentManage.Size = new System.Drawing.Size(406, 50);
            this.lblAdminPaymentManage.TabIndex = 1;
            this.lblAdminPaymentManage.Text = "Manage Payments";
            this.lblAdminPaymentManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminPaymentInfo
            // 
            this.lblAdminPaymentInfo.AutoSize = true;
            this.lblAdminPaymentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminPaymentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPaymentInfo.Location = new System.Drawing.Point(4, 72);
            this.lblAdminPaymentInfo.Name = "lblAdminPaymentInfo";
            this.lblAdminPaymentInfo.Size = new System.Drawing.Size(744, 50);
            this.lblAdminPaymentInfo.TabIndex = 0;
            this.lblAdminPaymentInfo.Text = "Payment Info";
            this.lblAdminPaymentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAdminPaymentManage
            // 
            this.pnlAdminPaymentManage.Controls.Add(this.txtAdminPaymentBookingId);
            this.pnlAdminPaymentManage.Controls.Add(this.lblAdminPaymentBookingId);
            this.pnlAdminPaymentManage.Controls.Add(this.txtAdminPaymentPassengerId);
            this.pnlAdminPaymentManage.Controls.Add(this.lblAdminPaymentPassengerId);
            this.pnlAdminPaymentManage.Controls.Add(this.cmbAdminPaymentType);
            this.pnlAdminPaymentManage.Controls.Add(this.lblAdminPaymentType);
            this.pnlAdminPaymentManage.Controls.Add(this.rdbCancelled);
            this.pnlAdminPaymentManage.Controls.Add(this.rdbPending);
            this.pnlAdminPaymentManage.Controls.Add(this.rdbPaid);
            this.pnlAdminPaymentManage.Controls.Add(this.tableLayoutPanel2);
            this.pnlAdminPaymentManage.Controls.Add(this.lblAdminPaymentDate);
            this.pnlAdminPaymentManage.Controls.Add(this.dtpAdminPaymentDate);
            this.pnlAdminPaymentManage.Controls.Add(this.lblAdminPaymentStatus);
            this.pnlAdminPaymentManage.Controls.Add(this.txtAdminPaymentAmount);
            this.pnlAdminPaymentManage.Controls.Add(this.lblAdminPaymentAmount);
            this.pnlAdminPaymentManage.Controls.Add(this.txtAdminPaymentId);
            this.pnlAdminPaymentManage.Controls.Add(this.lblAdminPaymentId);
            this.pnlAdminPaymentManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminPaymentManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdminPaymentManage.Location = new System.Drawing.Point(755, 126);
            this.pnlAdminPaymentManage.Name = "pnlAdminPaymentManage";
            this.pnlAdminPaymentManage.Size = new System.Drawing.Size(406, 521);
            this.pnlAdminPaymentManage.TabIndex = 3;
            // 
            // cmbAdminPaymentType
            // 
            this.cmbAdminPaymentType.FormattingEnabled = true;
            this.cmbAdminPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Bkash",
            "Bank Transfer"});
            this.cmbAdminPaymentType.Location = new System.Drawing.Point(164, 201);
            this.cmbAdminPaymentType.Name = "cmbAdminPaymentType";
            this.cmbAdminPaymentType.Size = new System.Drawing.Size(222, 28);
            this.cmbAdminPaymentType.TabIndex = 33;
            // 
            // lblAdminPaymentType
            // 
            this.lblAdminPaymentType.AutoSize = true;
            this.lblAdminPaymentType.Location = new System.Drawing.Point(40, 204);
            this.lblAdminPaymentType.Name = "lblAdminPaymentType";
            this.lblAdminPaymentType.Size = new System.Drawing.Size(121, 20);
            this.lblAdminPaymentType.TabIndex = 32;
            this.lblAdminPaymentType.Text = "Payment Type : ";
            // 
            // txtPaymentSearch
            // 
            this.txtPaymentSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPaymentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentSearch.Location = new System.Drawing.Point(8, 11);
            this.txtPaymentSearch.Multiline = true;
            this.txtPaymentSearch.Name = "txtPaymentSearch";
            this.txtPaymentSearch.Size = new System.Drawing.Size(801, 42);
            this.txtPaymentSearch.TabIndex = 0;
            // 
            // btnPaymentSearch
            // 
            this.btnPaymentSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPaymentSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPaymentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentSearch.Location = new System.Drawing.Point(822, 11);
            this.btnPaymentSearch.Name = "btnPaymentSearch";
            this.btnPaymentSearch.Size = new System.Drawing.Size(154, 42);
            this.btnPaymentSearch.TabIndex = 1;
            this.btnPaymentSearch.Text = "Search";
            this.btnPaymentSearch.UseVisualStyleBackColor = false;
            this.btnPaymentSearch.Click += new System.EventHandler(this.btnPaymentSearch_Click);
            // 
            // btnPaymentRefresh
            // 
            this.btnPaymentRefresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPaymentRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPaymentRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentRefresh.Location = new System.Drawing.Point(987, 11);
            this.btnPaymentRefresh.Name = "btnPaymentRefresh";
            this.btnPaymentRefresh.Size = new System.Drawing.Size(154, 42);
            this.btnPaymentRefresh.TabIndex = 2;
            this.btnPaymentRefresh.Text = "Refresh";
            this.btnPaymentRefresh.UseVisualStyleBackColor = false;
            this.btnPaymentRefresh.Click += new System.EventHandler(this.btnPaymentRefresh_Click);
            // 
            // pnlPaymentSearch
            // 
            this.pnlPaymentSearch.ColumnCount = 7;
            this.tableLayoutPanel1.SetColumnSpan(this.pnlPaymentSearch, 2);
            this.pnlPaymentSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlPaymentSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.073F));
            this.pnlPaymentSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9269989F));
            this.pnlPaymentSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlPaymentSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlPaymentSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlPaymentSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.pnlPaymentSearch.Controls.Add(this.txtPaymentSearch, 1, 1);
            this.pnlPaymentSearch.Controls.Add(this.btnPaymentSearch, 3, 1);
            this.pnlPaymentSearch.Controls.Add(this.btnPaymentRefresh, 5, 1);
            this.pnlPaymentSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaymentSearch.Location = new System.Drawing.Point(4, 4);
            this.pnlPaymentSearch.Name = "pnlPaymentSearch";
            this.pnlPaymentSearch.RowCount = 3;
            this.pnlPaymentSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlPaymentSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlPaymentSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlPaymentSearch.Size = new System.Drawing.Size(1157, 64);
            this.pnlPaymentSearch.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 412F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPaymentSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminPaymentManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminPaymentInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlAdminPaymentManage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvAdminPayment, 0, 2);
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
            // txtAdminPaymentPassengerId
            // 
            this.txtAdminPaymentPassengerId.Location = new System.Drawing.Point(164, 88);
            this.txtAdminPaymentPassengerId.Name = "txtAdminPaymentPassengerId";
            this.txtAdminPaymentPassengerId.ReadOnly = true;
            this.txtAdminPaymentPassengerId.Size = new System.Drawing.Size(222, 26);
            this.txtAdminPaymentPassengerId.TabIndex = 35;
            // 
            // lblAdminPaymentPassengerId
            // 
            this.lblAdminPaymentPassengerId.AutoSize = true;
            this.lblAdminPaymentPassengerId.Location = new System.Drawing.Point(43, 91);
            this.lblAdminPaymentPassengerId.Name = "lblAdminPaymentPassengerId";
            this.lblAdminPaymentPassengerId.Size = new System.Drawing.Size(118, 20);
            this.lblAdminPaymentPassengerId.TabIndex = 34;
            this.lblAdminPaymentPassengerId.Text = "Passenger ID : ";
            // 
            // txtAdminPaymentBookingId
            // 
            this.txtAdminPaymentBookingId.Location = new System.Drawing.Point(164, 56);
            this.txtAdminPaymentBookingId.Name = "txtAdminPaymentBookingId";
            this.txtAdminPaymentBookingId.ReadOnly = true;
            this.txtAdminPaymentBookingId.Size = new System.Drawing.Size(222, 26);
            this.txtAdminPaymentBookingId.TabIndex = 37;
            // 
            // lblAdminPaymentBookingId
            // 
            this.lblAdminPaymentBookingId.AutoSize = true;
            this.lblAdminPaymentBookingId.Location = new System.Drawing.Point(60, 59);
            this.lblAdminPaymentBookingId.Name = "lblAdminPaymentBookingId";
            this.lblAdminPaymentBookingId.Size = new System.Drawing.Size(100, 20);
            this.lblAdminPaymentBookingId.TabIndex = 36;
            this.lblAdminPaymentBookingId.Text = "Booking ID : ";
            // 
            // AdminPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminPayment";
            this.Text = "AdminPayment";
            this.Load += new System.EventHandler(this.AdminPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPayment)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlAdminPaymentManage.ResumeLayout(false);
            this.pnlAdminPaymentManage.PerformLayout();
            this.pnlPaymentSearch.ResumeLayout(false);
            this.pnlPaymentSearch.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminPayment;
        private System.Windows.Forms.Label lblAdminPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpAdminPaymentDate;
        private System.Windows.Forms.Label lblAdminPaymentStatus;
        private System.Windows.Forms.TextBox txtAdminPaymentAmount;
        private System.Windows.Forms.Label lblAdminPaymentAmount;
        private System.Windows.Forms.TextBox txtAdminPaymentId;
        private System.Windows.Forms.Button btnAdminPaymentUpdate;
        private System.Windows.Forms.RadioButton rdbCancelled;
        private System.Windows.Forms.RadioButton rdbPending;
        private System.Windows.Forms.RadioButton rdbPaid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdminPaymentDelete;
        private System.Windows.Forms.Label lblAdminPaymentId;
        private System.Windows.Forms.Label lblAdminPaymentManage;
        private System.Windows.Forms.Label lblAdminPaymentInfo;
        private System.Windows.Forms.Panel pnlAdminPaymentManage;
        private System.Windows.Forms.TextBox txtPaymentSearch;
        private System.Windows.Forms.Button btnPaymentSearch;
        private System.Windows.Forms.Button btnPaymentRefresh;
        private System.Windows.Forms.TableLayoutPanel pnlPaymentSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbAdminPaymentType;
        private System.Windows.Forms.Label lblAdminPaymentType;
        private System.Windows.Forms.TextBox txtAdminPaymentPassengerId;
        private System.Windows.Forms.Label lblAdminPaymentPassengerId;
        private System.Windows.Forms.TextBox txtAdminPaymentBookingId;
        private System.Windows.Forms.Label lblAdminPaymentBookingId;
    }
}