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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 406F));
            this.tableLayoutPanel1.Controls.Add(this.lblAdminFlightManage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminFlightInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlAdminFlightManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvAdminFlight, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 576);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAdminFlightManage
            // 
            this.lblAdminFlightManage.AutoSize = true;
            this.lblAdminFlightManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminFlightManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminFlightManage.Location = new System.Drawing.Point(593, 1);
            this.lblAdminFlightManage.Name = "lblAdminFlightManage";
            this.lblAdminFlightManage.Size = new System.Drawing.Size(400, 50);
            this.lblAdminFlightManage.TabIndex = 1;
            this.lblAdminFlightManage.Text = "Manage Flights";
            this.lblAdminFlightManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminFlightInfo
            // 
            this.lblAdminFlightInfo.AutoSize = true;
            this.lblAdminFlightInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminFlightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminFlightInfo.Location = new System.Drawing.Point(4, 1);
            this.lblAdminFlightInfo.Name = "lblAdminFlightInfo";
            this.lblAdminFlightInfo.Size = new System.Drawing.Size(582, 50);
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
            this.pnlAdminFlightManage.Location = new System.Drawing.Point(593, 55);
            this.pnlAdminFlightManage.Name = "pnlAdminFlightManage";
            this.pnlAdminFlightManage.Size = new System.Drawing.Size(400, 517);
            this.pnlAdminFlightManage.TabIndex = 3;
            // 
            // rdbCancelled
            // 
            this.rdbCancelled.AutoSize = true;
            this.rdbCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCancelled.Location = new System.Drawing.Point(306, 174);
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
            this.rdbDelayed.Location = new System.Drawing.Point(221, 174);
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
            this.rdbOnTime.Location = new System.Drawing.Point(136, 174);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 298);
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
            // 
            // dtpAdminFlightArrivalTime
            // 
            this.dtpAdminFlightArrivalTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpAdminFlightArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdminFlightArrivalTime.Location = new System.Drawing.Point(140, 249);
            this.dtpAdminFlightArrivalTime.Name = "dtpAdminFlightArrivalTime";
            this.dtpAdminFlightArrivalTime.Size = new System.Drawing.Size(251, 26);
            this.dtpAdminFlightArrivalTime.TabIndex = 15;
            // 
            // lblAdminFlightDepartureTIme
            // 
            this.lblAdminFlightDepartureTIme.AutoSize = true;
            this.lblAdminFlightDepartureTIme.Location = new System.Drawing.Point(6, 213);
            this.lblAdminFlightDepartureTIme.Name = "lblAdminFlightDepartureTIme";
            this.lblAdminFlightDepartureTIme.Size = new System.Drawing.Size(131, 20);
            this.lblAdminFlightDepartureTIme.TabIndex = 14;
            this.lblAdminFlightDepartureTIme.Text = "Departure Time : ";
            // 
            // lblAdminFlightArrivalTime
            // 
            this.lblAdminFlightArrivalTime.AutoSize = true;
            this.lblAdminFlightArrivalTime.Location = new System.Drawing.Point(40, 252);
            this.lblAdminFlightArrivalTime.Name = "lblAdminFlightArrivalTime";
            this.lblAdminFlightArrivalTime.Size = new System.Drawing.Size(102, 20);
            this.lblAdminFlightArrivalTime.TabIndex = 13;
            this.lblAdminFlightArrivalTime.Text = "Arrival Time : ";
            // 
            // dtpAdminFlightDepartureTime
            // 
            this.dtpAdminFlightDepartureTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpAdminFlightDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdminFlightDepartureTime.Location = new System.Drawing.Point(140, 210);
            this.dtpAdminFlightDepartureTime.Name = "dtpAdminFlightDepartureTime";
            this.dtpAdminFlightDepartureTime.Size = new System.Drawing.Size(251, 26);
            this.dtpAdminFlightDepartureTime.TabIndex = 12;
            // 
            // lblAdminFlightStatus
            // 
            this.lblAdminFlightStatus.AutoSize = true;
            this.lblAdminFlightStatus.Location = new System.Drawing.Point(26, 174);
            this.lblAdminFlightStatus.Name = "lblAdminFlightStatus";
            this.lblAdminFlightStatus.Size = new System.Drawing.Size(111, 20);
            this.lblAdminFlightStatus.TabIndex = 10;
            this.lblAdminFlightStatus.Text = "Flight Status : ";
            // 
            // txtAdminFlightDestination
            // 
            this.txtAdminFlightDestination.Location = new System.Drawing.Point(140, 134);
            this.txtAdminFlightDestination.Name = "txtAdminFlightDestination";
            this.txtAdminFlightDestination.Size = new System.Drawing.Size(251, 26);
            this.txtAdminFlightDestination.TabIndex = 7;
            // 
            // lblAdminFlightDestination
            // 
            this.lblAdminFlightDestination.AutoSize = true;
            this.lblAdminFlightDestination.Location = new System.Drawing.Point(35, 137);
            this.lblAdminFlightDestination.Name = "lblAdminFlightDestination";
            this.lblAdminFlightDestination.Size = new System.Drawing.Size(102, 20);
            this.lblAdminFlightDestination.TabIndex = 6;
            this.lblAdminFlightDestination.Text = "Destination : ";
            // 
            // txtAdminFlightOrigin
            // 
            this.txtAdminFlightOrigin.Location = new System.Drawing.Point(140, 97);
            this.txtAdminFlightOrigin.Name = "txtAdminFlightOrigin";
            this.txtAdminFlightOrigin.Size = new System.Drawing.Size(251, 26);
            this.txtAdminFlightOrigin.TabIndex = 5;
            // 
            // lblAdminFlightOrigin
            // 
            this.lblAdminFlightOrigin.AutoSize = true;
            this.lblAdminFlightOrigin.Location = new System.Drawing.Point(75, 100);
            this.lblAdminFlightOrigin.Name = "lblAdminFlightOrigin";
            this.lblAdminFlightOrigin.Size = new System.Drawing.Size(62, 20);
            this.lblAdminFlightOrigin.TabIndex = 4;
            this.lblAdminFlightOrigin.Text = "Origin : ";
            // 
            // txtAdminFlightNo
            // 
            this.txtAdminFlightNo.Location = new System.Drawing.Point(140, 60);
            this.txtAdminFlightNo.Name = "txtAdminFlightNo";
            this.txtAdminFlightNo.Size = new System.Drawing.Size(251, 26);
            this.txtAdminFlightNo.TabIndex = 3;
            // 
            // lblAdminFlightNo
            // 
            this.lblAdminFlightNo.AutoSize = true;
            this.lblAdminFlightNo.Location = new System.Drawing.Point(54, 63);
            this.lblAdminFlightNo.Name = "lblAdminFlightNo";
            this.lblAdminFlightNo.Size = new System.Drawing.Size(84, 20);
            this.lblAdminFlightNo.TabIndex = 2;
            this.lblAdminFlightNo.Text = "Flight No : ";
            // 
            // txtAdminFlightId
            // 
            this.txtAdminFlightId.Location = new System.Drawing.Point(140, 23);
            this.txtAdminFlightId.Name = "txtAdminFlightId";
            this.txtAdminFlightId.ReadOnly = true;
            this.txtAdminFlightId.Size = new System.Drawing.Size(251, 26);
            this.txtAdminFlightId.TabIndex = 1;
            // 
            // lblAdminFlightId
            // 
            this.lblAdminFlightId.AutoSize = true;
            this.lblAdminFlightId.Location = new System.Drawing.Point(57, 26);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdminFlight.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdminFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminFlight.Location = new System.Drawing.Point(4, 55);
            this.dgvAdminFlight.Name = "dgvAdminFlight";
            this.dgvAdminFlight.ReadOnly = true;
            this.dgvAdminFlight.Size = new System.Drawing.Size(582, 517);
            this.dgvAdminFlight.TabIndex = 4;
            // 
            // AdminFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminFlightForm";
            this.Text = "AdminFlightForm";
            this.Load += new System.EventHandler(this.AdminFlightForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtAdminFlightId;
        private System.Windows.Forms.Label lblAdminFlightId;
        private System.Windows.Forms.Label lblAdminFlightStatus;
        private System.Windows.Forms.TextBox txtAdminFlightDestination;
        private System.Windows.Forms.Label lblAdminFlightDestination;
        private System.Windows.Forms.TextBox txtAdminFlightOrigin;
        private System.Windows.Forms.Label lblAdminFlightOrigin;
        private System.Windows.Forms.TextBox txtAdminFlightNo;
        private System.Windows.Forms.Label lblAdminFlightNo;
        private System.Windows.Forms.Label lblAdminFlightArrivalTime;
        private System.Windows.Forms.DateTimePicker dtpAdminFlightDepartureTime;
        private System.Windows.Forms.Label lblAdminFlightDepartureTIme;
        private System.Windows.Forms.DateTimePicker dtpAdminFlightArrivalTime;
        private System.Windows.Forms.DataGridView dgvAdminFlight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdminFlightAdd;
        private System.Windows.Forms.Button btnAdminFlightUpdate;
        private System.Windows.Forms.Button btnAdminFlightDelete;
        private System.Windows.Forms.RadioButton rdbDelayed;
        private System.Windows.Forms.RadioButton rdbOnTime;
        private System.Windows.Forms.RadioButton rdbCancelled;
    }
}