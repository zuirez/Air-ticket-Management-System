namespace Air_Ticket_Management_System
{
    partial class AdminForm
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
            this.pnlAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAdminSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtAdminSearch = new System.Windows.Forms.TextBox();
            this.btnAdminSearch = new System.Windows.Forms.Button();
            this.lblAdminTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdminAdmin = new System.Windows.Forms.Button();
            this.btnAdminPayment = new System.Windows.Forms.Button();
            this.btnAdminPassenger = new System.Windows.Forms.Button();
            this.btnAdminReport = new System.Windows.Forms.Button();
            this.btnAdminEmployee = new System.Windows.Forms.Button();
            this.btnAdminBooking = new System.Windows.Forms.Button();
            this.btnAdminFlight = new System.Windows.Forms.Button();
            this.btnAdminSignOut = new System.Windows.Forms.Button();
            this.dgvAdminForm = new System.Windows.Forms.DataGridView();
            this.btnAdminRefresh = new System.Windows.Forms.Button();
            this.pnlAdmin.SuspendLayout();
            this.pnlAdminSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlAdmin.ColumnCount = 2;
            this.pnlAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.pnlAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlAdmin.Controls.Add(this.pnlAdminSearch, 1, 0);
            this.pnlAdmin.Controls.Add(this.lblAdminTitle, 0, 0);
            this.pnlAdmin.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.pnlAdmin.Controls.Add(this.dgvAdminForm, 1, 1);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.RowCount = 2;
            this.pnlAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.971098F));
            this.pnlAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0289F));
            this.pnlAdmin.Size = new System.Drawing.Size(1225, 692);
            this.pnlAdmin.TabIndex = 0;
            // 
            // pnlAdminSearch
            // 
            this.pnlAdminSearch.ColumnCount = 7;
            this.pnlAdminSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlAdminSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.073F));
            this.pnlAdminSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9269989F));
            this.pnlAdminSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlAdminSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.pnlAdminSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlAdminSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.pnlAdminSearch.Controls.Add(this.txtAdminSearch, 1, 1);
            this.pnlAdminSearch.Controls.Add(this.btnAdminSearch, 3, 1);
            this.pnlAdminSearch.Controls.Add(this.btnAdminRefresh, 5, 1);
            this.pnlAdminSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminSearch.Location = new System.Drawing.Point(208, 4);
            this.pnlAdminSearch.Name = "pnlAdminSearch";
            this.pnlAdminSearch.RowCount = 3;
            this.pnlAdminSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlAdminSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlAdminSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlAdminSearch.Size = new System.Drawing.Size(1013, 62);
            this.pnlAdminSearch.TabIndex = 0;
            // 
            // txtAdminSearch
            // 
            this.txtAdminSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdminSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminSearch.Location = new System.Drawing.Point(8, 11);
            this.txtAdminSearch.Multiline = true;
            this.txtAdminSearch.Name = "txtAdminSearch";
            this.txtAdminSearch.Size = new System.Drawing.Size(657, 40);
            this.txtAdminSearch.TabIndex = 0;
            // 
            // btnAdminSearch
            // 
            this.btnAdminSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdminSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSearch.Location = new System.Drawing.Point(677, 11);
            this.btnAdminSearch.Name = "btnAdminSearch";
            this.btnAdminSearch.Size = new System.Drawing.Size(154, 40);
            this.btnAdminSearch.TabIndex = 1;
            this.btnAdminSearch.Text = "Search";
            this.btnAdminSearch.UseVisualStyleBackColor = false;
            this.btnAdminSearch.Click += new System.EventHandler(this.btnAdminSearch_Click);
            // 
            // lblAdminTitle
            // 
            this.lblAdminTitle.AutoSize = true;
            this.lblAdminTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminTitle.Location = new System.Drawing.Point(4, 1);
            this.lblAdminTitle.Name = "lblAdminTitle";
            this.lblAdminTitle.Padding = new System.Windows.Forms.Padding(6, 20, 4, 20);
            this.lblAdminTitle.Size = new System.Drawing.Size(194, 68);
            this.lblAdminTitle.TabIndex = 1;
            this.lblAdminTitle.Text = "ADMIN PANEL";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdminAdmin, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminPayment, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminPassenger, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminReport, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminEmployee, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminBooking, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminFlight, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminSignOut, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(197, 615);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnAdminAdmin
            // 
            this.btnAdminAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAdmin.Location = new System.Drawing.Point(3, 103);
            this.btnAdminAdmin.Name = "btnAdminAdmin";
            this.btnAdminAdmin.Size = new System.Drawing.Size(191, 44);
            this.btnAdminAdmin.TabIndex = 9;
            this.btnAdminAdmin.Text = "Admin";
            this.btnAdminAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAdminPayment
            // 
            this.btnAdminPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPayment.Location = new System.Drawing.Point(3, 253);
            this.btnAdminPayment.Name = "btnAdminPayment";
            this.btnAdminPayment.Size = new System.Drawing.Size(191, 44);
            this.btnAdminPayment.TabIndex = 8;
            this.btnAdminPayment.Text = "Payment";
            this.btnAdminPayment.UseVisualStyleBackColor = true;
            // 
            // btnAdminPassenger
            // 
            this.btnAdminPassenger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPassenger.Location = new System.Drawing.Point(3, 203);
            this.btnAdminPassenger.Name = "btnAdminPassenger";
            this.btnAdminPassenger.Size = new System.Drawing.Size(191, 44);
            this.btnAdminPassenger.TabIndex = 7;
            this.btnAdminPassenger.Text = "Passenger";
            this.btnAdminPassenger.UseVisualStyleBackColor = true;
            // 
            // btnAdminReport
            // 
            this.btnAdminReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminReport.Location = new System.Drawing.Point(3, 303);
            this.btnAdminReport.Name = "btnAdminReport";
            this.btnAdminReport.Size = new System.Drawing.Size(191, 44);
            this.btnAdminReport.TabIndex = 5;
            this.btnAdminReport.Text = "Report";
            this.btnAdminReport.UseVisualStyleBackColor = true;
            // 
            // btnAdminEmployee
            // 
            this.btnAdminEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminEmployee.Location = new System.Drawing.Point(3, 153);
            this.btnAdminEmployee.Name = "btnAdminEmployee";
            this.btnAdminEmployee.Size = new System.Drawing.Size(191, 44);
            this.btnAdminEmployee.TabIndex = 2;
            this.btnAdminEmployee.Text = "Employee";
            this.btnAdminEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAdminBooking
            // 
            this.btnAdminBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminBooking.Location = new System.Drawing.Point(3, 53);
            this.btnAdminBooking.Name = "btnAdminBooking";
            this.btnAdminBooking.Size = new System.Drawing.Size(191, 44);
            this.btnAdminBooking.TabIndex = 1;
            this.btnAdminBooking.Text = "Booking";
            this.btnAdminBooking.UseVisualStyleBackColor = true;
            // 
            // btnAdminFlight
            // 
            this.btnAdminFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminFlight.Location = new System.Drawing.Point(3, 3);
            this.btnAdminFlight.Name = "btnAdminFlight";
            this.btnAdminFlight.Size = new System.Drawing.Size(191, 44);
            this.btnAdminFlight.TabIndex = 0;
            this.btnAdminFlight.Text = "Flight";
            this.btnAdminFlight.UseVisualStyleBackColor = true;
            // 
            // btnAdminSignOut
            // 
            this.btnAdminSignOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSignOut.Location = new System.Drawing.Point(3, 353);
            this.btnAdminSignOut.Name = "btnAdminSignOut";
            this.btnAdminSignOut.Size = new System.Drawing.Size(191, 44);
            this.btnAdminSignOut.TabIndex = 10;
            this.btnAdminSignOut.Text = "Sign Out";
            this.btnAdminSignOut.UseVisualStyleBackColor = true;
            // 
            // dgvAdminForm
            // 
            this.dgvAdminForm.AllowUserToAddRows = false;
            this.dgvAdminForm.AllowUserToDeleteRows = false;
            this.dgvAdminForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminForm.Location = new System.Drawing.Point(208, 73);
            this.dgvAdminForm.Name = "dgvAdminForm";
            this.dgvAdminForm.ReadOnly = true;
            this.dgvAdminForm.Size = new System.Drawing.Size(1013, 615);
            this.dgvAdminForm.TabIndex = 3;
            // 
            // btnAdminRefresh
            // 
            this.btnAdminRefresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdminRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminRefresh.Location = new System.Drawing.Point(846, 11);
            this.btnAdminRefresh.Name = "btnAdminRefresh";
            this.btnAdminRefresh.Size = new System.Drawing.Size(154, 40);
            this.btnAdminRefresh.TabIndex = 2;
            this.btnAdminRefresh.Text = "Refresh";
            this.btnAdminRefresh.UseVisualStyleBackColor = false;
            this.btnAdminRefresh.Click += new System.EventHandler(this.btnAdminRefresh_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 692);
            this.Controls.Add(this.pnlAdmin);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.pnlAdminSearch.ResumeLayout(false);
            this.pnlAdminSearch.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlAdmin;
        private System.Windows.Forms.TableLayoutPanel pnlAdminSearch;
        private System.Windows.Forms.TextBox txtAdminSearch;
        private System.Windows.Forms.Button btnAdminSearch;
        private System.Windows.Forms.Label lblAdminTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAdminFlight;
        private System.Windows.Forms.Button btnAdminEmployee;
        private System.Windows.Forms.Button btnAdminBooking;
        private System.Windows.Forms.Button btnAdminReport;
        private System.Windows.Forms.Button btnAdminPayment;
        private System.Windows.Forms.Button btnAdminPassenger;
        private System.Windows.Forms.Button btnAdminAdmin;
        private System.Windows.Forms.Button btnAdminSignOut;
        private System.Windows.Forms.DataGridView dgvAdminForm;
        private System.Windows.Forms.Button btnAdminRefresh;
    }
}