namespace Air_Ticket_Management_System.Passenger
{
    partial class PassengerRefund
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
            this.pnlRefundSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtRefundSearch = new System.Windows.Forms.TextBox();
            this.btnRefundSearch = new System.Windows.Forms.Button();
            this.btnRefundRefresh = new System.Windows.Forms.Button();
            this.lblPassengerRefundManage = new System.Windows.Forms.Label();
            this.lblPassengerRefundInfo = new System.Windows.Forms.Label();
            this.pnlPassengerRefundManage = new System.Windows.Forms.Panel();
            this.txtPassengerRefundPaymentId = new System.Windows.Forms.TextBox();
            this.lblPassengerRefundPaymentId = new System.Windows.Forms.Label();
            this.txtPassengerRefundPassengerId = new System.Windows.Forms.TextBox();
            this.lblPassengerRefundPassengerId = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPassengerRefundDate = new System.Windows.Forms.Label();
            this.dtpPassengerRefundDate = new System.Windows.Forms.DateTimePicker();
            this.txtPassengerRefundAmount = new System.Windows.Forms.TextBox();
            this.lblPassengerRefundAmount = new System.Windows.Forms.Label();
            this.txtPassengerRefundId = new System.Windows.Forms.TextBox();
            this.lblPassengerRefundId = new System.Windows.Forms.Label();
            this.dgvPassengerRefund = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPassengerRefundPay = new System.Windows.Forms.Button();
            this.pnlRefundSearch.SuspendLayout();
            this.pnlPassengerRefundManage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerRefund)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlRefundSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
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
            // txtRefundSearch
            // 
            this.txtRefundSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRefundSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefundSearch.Location = new System.Drawing.Point(8, 11);
            this.txtRefundSearch.Multiline = true;
            this.txtRefundSearch.Name = "txtRefundSearch";
            this.txtRefundSearch.Size = new System.Drawing.Size(799, 42);
            this.txtRefundSearch.TabIndex = 0;
            // 
            // btnRefundSearch
            // 
            this.btnRefundSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRefundSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefundSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefundSearch.Location = new System.Drawing.Point(820, 11);
            this.btnRefundSearch.Name = "btnRefundSearch";
            this.btnRefundSearch.Size = new System.Drawing.Size(154, 42);
            this.btnRefundSearch.TabIndex = 1;
            this.btnRefundSearch.Text = "Search";
            this.btnRefundSearch.UseVisualStyleBackColor = false;
            this.btnRefundSearch.Click += new System.EventHandler(this.btnRefundSearch_Click);
            // 
            // btnRefundRefresh
            // 
            this.btnRefundRefresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRefundRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefundRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefundRefresh.Location = new System.Drawing.Point(985, 11);
            this.btnRefundRefresh.Name = "btnRefundRefresh";
            this.btnRefundRefresh.Size = new System.Drawing.Size(154, 42);
            this.btnRefundRefresh.TabIndex = 2;
            this.btnRefundRefresh.Text = "Refresh";
            this.btnRefundRefresh.UseVisualStyleBackColor = false;
            this.btnRefundRefresh.Click += new System.EventHandler(this.btnRefundRefresh_Click);
            // 
            // lblPassengerRefundManage
            // 
            this.lblPassengerRefundManage.AutoSize = true;
            this.lblPassengerRefundManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassengerRefundManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerRefundManage.Location = new System.Drawing.Point(753, 72);
            this.lblPassengerRefundManage.Name = "lblPassengerRefundManage";
            this.lblPassengerRefundManage.Size = new System.Drawing.Size(408, 50);
            this.lblPassengerRefundManage.TabIndex = 1;
            this.lblPassengerRefundManage.Text = "Manage Refund";
            this.lblPassengerRefundManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassengerRefundInfo
            // 
            this.lblPassengerRefundInfo.AutoSize = true;
            this.lblPassengerRefundInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassengerRefundInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerRefundInfo.Location = new System.Drawing.Point(4, 72);
            this.lblPassengerRefundInfo.Name = "lblPassengerRefundInfo";
            this.lblPassengerRefundInfo.Size = new System.Drawing.Size(742, 50);
            this.lblPassengerRefundInfo.TabIndex = 0;
            this.lblPassengerRefundInfo.Text = "Refund Info";
            this.lblPassengerRefundInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPassengerRefundManage
            // 
            this.pnlPassengerRefundManage.Controls.Add(this.txtPassengerRefundPaymentId);
            this.pnlPassengerRefundManage.Controls.Add(this.lblPassengerRefundPaymentId);
            this.pnlPassengerRefundManage.Controls.Add(this.txtPassengerRefundPassengerId);
            this.pnlPassengerRefundManage.Controls.Add(this.lblPassengerRefundPassengerId);
            this.pnlPassengerRefundManage.Controls.Add(this.tableLayoutPanel2);
            this.pnlPassengerRefundManage.Controls.Add(this.lblPassengerRefundDate);
            this.pnlPassengerRefundManage.Controls.Add(this.dtpPassengerRefundDate);
            this.pnlPassengerRefundManage.Controls.Add(this.txtPassengerRefundAmount);
            this.pnlPassengerRefundManage.Controls.Add(this.lblPassengerRefundAmount);
            this.pnlPassengerRefundManage.Controls.Add(this.txtPassengerRefundId);
            this.pnlPassengerRefundManage.Controls.Add(this.lblPassengerRefundId);
            this.pnlPassengerRefundManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPassengerRefundManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPassengerRefundManage.Location = new System.Drawing.Point(753, 126);
            this.pnlPassengerRefundManage.Name = "pnlPassengerRefundManage";
            this.pnlPassengerRefundManage.Size = new System.Drawing.Size(408, 521);
            this.pnlPassengerRefundManage.TabIndex = 3;
            // 
            // txtPassengerRefundPaymentId
            // 
            this.txtPassengerRefundPaymentId.Location = new System.Drawing.Point(162, 62);
            this.txtPassengerRefundPaymentId.Name = "txtPassengerRefundPaymentId";
            this.txtPassengerRefundPaymentId.Size = new System.Drawing.Size(222, 26);
            this.txtPassengerRefundPaymentId.TabIndex = 37;
            // 
            // lblPassengerRefundPaymentId
            // 
            this.lblPassengerRefundPaymentId.AutoSize = true;
            this.lblPassengerRefundPaymentId.Location = new System.Drawing.Point(54, 65);
            this.lblPassengerRefundPaymentId.Name = "lblPassengerRefundPaymentId";
            this.lblPassengerRefundPaymentId.Size = new System.Drawing.Size(104, 20);
            this.lblPassengerRefundPaymentId.TabIndex = 36;
            this.lblPassengerRefundPaymentId.Text = "Payment ID : ";
            // 
            // txtPassengerRefundPassengerId
            // 
            this.txtPassengerRefundPassengerId.Location = new System.Drawing.Point(162, 94);
            this.txtPassengerRefundPassengerId.Name = "txtPassengerRefundPassengerId";
            this.txtPassengerRefundPassengerId.ReadOnly = true;
            this.txtPassengerRefundPassengerId.Size = new System.Drawing.Size(222, 26);
            this.txtPassengerRefundPassengerId.TabIndex = 35;
            // 
            // lblPassengerRefundPassengerId
            // 
            this.lblPassengerRefundPassengerId.AutoSize = true;
            this.lblPassengerRefundPassengerId.Location = new System.Drawing.Point(40, 97);
            this.lblPassengerRefundPassengerId.Name = "lblPassengerRefundPassengerId";
            this.lblPassengerRefundPassengerId.Size = new System.Drawing.Size(118, 20);
            this.lblPassengerRefundPassengerId.TabIndex = 34;
            this.lblPassengerRefundPassengerId.Text = "Passenger ID : ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnPassengerRefundPay, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(19, 253);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(371, 40);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // lblPassengerRefundDate
            // 
            this.lblPassengerRefundDate.AutoSize = true;
            this.lblPassengerRefundDate.Location = new System.Drawing.Point(45, 171);
            this.lblPassengerRefundDate.Name = "lblPassengerRefundDate";
            this.lblPassengerRefundDate.Size = new System.Drawing.Size(113, 20);
            this.lblPassengerRefundDate.TabIndex = 14;
            this.lblPassengerRefundDate.Text = "Refund Date : ";
            // 
            // dtpPassengerRefundDate
            // 
            this.dtpPassengerRefundDate.CustomFormat = "yyyy-MM-dd";
            this.dtpPassengerRefundDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPassengerRefundDate.Location = new System.Drawing.Point(162, 170);
            this.dtpPassengerRefundDate.Name = "dtpPassengerRefundDate";
            this.dtpPassengerRefundDate.Size = new System.Drawing.Size(222, 26);
            this.dtpPassengerRefundDate.TabIndex = 12;
            // 
            // txtPassengerRefundAmount
            // 
            this.txtPassengerRefundAmount.Location = new System.Drawing.Point(162, 129);
            this.txtPassengerRefundAmount.Name = "txtPassengerRefundAmount";
            this.txtPassengerRefundAmount.ReadOnly = true;
            this.txtPassengerRefundAmount.Size = new System.Drawing.Size(222, 26);
            this.txtPassengerRefundAmount.TabIndex = 3;
            // 
            // lblPassengerRefundAmount
            // 
            this.lblPassengerRefundAmount.AutoSize = true;
            this.lblPassengerRefundAmount.Location = new System.Drawing.Point(23, 132);
            this.lblPassengerRefundAmount.Name = "lblPassengerRefundAmount";
            this.lblPassengerRefundAmount.Size = new System.Drawing.Size(138, 20);
            this.lblPassengerRefundAmount.TabIndex = 2;
            this.lblPassengerRefundAmount.Text = "Refund Amount :  ";
            // 
            // txtPassengerRefundId
            // 
            this.txtPassengerRefundId.Location = new System.Drawing.Point(162, 27);
            this.txtPassengerRefundId.Name = "txtPassengerRefundId";
            this.txtPassengerRefundId.ReadOnly = true;
            this.txtPassengerRefundId.Size = new System.Drawing.Size(222, 26);
            this.txtPassengerRefundId.TabIndex = 1;
            // 
            // lblPassengerRefundId
            // 
            this.lblPassengerRefundId.AutoSize = true;
            this.lblPassengerRefundId.Location = new System.Drawing.Point(63, 30);
            this.lblPassengerRefundId.Name = "lblPassengerRefundId";
            this.lblPassengerRefundId.Size = new System.Drawing.Size(95, 20);
            this.lblPassengerRefundId.TabIndex = 0;
            this.lblPassengerRefundId.Text = "Refund ID : ";
            // 
            // dgvPassengerRefund
            // 
            this.dgvPassengerRefund.AllowUserToAddRows = false;
            this.dgvPassengerRefund.AllowUserToDeleteRows = false;
            this.dgvPassengerRefund.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPassengerRefund.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPassengerRefund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPassengerRefund.Location = new System.Drawing.Point(4, 126);
            this.dgvPassengerRefund.Name = "dgvPassengerRefund";
            this.dgvPassengerRefund.ReadOnly = true;
            this.dgvPassengerRefund.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengerRefund.Size = new System.Drawing.Size(742, 521);
            this.dgvPassengerRefund.TabIndex = 4;
            this.dgvPassengerRefund.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPassengerRefund_CellDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 414F));
            this.tableLayoutPanel1.Controls.Add(this.pnlRefundSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPassengerRefundManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPassengerRefundInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlPassengerRefundManage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvPassengerRefund, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1165, 651);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnPassengerRefundPay
            // 
            this.btnPassengerRefundPay.BackColor = System.Drawing.Color.LightBlue;
            this.btnPassengerRefundPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassengerRefundPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerRefundPay.Location = new System.Drawing.Point(3, 3);
            this.btnPassengerRefundPay.Name = "btnPassengerRefundPay";
            this.btnPassengerRefundPay.Size = new System.Drawing.Size(365, 34);
            this.btnPassengerRefundPay.TabIndex = 4;
            this.btnPassengerRefundPay.Text = "Request for a Refund";
            this.btnPassengerRefundPay.UseVisualStyleBackColor = false;
            this.btnPassengerRefundPay.Click += new System.EventHandler(this.btnPassengerRefundPay_Click);
            // 
            // PassengerRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PassengerRefund";
            this.Text = "PassengerRefund";
            this.Load += new System.EventHandler(this.PassengerRefund_Load);
            this.pnlRefundSearch.ResumeLayout(false);
            this.pnlRefundSearch.PerformLayout();
            this.pnlPassengerRefundManage.ResumeLayout(false);
            this.pnlPassengerRefundManage.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengerRefund)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlRefundSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPassengerRefundManage;
        private System.Windows.Forms.Label lblPassengerRefundInfo;
        private System.Windows.Forms.Panel pnlPassengerRefundManage;
        private System.Windows.Forms.TextBox txtPassengerRefundPaymentId;
        private System.Windows.Forms.Label lblPassengerRefundPaymentId;
        private System.Windows.Forms.TextBox txtPassengerRefundPassengerId;
        private System.Windows.Forms.Label lblPassengerRefundPassengerId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblPassengerRefundDate;
        private System.Windows.Forms.DateTimePicker dtpPassengerRefundDate;
        private System.Windows.Forms.TextBox txtPassengerRefundAmount;
        private System.Windows.Forms.Label lblPassengerRefundAmount;
        private System.Windows.Forms.TextBox txtPassengerRefundId;
        private System.Windows.Forms.Label lblPassengerRefundId;
        private System.Windows.Forms.DataGridView dgvPassengerRefund;
        private System.Windows.Forms.TextBox txtRefundSearch;
        private System.Windows.Forms.Button btnRefundSearch;
        private System.Windows.Forms.Button btnRefundRefresh;
        private System.Windows.Forms.Button btnPassengerRefundPay;
    }
}