namespace Air_Ticket_Management_System
{
    partial class AdminAdmin
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
            this.dgvAdminAdmin = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdminAdminAdd = new System.Windows.Forms.Button();
            this.btnAdminAdminUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdminAdminDelete = new System.Windows.Forms.Button();
            this.lblAdminAdminManage = new System.Windows.Forms.Label();
            this.lblAdminAdminInfo = new System.Windows.Forms.Label();
            this.pnlAdminAdminManage = new System.Windows.Forms.Panel();
            this.txtAdminSearch = new System.Windows.Forms.TextBox();
            this.btnAdminSearch = new System.Windows.Forms.Button();
            this.btnAdminRefresh = new System.Windows.Forms.Button();
            this.pnlAdminSearch = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbAdminAdminFemale = new System.Windows.Forms.RadioButton();
            this.rdbAdminAdminMale = new System.Windows.Forms.RadioButton();
            this.lblAdminAdminGender = new System.Windows.Forms.Label();
            this.txtAdminAdminAddress = new System.Windows.Forms.TextBox();
            this.lblAdminAdminAddress = new System.Windows.Forms.Label();
            this.txtAdminAdminEmail = new System.Windows.Forms.TextBox();
            this.lblAdminAdminEmail = new System.Windows.Forms.Label();
            this.txtAdminAdminPassword = new System.Windows.Forms.TextBox();
            this.lblAdminAdminPassword = new System.Windows.Forms.Label();
            this.txtAdminAdminUserName = new System.Windows.Forms.TextBox();
            this.lblAdminAdminUserName = new System.Windows.Forms.Label();
            this.txtAdminAdminUserId = new System.Windows.Forms.TextBox();
            this.lblAdminAdminUserId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminAdmin)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlAdminAdminManage.SuspendLayout();
            this.pnlAdminSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdminAdmin
            // 
            this.dgvAdminAdmin.AllowUserToAddRows = false;
            this.dgvAdminAdmin.AllowUserToDeleteRows = false;
            this.dgvAdminAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdminAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdminAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminAdmin.Location = new System.Drawing.Point(4, 126);
            this.dgvAdminAdmin.Name = "dgvAdminAdmin";
            this.dgvAdminAdmin.ReadOnly = true;
            this.dgvAdminAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminAdmin.Size = new System.Drawing.Size(746, 521);
            this.dgvAdminAdmin.TabIndex = 4;
            this.dgvAdminAdmin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminAdmin_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(123, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 34);
            this.panel2.TabIndex = 1;
            // 
            // btnAdminAdminAdd
            // 
            this.btnAdminAdminAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdminAdminAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminAdminAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAdminAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdminAdminAdd.Name = "btnAdminAdminAdd";
            this.btnAdminAdminAdd.Size = new System.Drawing.Size(114, 34);
            this.btnAdminAdminAdd.TabIndex = 2;
            this.btnAdminAdminAdd.Text = "Add";
            this.btnAdminAdminAdd.UseVisualStyleBackColor = false;
            this.btnAdminAdminAdd.Click += new System.EventHandler(this.btnAdminFlightAdd_Click);
            // 
            // btnAdminAdminUpdate
            // 
            this.btnAdminAdminUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdminAdminUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminAdminUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAdminUpdate.Location = new System.Drawing.Point(130, 3);
            this.btnAdminAdminUpdate.Name = "btnAdminAdminUpdate";
            this.btnAdminAdminUpdate.Size = new System.Drawing.Size(114, 34);
            this.btnAdminAdminUpdate.TabIndex = 3;
            this.btnAdminAdminUpdate.Text = "Update";
            this.btnAdminAdminUpdate.UseVisualStyleBackColor = false;
            this.btnAdminAdminUpdate.Click += new System.EventHandler(this.btnAdminFlightUpdate_Click);
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
            this.tableLayoutPanel2.Controls.Add(this.btnAdminAdminAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdminAdminUpdate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdminAdminDelete, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 324);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 40);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // btnAdminAdminDelete
            // 
            this.btnAdminAdminDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnAdminAdminDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminAdminDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAdminDelete.Location = new System.Drawing.Point(257, 3);
            this.btnAdminAdminDelete.Name = "btnAdminAdminDelete";
            this.btnAdminAdminDelete.Size = new System.Drawing.Size(114, 34);
            this.btnAdminAdminDelete.TabIndex = 4;
            this.btnAdminAdminDelete.Text = "Delete";
            this.btnAdminAdminDelete.UseVisualStyleBackColor = false;
            this.btnAdminAdminDelete.Click += new System.EventHandler(this.btnAdminFlightDelete_Click);
            // 
            // lblAdminAdminManage
            // 
            this.lblAdminAdminManage.AutoSize = true;
            this.lblAdminAdminManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminAdminManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAdminManage.Location = new System.Drawing.Point(757, 72);
            this.lblAdminAdminManage.Name = "lblAdminAdminManage";
            this.lblAdminAdminManage.Size = new System.Drawing.Size(404, 50);
            this.lblAdminAdminManage.TabIndex = 1;
            this.lblAdminAdminManage.Text = "Manage Admins";
            this.lblAdminAdminManage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminAdminInfo
            // 
            this.lblAdminAdminInfo.AutoSize = true;
            this.lblAdminAdminInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdminAdminInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAdminInfo.Location = new System.Drawing.Point(4, 72);
            this.lblAdminAdminInfo.Name = "lblAdminAdminInfo";
            this.lblAdminAdminInfo.Size = new System.Drawing.Size(746, 50);
            this.lblAdminAdminInfo.TabIndex = 0;
            this.lblAdminAdminInfo.Text = "Admin Info";
            this.lblAdminAdminInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAdminAdminManage
            // 
            this.pnlAdminAdminManage.Controls.Add(this.txtAdminAdminUserId);
            this.pnlAdminAdminManage.Controls.Add(this.lblAdminAdminUserId);
            this.pnlAdminAdminManage.Controls.Add(this.rdbAdminAdminFemale);
            this.pnlAdminAdminManage.Controls.Add(this.rdbAdminAdminMale);
            this.pnlAdminAdminManage.Controls.Add(this.lblAdminAdminGender);
            this.pnlAdminAdminManage.Controls.Add(this.txtAdminAdminAddress);
            this.pnlAdminAdminManage.Controls.Add(this.lblAdminAdminAddress);
            this.pnlAdminAdminManage.Controls.Add(this.txtAdminAdminEmail);
            this.pnlAdminAdminManage.Controls.Add(this.lblAdminAdminEmail);
            this.pnlAdminAdminManage.Controls.Add(this.txtAdminAdminPassword);
            this.pnlAdminAdminManage.Controls.Add(this.lblAdminAdminPassword);
            this.pnlAdminAdminManage.Controls.Add(this.txtAdminAdminUserName);
            this.pnlAdminAdminManage.Controls.Add(this.lblAdminAdminUserName);
            this.pnlAdminAdminManage.Controls.Add(this.tableLayoutPanel2);
            this.pnlAdminAdminManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminAdminManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdminAdminManage.Location = new System.Drawing.Point(757, 126);
            this.pnlAdminAdminManage.Name = "pnlAdminAdminManage";
            this.pnlAdminAdminManage.Size = new System.Drawing.Size(404, 521);
            this.pnlAdminAdminManage.TabIndex = 3;
            // 
            // txtAdminSearch
            // 
            this.txtAdminSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdminSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminSearch.Location = new System.Drawing.Point(8, 11);
            this.txtAdminSearch.Multiline = true;
            this.txtAdminSearch.Name = "txtAdminSearch";
            this.txtAdminSearch.Size = new System.Drawing.Size(803, 42);
            this.txtAdminSearch.TabIndex = 0;
            // 
            // btnAdminSearch
            // 
            this.btnAdminSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdminSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSearch.Location = new System.Drawing.Point(824, 11);
            this.btnAdminSearch.Name = "btnAdminSearch";
            this.btnAdminSearch.Size = new System.Drawing.Size(154, 42);
            this.btnAdminSearch.TabIndex = 1;
            this.btnAdminSearch.Text = "Search";
            this.btnAdminSearch.UseVisualStyleBackColor = false;
            this.btnAdminSearch.Click += new System.EventHandler(this.btnAdminSearch_Click);
            // 
            // btnAdminRefresh
            // 
            this.btnAdminRefresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdminRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminRefresh.Location = new System.Drawing.Point(989, 11);
            this.btnAdminRefresh.Name = "btnAdminRefresh";
            this.btnAdminRefresh.Size = new System.Drawing.Size(154, 42);
            this.btnAdminRefresh.TabIndex = 2;
            this.btnAdminRefresh.Text = "Refresh";
            this.btnAdminRefresh.UseVisualStyleBackColor = false;
            this.btnAdminRefresh.Click += new System.EventHandler(this.btnAdminRefresh_Click);
            // 
            // pnlAdminSearch
            // 
            this.pnlAdminSearch.ColumnCount = 7;
            this.tableLayoutPanel1.SetColumnSpan(this.pnlAdminSearch, 2);
            this.pnlAdminSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlAdminSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.073F));
            this.pnlAdminSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9269989F));
            this.pnlAdminSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlAdminSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlAdminSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.pnlAdminSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlAdminSearch.Controls.Add(this.txtAdminSearch, 1, 1);
            this.pnlAdminSearch.Controls.Add(this.btnAdminSearch, 3, 1);
            this.pnlAdminSearch.Controls.Add(this.btnAdminRefresh, 5, 1);
            this.pnlAdminSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminSearch.Location = new System.Drawing.Point(4, 4);
            this.pnlAdminSearch.Name = "pnlAdminSearch";
            this.pnlAdminSearch.RowCount = 3;
            this.pnlAdminSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlAdminSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlAdminSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.pnlAdminSearch.Size = new System.Drawing.Size(1157, 64);
            this.pnlAdminSearch.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410F));
            this.tableLayoutPanel1.Controls.Add(this.pnlAdminSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminAdminManage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAdminAdminInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlAdminAdminManage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvAdminAdmin, 0, 2);
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
            // rdbAdminAdminFemale
            // 
            this.rdbAdminAdminFemale.AutoSize = true;
            this.rdbAdminAdminFemale.Location = new System.Drawing.Point(205, 255);
            this.rdbAdminAdminFemale.Name = "rdbAdminAdminFemale";
            this.rdbAdminAdminFemale.Size = new System.Drawing.Size(92, 24);
            this.rdbAdminAdminFemale.TabIndex = 42;
            this.rdbAdminAdminFemale.TabStop = true;
            this.rdbAdminAdminFemale.Text = "FEMALE";
            this.rdbAdminAdminFemale.UseVisualStyleBackColor = true;
            // 
            // rdbAdminAdminMale
            // 
            this.rdbAdminAdminMale.AutoSize = true;
            this.rdbAdminAdminMale.Location = new System.Drawing.Point(130, 255);
            this.rdbAdminAdminMale.Name = "rdbAdminAdminMale";
            this.rdbAdminAdminMale.Size = new System.Drawing.Size(71, 24);
            this.rdbAdminAdminMale.TabIndex = 41;
            this.rdbAdminAdminMale.TabStop = true;
            this.rdbAdminAdminMale.Text = "MALE";
            this.rdbAdminAdminMale.UseVisualStyleBackColor = true;
            // 
            // lblAdminAdminGender
            // 
            this.lblAdminAdminGender.AutoSize = true;
            this.lblAdminAdminGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAdminGender.Location = new System.Drawing.Point(46, 254);
            this.lblAdminAdminGender.Name = "lblAdminAdminGender";
            this.lblAdminAdminGender.Size = new System.Drawing.Size(89, 24);
            this.lblAdminAdminGender.TabIndex = 40;
            this.lblAdminAdminGender.Text = "Gender : ";
            // 
            // txtAdminAdminAddress
            // 
            this.txtAdminAdminAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminAdminAddress.Location = new System.Drawing.Point(130, 187);
            this.txtAdminAdminAddress.Multiline = true;
            this.txtAdminAdminAddress.Name = "txtAdminAdminAddress";
            this.txtAdminAdminAddress.Size = new System.Drawing.Size(225, 58);
            this.txtAdminAdminAddress.TabIndex = 39;
            // 
            // lblAdminAdminAddress
            // 
            this.lblAdminAdminAddress.AutoSize = true;
            this.lblAdminAdminAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAdminAddress.Location = new System.Drawing.Point(40, 188);
            this.lblAdminAdminAddress.Name = "lblAdminAdminAddress";
            this.lblAdminAdminAddress.Size = new System.Drawing.Size(95, 24);
            this.lblAdminAdminAddress.TabIndex = 38;
            this.lblAdminAdminAddress.Text = "Address : ";
            // 
            // txtAdminAdminEmail
            // 
            this.txtAdminAdminEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminAdminEmail.Location = new System.Drawing.Point(130, 145);
            this.txtAdminAdminEmail.Multiline = true;
            this.txtAdminAdminEmail.Name = "txtAdminAdminEmail";
            this.txtAdminAdminEmail.Size = new System.Drawing.Size(225, 30);
            this.txtAdminAdminEmail.TabIndex = 37;
            // 
            // lblAdminAdminEmail
            // 
            this.lblAdminAdminEmail.AutoSize = true;
            this.lblAdminAdminEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAdminEmail.Location = new System.Drawing.Point(63, 147);
            this.lblAdminAdminEmail.Name = "lblAdminAdminEmail";
            this.lblAdminAdminEmail.Size = new System.Drawing.Size(72, 24);
            this.lblAdminAdminEmail.TabIndex = 36;
            this.lblAdminAdminEmail.Text = "Email : ";
            // 
            // txtAdminAdminPassword
            // 
            this.txtAdminAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminAdminPassword.Location = new System.Drawing.Point(130, 105);
            this.txtAdminAdminPassword.Multiline = true;
            this.txtAdminAdminPassword.Name = "txtAdminAdminPassword";
            this.txtAdminAdminPassword.Size = new System.Drawing.Size(225, 30);
            this.txtAdminAdminPassword.TabIndex = 34;
            // 
            // lblAdminAdminPassword
            // 
            this.lblAdminAdminPassword.AutoSize = true;
            this.lblAdminAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAdminPassword.Location = new System.Drawing.Point(28, 107);
            this.lblAdminAdminPassword.Name = "lblAdminAdminPassword";
            this.lblAdminAdminPassword.Size = new System.Drawing.Size(107, 24);
            this.lblAdminAdminPassword.TabIndex = 33;
            this.lblAdminAdminPassword.Text = "Password : ";
            // 
            // txtAdminAdminUserName
            // 
            this.txtAdminAdminUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminAdminUserName.Location = new System.Drawing.Point(130, 66);
            this.txtAdminAdminUserName.Multiline = true;
            this.txtAdminAdminUserName.Name = "txtAdminAdminUserName";
            this.txtAdminAdminUserName.Size = new System.Drawing.Size(225, 30);
            this.txtAdminAdminUserName.TabIndex = 32;
            // 
            // lblAdminAdminUserName
            // 
            this.lblAdminAdminUserName.AutoSize = true;
            this.lblAdminAdminUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAdminUserName.Location = new System.Drawing.Point(15, 68);
            this.lblAdminAdminUserName.Name = "lblAdminAdminUserName";
            this.lblAdminAdminUserName.Size = new System.Drawing.Size(120, 24);
            this.lblAdminAdminUserName.TabIndex = 31;
            this.lblAdminAdminUserName.Text = "User Name : ";
            // 
            // txtAdminAdminUserId
            // 
            this.txtAdminAdminUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminAdminUserId.Location = new System.Drawing.Point(130, 26);
            this.txtAdminAdminUserId.Multiline = true;
            this.txtAdminAdminUserId.Name = "txtAdminAdminUserId";
            this.txtAdminAdminUserId.ReadOnly = true;
            this.txtAdminAdminUserId.Size = new System.Drawing.Size(225, 30);
            this.txtAdminAdminUserId.TabIndex = 44;
            // 
            // lblAdminAdminUserId
            // 
            this.lblAdminAdminUserId.AutoSize = true;
            this.lblAdminAdminUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAdminUserId.Location = new System.Drawing.Point(49, 29);
            this.lblAdminAdminUserId.Name = "lblAdminAdminUserId";
            this.lblAdminAdminUserId.Size = new System.Drawing.Size(86, 24);
            this.lblAdminAdminUserId.TabIndex = 43;
            this.lblAdminAdminUserId.Text = "User ID : ";
            // 
            // AdminAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminAdmin";
            this.Text = "AdminAdmin";
            this.Load += new System.EventHandler(this.AdminAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminAdmin)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlAdminAdminManage.ResumeLayout(false);
            this.pnlAdminAdminManage.PerformLayout();
            this.pnlAdminSearch.ResumeLayout(false);
            this.pnlAdminSearch.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdminAdminAdd;
        private System.Windows.Forms.Button btnAdminAdminUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdminAdminDelete;
        private System.Windows.Forms.Label lblAdminAdminManage;
        private System.Windows.Forms.Label lblAdminAdminInfo;
        private System.Windows.Forms.Panel pnlAdminAdminManage;
        private System.Windows.Forms.TextBox txtAdminSearch;
        private System.Windows.Forms.Button btnAdminSearch;
        private System.Windows.Forms.Button btnAdminRefresh;
        private System.Windows.Forms.TableLayoutPanel pnlAdminSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rdbAdminAdminFemale;
        private System.Windows.Forms.RadioButton rdbAdminAdminMale;
        private System.Windows.Forms.Label lblAdminAdminGender;
        private System.Windows.Forms.TextBox txtAdminAdminAddress;
        private System.Windows.Forms.Label lblAdminAdminAddress;
        private System.Windows.Forms.TextBox txtAdminAdminEmail;
        private System.Windows.Forms.Label lblAdminAdminEmail;
        private System.Windows.Forms.TextBox txtAdminAdminPassword;
        private System.Windows.Forms.Label lblAdminAdminPassword;
        private System.Windows.Forms.TextBox txtAdminAdminUserName;
        private System.Windows.Forms.Label lblAdminAdminUserName;
        private System.Windows.Forms.TextBox txtAdminAdminUserId;
        private System.Windows.Forms.Label lblAdminAdminUserId;
    }
}