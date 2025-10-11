namespace Air_Ticket_Management_System.Employee
{
    partial class EmployeeForm
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
            this.btnEmployeeFlight = new System.Windows.Forms.Button();
            this.pnlEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEmployeeRefund = new System.Windows.Forms.Button();
            this.btnEmployeePayment = new System.Windows.Forms.Button();
            this.btnEmployeeBooking = new System.Windows.Forms.Button();
            this.btnEmployeeSignOut = new System.Windows.Forms.Button();
            this.lblEmployeePanelText = new System.Windows.Forms.Label();
            this.pnlEmployeeShowInfo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEmployee.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmployeeFlight
            // 
            this.btnEmployeeFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployeeFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeFlight.Location = new System.Drawing.Point(3, 73);
            this.btnEmployeeFlight.Name = "btnEmployeeFlight";
            this.btnEmployeeFlight.Size = new System.Drawing.Size(154, 44);
            this.btnEmployeeFlight.TabIndex = 0;
            this.btnEmployeeFlight.Text = "Flight";
            this.btnEmployeeFlight.UseVisualStyleBackColor = true;
            this.btnEmployeeFlight.Click += new System.EventHandler(this.btnEmployeeFlight_Click);
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlEmployee.ColumnCount = 2;
            this.pnlEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.pnlEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlEmployee.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.pnlEmployee.Controls.Add(this.pnlEmployeeShowInfo, 1, 0);
            this.pnlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployee.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.RowCount = 1;
            this.pnlEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlEmployee.Size = new System.Drawing.Size(1356, 698);
            this.pnlEmployee.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnEmployeeRefund, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnEmployeePayment, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEmployeeBooking, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEmployeeFlight, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEmployeeSignOut, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeePanelText, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(160, 690);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnEmployeeRefund
            // 
            this.btnEmployeeRefund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployeeRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeRefund.Location = new System.Drawing.Point(3, 223);
            this.btnEmployeeRefund.Name = "btnEmployeeRefund";
            this.btnEmployeeRefund.Size = new System.Drawing.Size(154, 44);
            this.btnEmployeeRefund.TabIndex = 12;
            this.btnEmployeeRefund.Text = "Refund";
            this.btnEmployeeRefund.UseVisualStyleBackColor = true;
            this.btnEmployeeRefund.Click += new System.EventHandler(this.btnEmployeeRefund_Click);
            // 
            // btnEmployeePayment
            // 
            this.btnEmployeePayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployeePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeePayment.Location = new System.Drawing.Point(3, 173);
            this.btnEmployeePayment.Name = "btnEmployeePayment";
            this.btnEmployeePayment.Size = new System.Drawing.Size(154, 44);
            this.btnEmployeePayment.TabIndex = 8;
            this.btnEmployeePayment.Text = "Payment";
            this.btnEmployeePayment.UseVisualStyleBackColor = true;
            this.btnEmployeePayment.Click += new System.EventHandler(this.btnEmployeePayment_Click);
            // 
            // btnEmployeeBooking
            // 
            this.btnEmployeeBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployeeBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeBooking.Location = new System.Drawing.Point(3, 123);
            this.btnEmployeeBooking.Name = "btnEmployeeBooking";
            this.btnEmployeeBooking.Size = new System.Drawing.Size(154, 44);
            this.btnEmployeeBooking.TabIndex = 1;
            this.btnEmployeeBooking.Text = "Booking";
            this.btnEmployeeBooking.UseVisualStyleBackColor = true;
            this.btnEmployeeBooking.Click += new System.EventHandler(this.btnEmployeeBooking_Click);
            // 
            // btnEmployeeSignOut
            // 
            this.btnEmployeeSignOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployeeSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeSignOut.Location = new System.Drawing.Point(3, 273);
            this.btnEmployeeSignOut.Name = "btnEmployeeSignOut";
            this.btnEmployeeSignOut.Size = new System.Drawing.Size(154, 44);
            this.btnEmployeeSignOut.TabIndex = 10;
            this.btnEmployeeSignOut.Text = "Sign Out";
            this.btnEmployeeSignOut.UseVisualStyleBackColor = true;
            this.btnEmployeeSignOut.Click += new System.EventHandler(this.btnEmployeeSignOut_Click);
            // 
            // lblEmployeePanelText
            // 
            this.lblEmployeePanelText.AutoSize = true;
            this.lblEmployeePanelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmployeePanelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePanelText.Location = new System.Drawing.Point(3, 0);
            this.lblEmployeePanelText.Name = "lblEmployeePanelText";
            this.lblEmployeePanelText.Size = new System.Drawing.Size(154, 70);
            this.lblEmployeePanelText.TabIndex = 11;
            this.lblEmployeePanelText.Text = "EMPLOYEE PANEL";
            this.lblEmployeePanelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEmployeeShowInfo
            // 
            this.pnlEmployeeShowInfo.ColumnCount = 1;
            this.pnlEmployeeShowInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlEmployeeShowInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployeeShowInfo.Location = new System.Drawing.Point(171, 4);
            this.pnlEmployeeShowInfo.Name = "pnlEmployeeShowInfo";
            this.pnlEmployeeShowInfo.RowCount = 1;
            this.pnlEmployeeShowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlEmployeeShowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 690F));
            this.pnlEmployeeShowInfo.Size = new System.Drawing.Size(1181, 690);
            this.pnlEmployeeShowInfo.TabIndex = 3;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 698);
            this.Controls.Add(this.pnlEmployee);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeForm_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.pnlEmployee.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeFlight;
        private System.Windows.Forms.TableLayoutPanel pnlEmployee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEmployeeRefund;
        private System.Windows.Forms.Button btnEmployeePayment;
        private System.Windows.Forms.Button btnEmployeeBooking;
        private System.Windows.Forms.Button btnEmployeeSignOut;
        private System.Windows.Forms.Label lblEmployeePanelText;
        private System.Windows.Forms.TableLayoutPanel pnlEmployeeShowInfo;
    }
}