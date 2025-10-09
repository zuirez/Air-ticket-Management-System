namespace Air_Ticket_Management_System
{
    partial class AdminPassenger
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
            this.dgvAdminPassenger = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdminPassengerAdd = new System.Windows.Forms.Button();
            this.btnAdminPassengerUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdminPassengerDelete = new System.Windows.Forms.Button();
            this.lblAdminPassengerManage = new System.Windows.Forms.Label();
            this.lblAdminPassengerInfo = new System.Windows.Forms.Label();
            this.pnlAdminPassengerManage = new System.Windows.Forms.Panel();
            this.txtAdminPassengerUserId = new System.Windows.Forms.TextBox();
            this.lblAdminPassengerUserId = new System.Windows.Forms.Label();
            this.rdbAdminPassengerFemale = new System.Windows.Forms.RadioButton();
            this.rdbAdminPassengerMale = new System.Windows.Forms.RadioButton();
            this.lblAdminPassengerGender = new System.Windows.Forms.Label();
            this.txtAdminPassengerAddress = new System.Windows.Forms.TextBox();
            this.lblAdminPassengerAddress = new System.Windows.Forms.Label();
            this.txtAdminPassengerEmail = new System.Windows.Forms.TextBox();
            this.lblAdminPassengerEmail = new System.Windows.Forms.Label();
            this.txtAdminPassengerPassword = new System.Windows.Forms.TextBox();
            this.lblAdminPassengerPassword = new System.Windows.Forms.Label();
            this.txtAdminPassengerUserName = new System.Windows.Forms.TextBox();
            this.lblAdminPassengerUserName = new System.Windows.Forms.Label();
            this.txtPassengerSearch = new System.Windows.Forms.TextBox();
            this.btnPassengerSearch = new System.Windows.Forms.Button();
            this.btnPassengerRefresh = new System.Windows.Forms.Button();
            this.pnlPassengerSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPassenger)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlAdminPassengerManage.SuspendLayout();
            this.pnlPassengerSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdminPassenger
            // 
            this.dgvAdminPassenger.AllowUserToAddRows = false;
            this.dgvAdminPassenger.AllowUserToDeleteRows = false;
            this.dgvAdminPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdminPassenger.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdminPassenger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminPassenger.Location = new System.Drawing.Point(4, 126);
            this.dgvAdminPassenger.Name = "dgvAdminPassenger";
            this.dgvAdminPassenger.ReadOnly = true;
            this.dgvAdminPassenger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminPassenger.Size = new System.Drawing.Size(745, 521);
            this.dgvAdminPassenger.TabIndex = 4;
            this.dgvAdminPassenger.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminPassenger_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(123, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 34);
            this.panel2.TabIndex = 1;
            // 
            // btnAdminPassengerAdd
            // 
            this.btnAdminPassengerAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdminPassengerAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminPassengerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPassengerAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdminPassengerAdd.Name = "btnAdminPassengerAdd";
            this.btnAdminPassengerAdd.Size = new System.Drawing.Size(114, 34);
            this.btnAdminPassengerAdd.TabIndex = 2;
            this.btnAdminPassengerAdd.Text = "Add";
            this.btnAdminPassengerAdd.UseVisualStyleBackColor = false;
            this.btnAdminPassengerAdd.Click += new System.EventHandler(this.btnAdminPassengerAdd_Click);
            // 
            // btnAdminPassengerUpdate
            // 
            this.btnAdminPassengerUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdminPassengerUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminPassengerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPassengerUpdate.Location = new System.Drawing.Point(130, 3);
            this.btnAdminPassengerUpdate.Name = "btnAdminPassengerUpdate";
            this.btnAdminPassengerUpdate.Size = new System.Drawing.Size(114, 34);
            this.btnAdminPassengerUpdate.TabIndex = 3;
            this.btnAdminPassengerUpdate.Text = "Update";
            this.btnAdminPassengerUpdate.UseVisualStyleBackColor = false;
            this.btnAdminPassengerUpdate.Click += new System.EventHandler(this.btnAdminPassengerUpdate_Click);
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
            this.tableLayoutPanel2.Controls.Add(this.btnAdminPassengerAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdminPassengerUpdate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdminPassengerDelete, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 324);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 40);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // btnAdminPassengerDelete
            // 
            this.btnAdminPassengerDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnAdminPassengerDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminPassengerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPassengerDelete.Location = new System.Drawing.Point(257, 3);
            this.btnAdminPassengerDelete.Name = "btnAdminPassengerDelete";
            this.btnAdminPassengerDelete.Size = new System.Drawing.Size(114, 34);
            this.btnAdminPassengerDelete.TabIndex = 4;
            this.btnAdminPassengerDelete.Text = "Delete";
            this.btnAdminPassengerDelete.UseVisualStyleBackColor = false;
            this.btnAdminPassengerDelete.Click += new System.EventHandler(this.btnAdminPassengerDelete_Click);
            // 
            // lblAdminPassengerManage
            // 
            this.lblAdminPassengerManage.AutoSize = true;
            this.lblAdminPassengerManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminPassengerManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassengerManage.Location = new System.Drawing.Point(756, 72);
            this.lblAdminPassengerManage.Name = "lblAdminPassengerManage";
            this.lblAdminPassengerManage.Size = new System.Drawing.Size(405, 50);
            this.lblAdminPassengerManage.TabIndex = 1;
            this.lblAdminPassengerManage.Text = "Manage Passengers";
            this.lblAdminPassengerManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminPassengerInfo
            // 
            this.lblAdminPassengerInfo.AutoSize = true;
            this.lblAdminPassengerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminPassengerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassengerInfo.Location = new System.Drawing.Point(4, 72);
            this.lblAdminPassengerInfo.Name = "lblAdminPassengerInfo";
            this.lblAdminPassengerInfo.Size = new System.Drawing.Size(745, 50);
            this.lblAdminPassengerInfo.TabIndex = 0;
            this.lblAdminPassengerInfo.Text = "Passenger Info";
            this.lblAdminPassengerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAdminPassengerManage
            // 
            this.pnlAdminPassengerManage.Controls.Add(this.txtAdminPassengerUserId);
            this.pnlAdminPassengerManage.Controls.Add(this.lblAdminPassengerUserId);
            this.pnlAdminPassengerManage.Controls.Add(this.rdbAdminPassengerFemale);
            this.pnlAdminPassengerManage.Controls.Add(this.rdbAdminPassengerMale);
            this.pnlAdminPassengerManage.Controls.Add(this.lblAdminPassengerGender);
            this.pnlAdminPassengerManage.Controls.Add(this.txtAdminPassengerAddress);
            this.pnlAdminPassengerManage.Controls.Add(this.lblAdminPassengerAddress);
            this.pnlAdminPassengerManage.Controls.Add(this.txtAdminPassengerEmail);
            this.pnlAdminPassengerManage.Controls.Add(this.lblAdminPassengerEmail);
            this.pnlAdminPassengerManage.Controls.Add(this.txtAdminPassengerPassword);
            this.pnlAdminPassengerManage.Controls.Add(this.lblAdminPassengerPassword);
            this.pnlAdminPassengerManage.Controls.Add(this.txtAdminPassengerUserName);
            this.pnlAdminPassengerManage.Controls.Add(this.lblAdminPassengerUserName);
            this.pnlAdminPassengerManage.Controls.Add(this.tableLayoutPanel2);
            this.pnlAdminPassengerManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminPassengerManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdminPassengerManage.Location = new System.Drawing.Point(756, 126);
            this.pnlAdminPassengerManage.Name = "pnlAdminPassengerManage";
            this.pnlAdminPassengerManage.Size = new System.Drawing.Size(405, 521);
            this.pnlAdminPassengerManage.TabIndex = 3;
            // 
            // txtAdminPassengerUserId
            // 
            this.txtAdminPassengerUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPassengerUserId.Location = new System.Drawing.Point(130, 26);
            this.txtAdminPassengerUserId.Multiline = true;
            this.txtAdminPassengerUserId.Name = "txtAdminPassengerUserId";
            this.txtAdminPassengerUserId.ReadOnly = true;
            this.txtAdminPassengerUserId.Size = new System.Drawing.Size(225, 30);
            this.txtAdminPassengerUserId.TabIndex = 44;
            // 
            // lblAdminPassengerUserId
            // 
            this.lblAdminPassengerUserId.AutoSize = true;
            this.lblAdminPassengerUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassengerUserId.Location = new System.Drawing.Point(49, 29);
            this.lblAdminPassengerUserId.Name = "lblAdminPassengerUserId";
            this.lblAdminPassengerUserId.Size = new System.Drawing.Size(86, 24);
            this.lblAdminPassengerUserId.TabIndex = 43;
            this.lblAdminPassengerUserId.Text = "User ID : ";
            // 
            // rdbAdminPassengerFemale
            // 
            this.rdbAdminPassengerFemale.AutoSize = true;
            this.rdbAdminPassengerFemale.Location = new System.Drawing.Point(205, 255);
            this.rdbAdminPassengerFemale.Name = "rdbAdminPassengerFemale";
            this.rdbAdminPassengerFemale.Size = new System.Drawing.Size(92, 24);
            this.rdbAdminPassengerFemale.TabIndex = 42;
            this.rdbAdminPassengerFemale.TabStop = true;
            this.rdbAdminPassengerFemale.Text = "FEMALE";
            this.rdbAdminPassengerFemale.UseVisualStyleBackColor = true;
            // 
            // rdbAdminPassengerMale
            // 
            this.rdbAdminPassengerMale.AutoSize = true;
            this.rdbAdminPassengerMale.Location = new System.Drawing.Point(130, 255);
            this.rdbAdminPassengerMale.Name = "rdbAdminPassengerMale";
            this.rdbAdminPassengerMale.Size = new System.Drawing.Size(71, 24);
            this.rdbAdminPassengerMale.TabIndex = 41;
            this.rdbAdminPassengerMale.TabStop = true;
            this.rdbAdminPassengerMale.Text = "MALE";
            this.rdbAdminPassengerMale.UseVisualStyleBackColor = true;
            // 
            // lblAdminPassengerGender
            // 
            this.lblAdminPassengerGender.AutoSize = true;
            this.lblAdminPassengerGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassengerGender.Location = new System.Drawing.Point(46, 254);
            this.lblAdminPassengerGender.Name = "lblAdminPassengerGender";
            this.lblAdminPassengerGender.Size = new System.Drawing.Size(89, 24);
            this.lblAdminPassengerGender.TabIndex = 40;
            this.lblAdminPassengerGender.Text = "Gender : ";
            // 
            // txtAdminPassengerAddress
            // 
            this.txtAdminPassengerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPassengerAddress.Location = new System.Drawing.Point(130, 187);
            this.txtAdminPassengerAddress.Multiline = true;
            this.txtAdminPassengerAddress.Name = "txtAdminPassengerAddress";
            this.txtAdminPassengerAddress.Size = new System.Drawing.Size(225, 58);
            this.txtAdminPassengerAddress.TabIndex = 39;
            // 
            // lblAdminPassengerAddress
            // 
            this.lblAdminPassengerAddress.AutoSize = true;
            this.lblAdminPassengerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassengerAddress.Location = new System.Drawing.Point(40, 188);
            this.lblAdminPassengerAddress.Name = "lblAdminPassengerAddress";
            this.lblAdminPassengerAddress.Size = new System.Drawing.Size(95, 24);
            this.lblAdminPassengerAddress.TabIndex = 38;
            this.lblAdminPassengerAddress.Text = "Address : ";
            // 
            // txtAdminPassengerEmail
            // 
            this.txtAdminPassengerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPassengerEmail.Location = new System.Drawing.Point(130, 145);
            this.txtAdminPassengerEmail.Multiline = true;
            this.txtAdminPassengerEmail.Name = "txtAdminPassengerEmail";
            this.txtAdminPassengerEmail.Size = new System.Drawing.Size(225, 30);
            this.txtAdminPassengerEmail.TabIndex = 37;
            // 
            // lblAdminPassengerEmail
            // 
            this.lblAdminPassengerEmail.AutoSize = true;
            this.lblAdminPassengerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassengerEmail.Location = new System.Drawing.Point(63, 147);
            this.lblAdminPassengerEmail.Name = "lblAdminPassengerEmail";
            this.lblAdminPassengerEmail.Size = new System.Drawing.Size(72, 24);
            this.lblAdminPassengerEmail.TabIndex = 36;
            this.lblAdminPassengerEmail.Text = "Email : ";
            // 
            // txtAdminPassengerPassword
            // 
            this.txtAdminPassengerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPassengerPassword.Location = new System.Drawing.Point(130, 105);
            this.txtAdminPassengerPassword.Multiline = true;
            this.txtAdminPassengerPassword.Name = "txtAdminPassengerPassword";
            this.txtAdminPassengerPassword.Size = new System.Drawing.Size(225, 30);
            this.txtAdminPassengerPassword.TabIndex = 34;
            // 
            // lblAdminPassengerPassword
            // 
            this.lblAdminPassengerPassword.AutoSize = true;
            this.lblAdminPassengerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassengerPassword.Location = new System.Drawing.Point(28, 107);
            this.lblAdminPassengerPassword.Name = "lblAdminPassengerPassword";
            this.lblAdminPassengerPassword.Size = new System.Drawing.Size(107, 24);
            this.lblAdminPassengerPassword.TabIndex = 33;
            this.lblAdminPassengerPassword.Text = "Password : ";
            // 
            // txtAdminPassengerUserName
            // 
            this.txtAdminPassengerUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPassengerUserName.Location = new System.Drawing.Point(130, 66);
            this.txtAdminPassengerUserName.Multiline = true;
            this.txtAdminPassengerUserName.Name = "txtAdminPassengerUserName";
            this.txtAdminPassengerUserName.Size = new System.Drawing.Size(225, 30);
            this.txtAdminPassengerUserName.TabIndex = 32;
            // 
            // lblAdminPassengerUserName
            // 
            this.lblAdminPassengerUserName.AutoSize = true;
            this.lblAdminPassengerUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassengerUserName.Location = new System.Drawing.Point(15, 68);
            this.lblAdminPassengerUserName.Name = "lblAdminPassengerUserName";
            this.lblAdminPassengerUserName.Size = new System.Drawing.Size(120, 24);
            this.lblAdminPassengerUserName.TabIndex = 31;
            this.lblAdminPassengerUserName.Text = "User Name : ";
            // 
            // txtPassengerSearch
            // 
            this.txtPassengerSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassengerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassengerSearch.Location = new System.Drawing.Point(8, 11);
            this.txtPassengerSearch.Multiline = true;
            this.txtPassengerSearch.Name = "txtPassengerSearch";
            this.txtPassengerSearch.Size = new System.Drawing.Size(802, 42);
            this.txtPassengerSearch.TabIndex = 0;
            // 
            // btnPassengerSearch
            // 
            this.btnPassengerSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPassengerSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassengerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerSearch.Location = new System.Drawing.Point(823, 11);
            this.btnPassengerSearch.Name = "btnPassengerSearch";
            this.btnPassengerSearch.Size = new System.Drawing.Size(154, 42);
            this.btnPassengerSearch.TabIndex = 1;
            this.btnPassengerSearch.Text = "Search";
            this.btnPassengerSearch.UseVisualStyleBackColor = false;
            this.btnPassengerSearch.Click += new System.EventHandler(this.btnPassengerSearch_Click);
            // 
            // btnPassengerRefresh
            // 
            this.btnPassengerRefresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPassengerRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassengerRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassengerRefresh.Location = new System.Drawing.Point(988, 11);
            this.btnPassengerRefresh.Name = "btnPassengerRefresh";
            this.btnPassengerRefresh.Size = new System.Drawing.Size(154, 42);
            this.btnPassengerRefresh.TabIndex = 2;
            this.btnPassengerRefresh.Text = "Refresh";
            this.btnPassengerRefresh.UseVisualStyleBackColor = false;
            this.btnPassengerRefresh.Click += new System.EventHandler(this.btnPassengerRefresh_Click);
            // 
            // pnlPassengerSearch
            // 
            this.pnlPassengerSearch.ColumnCount = 7;
            this.tableLayoutPanel1.SetColumnSpan(this.pnlPassengerSearch, 2);
            this.pnlPassengerSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlPassengerSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.073F));
            this.pnlPassengerSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9269989F));
            this.pnlPassengerSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlPassengerSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlPassengerSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlPassengerSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.pnlPassengerSearch.Controls.Add(this.txtPassengerSearch, 1, 1);
            this.pnlPassengerSearch.Controls.Add(this.btnPassengerSearch, 3, 1);
            this.pnlPassengerSearch.Controls.Add(this.btnPassengerRefresh, 5, 1);
            this.pnlPassengerSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPassengerSearch.Location = new System.Drawing.Point(4, 4);
            this.pnlPassengerSearch.Name = "pnlPassengerSearch";
            this.pnlPassengerSearch.RowCount = 3;
            this.pnlPassengerSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlPassengerSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlPassengerSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlPassengerSearch.Size = new System.Drawing.Size(1157, 64);
            this.pnlPassengerSearch.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 411F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPassengerSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminPassengerManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminPassengerInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlAdminPassengerManage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvAdminPassenger, 0, 2);
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
            // AdminPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminPassenger";
            this.Text = "AdminPassenger";
            this.Load += new System.EventHandler(this.AdminPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPassenger)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlAdminPassengerManage.ResumeLayout(false);
            this.pnlAdminPassengerManage.PerformLayout();
            this.pnlPassengerSearch.ResumeLayout(false);
            this.pnlPassengerSearch.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminPassenger;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdminPassengerAdd;
        private System.Windows.Forms.Button btnAdminPassengerUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdminPassengerDelete;
        private System.Windows.Forms.Label lblAdminPassengerManage;
        private System.Windows.Forms.Label lblAdminPassengerInfo;
        private System.Windows.Forms.Panel pnlAdminPassengerManage;
        private System.Windows.Forms.TextBox txtAdminPassengerUserId;
        private System.Windows.Forms.Label lblAdminPassengerUserId;
        private System.Windows.Forms.RadioButton rdbAdminPassengerFemale;
        private System.Windows.Forms.RadioButton rdbAdminPassengerMale;
        private System.Windows.Forms.Label lblAdminPassengerGender;
        private System.Windows.Forms.TextBox txtAdminPassengerAddress;
        private System.Windows.Forms.Label lblAdminPassengerAddress;
        private System.Windows.Forms.TextBox txtAdminPassengerEmail;
        private System.Windows.Forms.Label lblAdminPassengerEmail;
        private System.Windows.Forms.TextBox txtAdminPassengerPassword;
        private System.Windows.Forms.Label lblAdminPassengerPassword;
        private System.Windows.Forms.TextBox txtAdminPassengerUserName;
        private System.Windows.Forms.Label lblAdminPassengerUserName;
        private System.Windows.Forms.TextBox txtPassengerSearch;
        private System.Windows.Forms.Button btnPassengerSearch;
        private System.Windows.Forms.Button btnPassengerRefresh;
        private System.Windows.Forms.TableLayoutPanel pnlPassengerSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}