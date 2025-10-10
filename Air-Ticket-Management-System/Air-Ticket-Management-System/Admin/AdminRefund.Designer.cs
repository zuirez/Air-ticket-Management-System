namespace Air_Ticket_Management_System
{
    partial class AdminRefund
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAdminRefundPaymentId = new System.Windows.Forms.TextBox();
            this.txtAdminRefundPassengerId = new System.Windows.Forms.TextBox();
            this.lblAdminRefundPassengerId = new System.Windows.Forms.Label();
            this.cmbAdminRefundType = new System.Windows.Forms.ComboBox();
            this.lblAdminRefundType = new System.Windows.Forms.Label();
            this.txtRefundSearch = new System.Windows.Forms.TextBox();
            this.btnRefundSearch = new System.Windows.Forms.Button();
            this.lblAdminRefundPaymentId = new System.Windows.Forms.Label();
            this.rdbCancelled = new System.Windows.Forms.RadioButton();
            this.rdbPending = new System.Windows.Forms.RadioButton();
            this.rdbPaid = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdminRefundUpdate = new System.Windows.Forms.Button();
            this.btnAdminRefundDelete = new System.Windows.Forms.Button();
            this.lblAdminRefundDate = new System.Windows.Forms.Label();
            this.dtpAdminRefundDate = new System.Windows.Forms.DateTimePicker();
            this.lblAdminPaymentStatus = new System.Windows.Forms.Label();
            this.txtAdminRefundAmount = new System.Windows.Forms.TextBox();
            this.lblAdminRefundAmount = new System.Windows.Forms.Label();
            this.txtAdminRefundId = new System.Windows.Forms.TextBox();
            this.btnRefundRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRefundSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblAdminRefundManage = new System.Windows.Forms.Label();
            this.lblAdminRefundInfo = new System.Windows.Forms.Label();
            this.pnlAdminRefundManage = new System.Windows.Forms.Panel();
            this.lblAdminRefundId = new System.Windows.Forms.Label();
            this.dgvAdminRefund = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlRefundSearch.SuspendLayout();
            this.pnlAdminRefundManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminRefund)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdminRefundPaymentId
            // 
            this.txtAdminRefundPaymentId.Location = new System.Drawing.Point(164, 56);
            this.txtAdminRefundPaymentId.Name = "txtAdminRefundPaymentId";
            this.txtAdminRefundPaymentId.ReadOnly = true;
            this.txtAdminRefundPaymentId.Size = new System.Drawing.Size(222, 26);
            this.txtAdminRefundPaymentId.TabIndex = 37;
            // 
            // txtAdminRefundPassengerId
            // 
            this.txtAdminRefundPassengerId.Location = new System.Drawing.Point(164, 88);
            this.txtAdminRefundPassengerId.Name = "txtAdminRefundPassengerId";
            this.txtAdminRefundPassengerId.ReadOnly = true;
            this.txtAdminRefundPassengerId.Size = new System.Drawing.Size(222, 26);
            this.txtAdminRefundPassengerId.TabIndex = 35;
            // 
            // lblAdminRefundPassengerId
            // 
            this.lblAdminRefundPassengerId.AutoSize = true;
            this.lblAdminRefundPassengerId.Location = new System.Drawing.Point(43, 91);
            this.lblAdminRefundPassengerId.Name = "lblAdminRefundPassengerId";
            this.lblAdminRefundPassengerId.Size = new System.Drawing.Size(118, 20);
            this.lblAdminRefundPassengerId.TabIndex = 34;
            this.lblAdminRefundPassengerId.Text = "Passenger ID : ";
            // 
            // cmbAdminRefundType
            // 
            this.cmbAdminRefundType.FormattingEnabled = true;
            this.cmbAdminRefundType.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Bkash",
            "Bank Transfer"});
            this.cmbAdminRefundType.Location = new System.Drawing.Point(164, 201);
            this.cmbAdminRefundType.Name = "cmbAdminRefundType";
            this.cmbAdminRefundType.Size = new System.Drawing.Size(222, 28);
            this.cmbAdminRefundType.TabIndex = 33;
            // 
            // lblAdminRefundType
            // 
            this.lblAdminRefundType.AutoSize = true;
            this.lblAdminRefundType.Location = new System.Drawing.Point(40, 204);
            this.lblAdminRefundType.Name = "lblAdminRefundType";
            this.lblAdminRefundType.Size = new System.Drawing.Size(121, 20);
            this.lblAdminRefundType.TabIndex = 32;
            this.lblAdminRefundType.Text = "Payment Type : ";
            // 
            // txtRefundSearch
            // 
            this.txtRefundSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRefundSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefundSearch.Location = new System.Drawing.Point(8, 11);
            this.txtRefundSearch.Multiline = true;
            this.txtRefundSearch.Name = "txtRefundSearch";
            this.txtRefundSearch.Size = new System.Drawing.Size(800, 42);
            this.txtRefundSearch.TabIndex = 0;
            // 
            // btnRefundSearch
            // 
            this.btnRefundSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRefundSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefundSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefundSearch.Location = new System.Drawing.Point(821, 11);
            this.btnRefundSearch.Name = "btnRefundSearch";
            this.btnRefundSearch.Size = new System.Drawing.Size(154, 42);
            this.btnRefundSearch.TabIndex = 1;
            this.btnRefundSearch.Text = "Search";
            this.btnRefundSearch.UseVisualStyleBackColor = false;
            this.btnRefundSearch.Click += new System.EventHandler(this.btnRefundSearch_Click);
            // 
            // lblAdminRefundPaymentId
            // 
            this.lblAdminRefundPaymentId.AutoSize = true;
            this.lblAdminRefundPaymentId.Location = new System.Drawing.Point(60, 59);
            this.lblAdminRefundPaymentId.Name = "lblAdminRefundPaymentId";
            this.lblAdminRefundPaymentId.Size = new System.Drawing.Size(104, 20);
            this.lblAdminRefundPaymentId.TabIndex = 36;
            this.lblAdminRefundPaymentId.Text = "Payment ID : ";
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
            this.tableLayoutPanel2.Controls.Add(this.btnAdminRefundUpdate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdminRefundDelete, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(19, 300);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(371, 40);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // btnAdminRefundUpdate
            // 
            this.btnAdminRefundUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdminRefundUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminRefundUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminRefundUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnAdminRefundUpdate.Name = "btnAdminRefundUpdate";
            this.btnAdminRefundUpdate.Size = new System.Drawing.Size(174, 34);
            this.btnAdminRefundUpdate.TabIndex = 3;
            this.btnAdminRefundUpdate.Text = "Update";
            this.btnAdminRefundUpdate.UseVisualStyleBackColor = false;
            this.btnAdminRefundUpdate.Click += new System.EventHandler(this.btnAdminRefundUpdate_Click);
            // 
            // btnAdminRefundDelete
            // 
            this.btnAdminRefundDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnAdminRefundDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminRefundDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminRefundDelete.Location = new System.Drawing.Point(193, 3);
            this.btnAdminRefundDelete.Name = "btnAdminRefundDelete";
            this.btnAdminRefundDelete.Size = new System.Drawing.Size(175, 34);
            this.btnAdminRefundDelete.TabIndex = 4;
            this.btnAdminRefundDelete.Text = "Delete";
            this.btnAdminRefundDelete.UseVisualStyleBackColor = false;
            this.btnAdminRefundDelete.Click += new System.EventHandler(this.btnAdminRefundDelete_Click);
            // 
            // lblAdminRefundDate
            // 
            this.lblAdminRefundDate.AutoSize = true;
            this.lblAdminRefundDate.Location = new System.Drawing.Point(39, 165);
            this.lblAdminRefundDate.Name = "lblAdminRefundDate";
            this.lblAdminRefundDate.Size = new System.Drawing.Size(122, 20);
            this.lblAdminRefundDate.TabIndex = 14;
            this.lblAdminRefundDate.Text = "Payment Date : ";
            // 
            // dtpAdminRefundDate
            // 
            this.dtpAdminRefundDate.CustomFormat = "yyyy-MM-dd";
            this.dtpAdminRefundDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdminRefundDate.Location = new System.Drawing.Point(164, 164);
            this.dtpAdminRefundDate.Name = "dtpAdminRefundDate";
            this.dtpAdminRefundDate.Size = new System.Drawing.Size(222, 26);
            this.dtpAdminRefundDate.TabIndex = 12;
            // 
            // lblAdminPaymentStatus
            // 
            this.lblAdminPaymentStatus.AutoSize = true;
            this.lblAdminPaymentStatus.Location = new System.Drawing.Point(27, 243);
            this.lblAdminPaymentStatus.Name = "lblAdminPaymentStatus";
            this.lblAdminPaymentStatus.Size = new System.Drawing.Size(125, 20);
            this.lblAdminPaymentStatus.TabIndex = 10;
            this.lblAdminPaymentStatus.Text = "Refund Status : ";
            // 
            // txtAdminRefundAmount
            // 
            this.txtAdminRefundAmount.Location = new System.Drawing.Point(164, 123);
            this.txtAdminRefundAmount.Name = "txtAdminRefundAmount";
            this.txtAdminRefundAmount.ReadOnly = true;
            this.txtAdminRefundAmount.Size = new System.Drawing.Size(222, 26);
            this.txtAdminRefundAmount.TabIndex = 3;
            // 
            // lblAdminRefundAmount
            // 
            this.lblAdminRefundAmount.AutoSize = true;
            this.lblAdminRefundAmount.Location = new System.Drawing.Point(14, 126);
            this.lblAdminRefundAmount.Name = "lblAdminRefundAmount";
            this.lblAdminRefundAmount.Size = new System.Drawing.Size(147, 20);
            this.lblAdminRefundAmount.TabIndex = 2;
            this.lblAdminRefundAmount.Text = "Payment Amount :  ";
            // 
            // txtAdminRefundId
            // 
            this.txtAdminRefundId.Location = new System.Drawing.Point(164, 21);
            this.txtAdminRefundId.Name = "txtAdminRefundId";
            this.txtAdminRefundId.ReadOnly = true;
            this.txtAdminRefundId.Size = new System.Drawing.Size(222, 26);
            this.txtAdminRefundId.TabIndex = 1;
            // 
            // btnRefundRefresh
            // 
            this.btnRefundRefresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRefundRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefundRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefundRefresh.Location = new System.Drawing.Point(986, 11);
            this.btnRefundRefresh.Name = "btnRefundRefresh";
            this.btnRefundRefresh.Size = new System.Drawing.Size(154, 42);
            this.btnRefundRefresh.TabIndex = 2;
            this.btnRefundRefresh.Text = "Refresh";
            this.btnRefundRefresh.UseVisualStyleBackColor = false;
            this.btnRefundRefresh.Click += new System.EventHandler(this.btnRefundRefresh_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.tableLayoutPanel1.Controls.Add(this.pnlRefundSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminRefundManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminRefundInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlAdminRefundManage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvAdminRefund, 0, 2);
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
            // pnlRefundSearch
            // 
            this.pnlRefundSearch.ColumnCount = 7;
            this.tableLayoutPanel1.SetColumnSpan(this.pnlRefundSearch, 2);
            this.pnlRefundSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlRefundSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.073F));
            this.pnlRefundSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9269989F));
            this.pnlRefundSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlRefundSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlRefundSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlRefundSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.pnlRefundSearch.Controls.Add(this.txtRefundSearch, 1, 1);
            this.pnlRefundSearch.Controls.Add(this.btnRefundSearch, 3, 1);
            this.pnlRefundSearch.Controls.Add(this.btnRefundRefresh, 5, 1);
            this.pnlRefundSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRefundSearch.Location = new System.Drawing.Point(4, 4);
            this.pnlRefundSearch.Name = "pnlRefundSearch";
            this.pnlRefundSearch.RowCount = 3;
            this.pnlRefundSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlRefundSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRefundSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlRefundSearch.Size = new System.Drawing.Size(1157, 64);
            this.pnlRefundSearch.TabIndex = 5;
            // 
            // lblAdminRefundManage
            // 
            this.lblAdminRefundManage.AutoSize = true;
            this.lblAdminRefundManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminRefundManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminRefundManage.Location = new System.Drawing.Point(754, 72);
            this.lblAdminRefundManage.Name = "lblAdminRefundManage";
            this.lblAdminRefundManage.Size = new System.Drawing.Size(407, 50);
            this.lblAdminRefundManage.TabIndex = 1;
            this.lblAdminRefundManage.Text = "Manage Refund";
            this.lblAdminRefundManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminRefundInfo
            // 
            this.lblAdminRefundInfo.AutoSize = true;
            this.lblAdminRefundInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminRefundInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminRefundInfo.Location = new System.Drawing.Point(4, 72);
            this.lblAdminRefundInfo.Name = "lblAdminRefundInfo";
            this.lblAdminRefundInfo.Size = new System.Drawing.Size(743, 50);
            this.lblAdminRefundInfo.TabIndex = 0;
            this.lblAdminRefundInfo.Text = "Refund Info";
            this.lblAdminRefundInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAdminRefundManage
            // 
            this.pnlAdminRefundManage.Controls.Add(this.txtAdminRefundPaymentId);
            this.pnlAdminRefundManage.Controls.Add(this.lblAdminRefundPaymentId);
            this.pnlAdminRefundManage.Controls.Add(this.txtAdminRefundPassengerId);
            this.pnlAdminRefundManage.Controls.Add(this.lblAdminRefundPassengerId);
            this.pnlAdminRefundManage.Controls.Add(this.cmbAdminRefundType);
            this.pnlAdminRefundManage.Controls.Add(this.lblAdminRefundType);
            this.pnlAdminRefundManage.Controls.Add(this.rdbCancelled);
            this.pnlAdminRefundManage.Controls.Add(this.rdbPending);
            this.pnlAdminRefundManage.Controls.Add(this.rdbPaid);
            this.pnlAdminRefundManage.Controls.Add(this.tableLayoutPanel2);
            this.pnlAdminRefundManage.Controls.Add(this.lblAdminRefundDate);
            this.pnlAdminRefundManage.Controls.Add(this.dtpAdminRefundDate);
            this.pnlAdminRefundManage.Controls.Add(this.lblAdminPaymentStatus);
            this.pnlAdminRefundManage.Controls.Add(this.txtAdminRefundAmount);
            this.pnlAdminRefundManage.Controls.Add(this.lblAdminRefundAmount);
            this.pnlAdminRefundManage.Controls.Add(this.txtAdminRefundId);
            this.pnlAdminRefundManage.Controls.Add(this.lblAdminRefundId);
            this.pnlAdminRefundManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminRefundManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdminRefundManage.Location = new System.Drawing.Point(754, 126);
            this.pnlAdminRefundManage.Name = "pnlAdminRefundManage";
            this.pnlAdminRefundManage.Size = new System.Drawing.Size(407, 521);
            this.pnlAdminRefundManage.TabIndex = 3;
            // 
            // lblAdminRefundId
            // 
            this.lblAdminRefundId.AutoSize = true;
            this.lblAdminRefundId.Location = new System.Drawing.Point(57, 24);
            this.lblAdminRefundId.Name = "lblAdminRefundId";
            this.lblAdminRefundId.Size = new System.Drawing.Size(95, 20);
            this.lblAdminRefundId.TabIndex = 0;
            this.lblAdminRefundId.Text = "Refund ID : ";
            // 
            // dgvAdminRefund
            // 
            this.dgvAdminRefund.AllowUserToAddRows = false;
            this.dgvAdminRefund.AllowUserToDeleteRows = false;
            this.dgvAdminRefund.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdminRefund.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAdminRefund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminRefund.Location = new System.Drawing.Point(4, 126);
            this.dgvAdminRefund.Name = "dgvAdminRefund";
            this.dgvAdminRefund.ReadOnly = true;
            this.dgvAdminRefund.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminRefund.Size = new System.Drawing.Size(743, 521);
            this.dgvAdminRefund.TabIndex = 4;
            // 
            // AdminRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminRefund";
            this.Text = "AdminRefund";
            this.Load += new System.EventHandler(this.AdminRefund_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlRefundSearch.ResumeLayout(false);
            this.pnlRefundSearch.PerformLayout();
            this.pnlAdminRefundManage.ResumeLayout(false);
            this.pnlAdminRefundManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminRefund)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdminRefundPaymentId;
        private System.Windows.Forms.TextBox txtAdminRefundPassengerId;
        private System.Windows.Forms.Label lblAdminRefundPassengerId;
        private System.Windows.Forms.ComboBox cmbAdminRefundType;
        private System.Windows.Forms.Label lblAdminRefundType;
        private System.Windows.Forms.TextBox txtRefundSearch;
        private System.Windows.Forms.Button btnRefundSearch;
        private System.Windows.Forms.Label lblAdminRefundPaymentId;
        private System.Windows.Forms.RadioButton rdbCancelled;
        private System.Windows.Forms.RadioButton rdbPending;
        private System.Windows.Forms.RadioButton rdbPaid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdminRefundUpdate;
        private System.Windows.Forms.Button btnAdminRefundDelete;
        private System.Windows.Forms.Label lblAdminRefundDate;
        private System.Windows.Forms.DateTimePicker dtpAdminRefundDate;
        private System.Windows.Forms.Label lblAdminPaymentStatus;
        private System.Windows.Forms.TextBox txtAdminRefundAmount;
        private System.Windows.Forms.Label lblAdminRefundAmount;
        private System.Windows.Forms.TextBox txtAdminRefundId;
        private System.Windows.Forms.Button btnRefundRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel pnlRefundSearch;
        private System.Windows.Forms.Label lblAdminRefundManage;
        private System.Windows.Forms.Label lblAdminRefundInfo;
        private System.Windows.Forms.Panel pnlAdminRefundManage;
        private System.Windows.Forms.Label lblAdminRefundId;
        private System.Windows.Forms.DataGridView dgvAdminRefund;
    }
}