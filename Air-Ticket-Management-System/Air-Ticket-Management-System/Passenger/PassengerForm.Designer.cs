namespace Air_Ticket_Management_System.Passenger
{
    partial class PassengerForm
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
            this.pnlPassenger = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPassengerRefund = new System.Windows.Forms.Button();
            this.btnPassengerPayment = new System.Windows.Forms.Button();
            this.btnPassengerBooking = new System.Windows.Forms.Button();
            this.btnPassengerFlight = new System.Windows.Forms.Button();
            this.btnPassengerSignOut = new System.Windows.Forms.Button();
            this.lblPassengerPanelText = new System.Windows.Forms.Label();
            this.pnlPassengerShowInfo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPassenger.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPassenger
            // 
            this.pnlPassenger.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlPassenger.ColumnCount = 2;
            this.pnlPassenger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.pnlPassenger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlPassenger.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.pnlPassenger.Controls.Add(this.pnlPassengerShowInfo, 1, 0);
            this.pnlPassenger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPassenger.Location = new System.Drawing.Point(0, 0);
            this.pnlPassenger.Name = "pnlPassenger";
            this.pnlPassenger.RowCount = 1;
            this.pnlPassenger.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlPassenger.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlPassenger.Size = new System.Drawing.Size(1356, 698);
            this.pnlPassenger.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnPassengerRefund, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnPassengerPayment, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPassengerBooking, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPassengerFlight, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPassengerSignOut, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPassengerPanelText, 0, 0);
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
            // btnPassengerRefund
            // 
            this.btnPassengerRefund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassengerRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerRefund.Location = new System.Drawing.Point(3, 223);
            this.btnPassengerRefund.Name = "btnPassengerRefund";
            this.btnPassengerRefund.Size = new System.Drawing.Size(154, 44);
            this.btnPassengerRefund.TabIndex = 12;
            this.btnPassengerRefund.Text = "Refund";
            this.btnPassengerRefund.UseVisualStyleBackColor = true;
            this.btnPassengerRefund.Click += new System.EventHandler(this.btnPassengerRefund_Click);
            // 
            // btnPassengerPayment
            // 
            this.btnPassengerPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassengerPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerPayment.Location = new System.Drawing.Point(3, 173);
            this.btnPassengerPayment.Name = "btnPassengerPayment";
            this.btnPassengerPayment.Size = new System.Drawing.Size(154, 44);
            this.btnPassengerPayment.TabIndex = 8;
            this.btnPassengerPayment.Text = "Payment";
            this.btnPassengerPayment.UseVisualStyleBackColor = true;
            this.btnPassengerPayment.Click += new System.EventHandler(this.btnPassengerPayment_Click);
            // 
            // btnPassengerBooking
            // 
            this.btnPassengerBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassengerBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerBooking.Location = new System.Drawing.Point(3, 123);
            this.btnPassengerBooking.Name = "btnPassengerBooking";
            this.btnPassengerBooking.Size = new System.Drawing.Size(154, 44);
            this.btnPassengerBooking.TabIndex = 1;
            this.btnPassengerBooking.Text = "Booking";
            this.btnPassengerBooking.UseVisualStyleBackColor = true;
            this.btnPassengerBooking.Click += new System.EventHandler(this.btnPassengerBooking_Click);
            // 
            // btnPassengerFlight
            // 
            this.btnPassengerFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassengerFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerFlight.Location = new System.Drawing.Point(3, 73);
            this.btnPassengerFlight.Name = "btnPassengerFlight";
            this.btnPassengerFlight.Size = new System.Drawing.Size(154, 44);
            this.btnPassengerFlight.TabIndex = 0;
            this.btnPassengerFlight.Text = "Flight";
            this.btnPassengerFlight.UseVisualStyleBackColor = true;
            this.btnPassengerFlight.Click += new System.EventHandler(this.btnPassengerFlight_Click);
            // 
            // btnPassengerSignOut
            // 
            this.btnPassengerSignOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassengerSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerSignOut.Location = new System.Drawing.Point(3, 273);
            this.btnPassengerSignOut.Name = "btnPassengerSignOut";
            this.btnPassengerSignOut.Size = new System.Drawing.Size(154, 44);
            this.btnPassengerSignOut.TabIndex = 10;
            this.btnPassengerSignOut.Text = "Sign Out";
            this.btnPassengerSignOut.UseVisualStyleBackColor = true;
            this.btnPassengerSignOut.Click += new System.EventHandler(this.btnPassengerSignOut_Click);
            // 
            // lblPassengerPanelText
            // 
            this.lblPassengerPanelText.AutoSize = true;
            this.lblPassengerPanelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassengerPanelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerPanelText.Location = new System.Drawing.Point(3, 0);
            this.lblPassengerPanelText.Name = "lblPassengerPanelText";
            this.lblPassengerPanelText.Size = new System.Drawing.Size(154, 70);
            this.lblPassengerPanelText.TabIndex = 11;
            this.lblPassengerPanelText.Text = "PASSENGER PANEL";
            this.lblPassengerPanelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPassengerShowInfo
            // 
            this.pnlPassengerShowInfo.ColumnCount = 1;
            this.pnlPassengerShowInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlPassengerShowInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPassengerShowInfo.Location = new System.Drawing.Point(171, 4);
            this.pnlPassengerShowInfo.Name = "pnlPassengerShowInfo";
            this.pnlPassengerShowInfo.RowCount = 1;
            this.pnlPassengerShowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlPassengerShowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 690F));
            this.pnlPassengerShowInfo.Size = new System.Drawing.Size(1181, 690);
            this.pnlPassengerShowInfo.TabIndex = 3;
            // 
            // PassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 698);
            this.Controls.Add(this.pnlPassenger);
            this.Name = "PassengerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassengerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PassengerForm_FormClosed);
            this.Load += new System.EventHandler(this.PassengerForm_Load);
            this.pnlPassenger.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlPassenger;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPassengerRefund;
        private System.Windows.Forms.Button btnPassengerPayment;
        private System.Windows.Forms.Button btnPassengerBooking;
        private System.Windows.Forms.Button btnPassengerFlight;
        private System.Windows.Forms.Button btnPassengerSignOut;
        private System.Windows.Forms.Label lblPassengerPanelText;
        private System.Windows.Forms.TableLayoutPanel pnlPassengerShowInfo;
    }
}