namespace Air_Ticket_Management_System.Passenger
{
    partial class PassengerPaymentForm
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
            this.txtPassengerPaymentBookingId = new System.Windows.Forms.TextBox();
            this.txtPassengerPaymentPassengerId = new System.Windows.Forms.TextBox();
            this.lblPassengerPaymentPassengerId = new System.Windows.Forms.Label();
            this.cmbPassengerPaymentType = new System.Windows.Forms.ComboBox();
            this.lblPassengerPaymentType = new System.Windows.Forms.Label();
            this.txtPaymentSearch = new System.Windows.Forms.TextBox();
            this.btnPaymentSearch = new System.Windows.Forms.Button();
            this.lblPassengerPaymentBookingId = new System.Windows.Forms.Label();
            this.rdbCancelled = new System.Windows.Forms.RadioButton();
            this.rdbPending = new System.Windows.Forms.RadioButton();
            this.rdbPaid = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPassengerPaymentPay = new System.Windows.Forms.Button();
            this.lblPassengerPaymentDate = new System.Windows.Forms.Label();
            this.dtpPassengerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPassengerPaymentStatus = new System.Windows.Forms.Label();
            this.txtPassengerPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblPassengerPaymentAmount = new System.Windows.Forms.Label();
            this.txtPassengerPaymentId = new System.Windows.Forms.TextBox();
            this.btnPaymentRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPaymentSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblPassengerPaymentManage = new System.Windows.Forms.Label();
            this.lblPassengerPaymentInfo = new System.Windows.Forms.Label();
            this.pnlPassengerPaymentManage = new System.Windows.Forms.Panel();
            this.lblPassengerPaymentId = new System.Windows.Forms.Label();
            this.dgvPassengerPayment = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPaymentSearch.SuspendLayout();
            this.pnlPassengerPaymentManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassengerPaymentBookingId
            // 
            this.txtPassengerPaymentBookingId.Location = new System.Drawing.Point(164, 56);
            this.txtPassengerPaymentBookingId.Name = "txtPassengerPaymentBookingId";
            this.txtPassengerPaymentBookingId.ReadOnly = true;
            this.txtPassengerPaymentBookingId.Size = new System.Drawing.Size(222, 26);
            this.txtPassengerPaymentBookingId.TabIndex = 37;
            // 
            // txtPassengerPaymentPassengerId
            // 
            this.txtPassengerPaymentPassengerId.Location = new System.Drawing.Point(164, 88);
            this.txtPassengerPaymentPassengerId.Name = "txtPassengerPaymentPassengerId";
            this.txtPassengerPaymentPassengerId.ReadOnly = true;
            this.txtPassengerPaymentPassengerId.Size = new System.Drawing.Size(222, 26);
            this.txtPassengerPaymentPassengerId.TabIndex = 35;
            // 
            // lblPassengerPaymentPassengerId
            // 
            this.lblPassengerPaymentPassengerId.AutoSize = true;
            this.lblPassengerPaymentPassengerId.Location = new System.Drawing.Point(43, 91);
            this.lblPassengerPaymentPassengerId.Name = "lblPassengerPaymentPassengerId";
            this.lblPassengerPaymentPassengerId.Size = new System.Drawing.Size(118, 20);
            this.lblPassengerPaymentPassengerId.TabIndex = 34;
            this.lblPassengerPaymentPassengerId.Text = "Passenger ID : ";
            // 
            // cmbPassengerPaymentType
            // 
            this.cmbPassengerPaymentType.FormattingEnabled = true;
            this.cmbPassengerPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Bkash",
            "Bank Transfer"});
            this.cmbPassengerPaymentType.Location = new System.Drawing.Point(164, 201);
            this.cmbPassengerPaymentType.Name = "cmbPassengerPaymentType";
            this.cmbPassengerPaymentType.Size = new System.Drawing.Size(222, 28);
            this.cmbPassengerPaymentType.TabIndex = 33;
            // 
            // lblPassengerPaymentType
            // 
            this.lblPassengerPaymentType.AutoSize = true;
            this.lblPassengerPaymentType.Location = new System.Drawing.Point(40, 204);
            this.lblPassengerPaymentType.Name = "lblPassengerPaymentType";
            this.lblPassengerPaymentType.Size = new System.Drawing.Size(121, 20);
            this.lblPassengerPaymentType.TabIndex = 32;
            this.lblPassengerPaymentType.Text = "Payment Type : ";
            // 
            // txtPaymentSearch
            // 
            this.txtPaymentSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPaymentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentSearch.Location = new System.Drawing.Point(8, 11);
            this.txtPaymentSearch.Multiline = true;
            this.txtPaymentSearch.Name = "txtPaymentSearch";
            this.txtPaymentSearch.Size = new System.Drawing.Size(800, 42);
            this.txtPaymentSearch.TabIndex = 0;
            // 
            // btnPaymentSearch
            // 
            this.btnPaymentSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPaymentSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPaymentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentSearch.Location = new System.Drawing.Point(821, 11);
            this.btnPaymentSearch.Name = "btnPaymentSearch";
            this.btnPaymentSearch.Size = new System.Drawing.Size(154, 42);
            this.btnPaymentSearch.TabIndex = 1;
            this.btnPaymentSearch.Text = "Search";
            this.btnPaymentSearch.UseVisualStyleBackColor = false;
            this.btnPaymentSearch.Click += new System.EventHandler(this.btnPaymentSearch_Click);
            // 
            // lblPassengerPaymentBookingId
            // 
            this.lblPassengerPaymentBookingId.AutoSize = true;
            this.lblPassengerPaymentBookingId.Location = new System.Drawing.Point(60, 59);
            this.lblPassengerPaymentBookingId.Name = "lblPassengerPaymentBookingId";
            this.lblPassengerPaymentBookingId.Size = new System.Drawing.Size(100, 20);
            this.lblPassengerPaymentBookingId.TabIndex = 36;
            this.lblPassengerPaymentBookingId.Text = "Booking ID : ";
            // 
            // rdbCancelled
            // 
            this.rdbCancelled.AutoSize = true;
            this.rdbCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCancelled.Location = new System.Drawing.Point(304, 244);
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
            this.rdbPending.Location = new System.Drawing.Point(222, 243);
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
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnPassengerPaymentPay, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(19, 300);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(371, 40);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // btnPassengerPaymentPay
            // 
            this.btnPassengerPaymentPay.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPassengerPaymentPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassengerPaymentPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerPaymentPay.Location = new System.Drawing.Point(3, 3);
            this.btnPassengerPaymentPay.Name = "btnPassengerPaymentPay";
            this.btnPassengerPaymentPay.Size = new System.Drawing.Size(365, 34);
            this.btnPassengerPaymentPay.TabIndex = 3;
            this.btnPassengerPaymentPay.Text = "Pay";
            this.btnPassengerPaymentPay.UseVisualStyleBackColor = false;
            this.btnPassengerPaymentPay.Click += new System.EventHandler(this.btnPassengerPaymentPay_Click);
            // 
            // lblPassengerPaymentDate
            // 
            this.lblPassengerPaymentDate.AutoSize = true;
            this.lblPassengerPaymentDate.Location = new System.Drawing.Point(39, 165);
            this.lblPassengerPaymentDate.Name = "lblPassengerPaymentDate";
            this.lblPassengerPaymentDate.Size = new System.Drawing.Size(122, 20);
            this.lblPassengerPaymentDate.TabIndex = 14;
            this.lblPassengerPaymentDate.Text = "Payment Date : ";
            // 
            // dtpPassengerPaymentDate
            // 
            this.dtpPassengerPaymentDate.CustomFormat = "yyyy-MM-dd";
            this.dtpPassengerPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPassengerPaymentDate.Location = new System.Drawing.Point(164, 164);
            this.dtpPassengerPaymentDate.Name = "dtpPassengerPaymentDate";
            this.dtpPassengerPaymentDate.Size = new System.Drawing.Size(222, 26);
            this.dtpPassengerPaymentDate.TabIndex = 12;
            // 
            // lblPassengerPaymentStatus
            // 
            this.lblPassengerPaymentStatus.AutoSize = true;
            this.lblPassengerPaymentStatus.Location = new System.Drawing.Point(27, 243);
            this.lblPassengerPaymentStatus.Name = "lblPassengerPaymentStatus";
            this.lblPassengerPaymentStatus.Size = new System.Drawing.Size(134, 20);
            this.lblPassengerPaymentStatus.TabIndex = 10;
            this.lblPassengerPaymentStatus.Text = "Payment Status : ";
            // 
            // txtPassengerPaymentAmount
            // 
            this.txtPassengerPaymentAmount.Location = new System.Drawing.Point(164, 123);
            this.txtPassengerPaymentAmount.Name = "txtPassengerPaymentAmount";
            this.txtPassengerPaymentAmount.ReadOnly = true;
            this.txtPassengerPaymentAmount.Size = new System.Drawing.Size(222, 26);
            this.txtPassengerPaymentAmount.TabIndex = 3;
            // 
            // lblPassengerPaymentAmount
            // 
            this.lblPassengerPaymentAmount.AutoSize = true;
            this.lblPassengerPaymentAmount.Location = new System.Drawing.Point(14, 126);
            this.lblPassengerPaymentAmount.Name = "lblPassengerPaymentAmount";
            this.lblPassengerPaymentAmount.Size = new System.Drawing.Size(147, 20);
            this.lblPassengerPaymentAmount.TabIndex = 2;
            this.lblPassengerPaymentAmount.Text = "Payment Amount :  ";
            // 
            // txtPassengerPaymentId
            // 
            this.txtPassengerPaymentId.Location = new System.Drawing.Point(164, 21);
            this.txtPassengerPaymentId.Name = "txtPassengerPaymentId";
            this.txtPassengerPaymentId.ReadOnly = true;
            this.txtPassengerPaymentId.Size = new System.Drawing.Size(222, 26);
            this.txtPassengerPaymentId.TabIndex = 1;
            // 
            // btnPaymentRefresh
            // 
            this.btnPaymentRefresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPaymentRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPaymentRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentRefresh.Location = new System.Drawing.Point(986, 11);
            this.btnPaymentRefresh.Name = "btnPaymentRefresh";
            this.btnPaymentRefresh.Size = new System.Drawing.Size(154, 42);
            this.btnPaymentRefresh.TabIndex = 2;
            this.btnPaymentRefresh.Text = "Refresh";
            this.btnPaymentRefresh.UseVisualStyleBackColor = false;
            this.btnPaymentRefresh.Click += new System.EventHandler(this.btnPaymentRefresh_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPaymentSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPassengerPaymentManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPassengerPaymentInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPassengerPaymentManage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvPassengerPayment, 0, 2);
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
            this.pnlPaymentSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
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
            // lblPassengerPaymentManage
            // 
            this.lblPassengerPaymentManage.AutoSize = true;
            this.lblPassengerPaymentManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassengerPaymentManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerPaymentManage.Location = new System.Drawing.Point(754, 72);
            this.lblPassengerPaymentManage.Name = "lblPassengerPaymentManage";
            this.lblPassengerPaymentManage.Size = new System.Drawing.Size(407, 50);
            this.lblPassengerPaymentManage.TabIndex = 1;
            this.lblPassengerPaymentManage.Text = "Manage Payments";
            this.lblPassengerPaymentManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassengerPaymentInfo
            // 
            this.lblPassengerPaymentInfo.AutoSize = true;
            this.lblPassengerPaymentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassengerPaymentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerPaymentInfo.Location = new System.Drawing.Point(4, 72);
            this.lblPassengerPaymentInfo.Name = "lblPassengerPaymentInfo";
            this.lblPassengerPaymentInfo.Size = new System.Drawing.Size(743, 50);
            this.lblPassengerPaymentInfo.TabIndex = 0;
            this.lblPassengerPaymentInfo.Text = "Payment Info";
            this.lblPassengerPaymentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPassengerPaymentManage
            // 
            this.pnlPassengerPaymentManage.Controls.Add(this.txtPassengerPaymentBookingId);
            this.pnlPassengerPaymentManage.Controls.Add(this.lblPassengerPaymentBookingId);
            this.pnlPassengerPaymentManage.Controls.Add(this.txtPassengerPaymentPassengerId);
            this.pnlPassengerPaymentManage.Controls.Add(this.lblPassengerPaymentPassengerId);
            this.pnlPassengerPaymentManage.Controls.Add(this.cmbPassengerPaymentType);
            this.pnlPassengerPaymentManage.Controls.Add(this.lblPassengerPaymentType);
            this.pnlPassengerPaymentManage.Controls.Add(this.rdbCancelled);
            this.pnlPassengerPaymentManage.Controls.Add(this.rdbPending);
            this.pnlPassengerPaymentManage.Controls.Add(this.rdbPaid);
            this.pnlPassengerPaymentManage.Controls.Add(this.tableLayoutPanel2);
            this.pnlPassengerPaymentManage.Controls.Add(this.lblPassengerPaymentDate);
            this.pnlPassengerPaymentManage.Controls.Add(this.dtpPassengerPaymentDate);
            this.pnlPassengerPaymentManage.Controls.Add(this.lblPassengerPaymentStatus);
            this.pnlPassengerPaymentManage.Controls.Add(this.txtPassengerPaymentAmount);
            this.pnlPassengerPaymentManage.Controls.Add(this.lblPassengerPaymentAmount);
            this.pnlPassengerPaymentManage.Controls.Add(this.txtPassengerPaymentId);
            this.pnlPassengerPaymentManage.Controls.Add(this.lblPassengerPaymentId);
            this.pnlPassengerPaymentManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPassengerPaymentManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPassengerPaymentManage.Location = new System.Drawing.Point(754, 126);
            this.pnlPassengerPaymentManage.Name = "pnlPassengerPaymentManage";
            this.pnlPassengerPaymentManage.Size = new System.Drawing.Size(407, 521);
            this.pnlPassengerPaymentManage.TabIndex = 3;
            // 
            // lblPassengerPaymentId
            // 
            this.lblPassengerPaymentId.AutoSize = true;
            this.lblPassengerPaymentId.Location = new System.Drawing.Point(57, 24);
            this.lblPassengerPaymentId.Name = "lblPassengerPaymentId";
            this.lblPassengerPaymentId.Size = new System.Drawing.Size(104, 20);
            this.lblPassengerPaymentId.TabIndex = 0;
            this.lblPassengerPaymentId.Text = "Payment ID : ";
            // 
            // dgvPassengerPayment
            // 
            this.dgvPassengerPayment.AllowUserToAddRows = false;
            this.dgvPassengerPayment.AllowUserToDeleteRows = false;
            this.dgvPassengerPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPassengerPayment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPassengerPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPassengerPayment.Location = new System.Drawing.Point(4, 126);
            this.dgvPassengerPayment.Name = "dgvPassengerPayment";
            this.dgvPassengerPayment.ReadOnly = true;
            this.dgvPassengerPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengerPayment.Size = new System.Drawing.Size(743, 521);
            this.dgvPassengerPayment.TabIndex = 4;
            this.dgvPassengerPayment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPassengerPayment_CellDoubleClick);
            // 
            // PassengerPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PassengerPaymentForm";
            this.Text = "PassengerPaymentForm";
            this.Load += new System.EventHandler(this.PassengerPaymentForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlPaymentSearch.ResumeLayout(false);
            this.pnlPaymentSearch.PerformLayout();
            this.pnlPassengerPaymentManage.ResumeLayout(false);
            this.pnlPassengerPaymentManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassengerPaymentBookingId;
        private System.Windows.Forms.TextBox txtPassengerPaymentPassengerId;
        private System.Windows.Forms.Label lblPassengerPaymentPassengerId;
        private System.Windows.Forms.ComboBox cmbPassengerPaymentType;
        private System.Windows.Forms.Label lblPassengerPaymentType;
        private System.Windows.Forms.TextBox txtPaymentSearch;
        private System.Windows.Forms.Button btnPaymentSearch;
        private System.Windows.Forms.Label lblPassengerPaymentBookingId;
        private System.Windows.Forms.RadioButton rdbCancelled;
        private System.Windows.Forms.RadioButton rdbPending;
        private System.Windows.Forms.RadioButton rdbPaid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnPassengerPaymentPay;
        private System.Windows.Forms.Label lblPassengerPaymentDate;
        private System.Windows.Forms.DateTimePicker dtpPassengerPaymentDate;
        private System.Windows.Forms.Label lblPassengerPaymentStatus;
        private System.Windows.Forms.TextBox txtPassengerPaymentAmount;
        private System.Windows.Forms.Label lblPassengerPaymentAmount;
        private System.Windows.Forms.TextBox txtPassengerPaymentId;
        private System.Windows.Forms.Button btnPaymentRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel pnlPaymentSearch;
        private System.Windows.Forms.Label lblPassengerPaymentManage;
        private System.Windows.Forms.Label lblPassengerPaymentInfo;
        private System.Windows.Forms.Panel pnlPassengerPaymentManage;
        private System.Windows.Forms.Label lblPassengerPaymentId;
        private System.Windows.Forms.DataGridView dgvPassengerPayment;
    }
}