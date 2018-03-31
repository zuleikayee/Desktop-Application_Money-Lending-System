namespace boombroom
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpNew = new System.Windows.Forms.TabPage();
            this.lblBDateForm = new System.Windows.Forms.Label();
            this.lblTelForm = new System.Windows.Forms.Label();
            this.lblPinRemind = new System.Windows.Forms.Label();
            this.lblRemind = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtWAd = new System.Windows.Forms.RichTextBox();
            this.lblWAd = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtHAd = new System.Windows.Forms.RichTextBox();
            this.lblHAd = new System.Windows.Forms.Label();
            this.dtpBdate = new System.Windows.Forms.DateTimePicker();
            this.lblBDate = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStat = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblGen = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tpManage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddP = new System.Windows.Forms.Button();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.payment = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtCustomer = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtBorrowed = new System.Windows.Forms.TextBox();
            this.dtAccount = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDT = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tpNew.SuspendLayout();
            this.tpManage.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCustomer)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpNew);
            this.tabControl1.Controls.Add(this.tpManage);
            this.tabControl1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 575);
            this.tabControl1.TabIndex = 0;
            // 
            // tpNew
            // 
            this.tpNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(65)))));
            this.tpNew.BackgroundImage = global::boombroom.Properties.Resources.bg_NC;
            this.tpNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tpNew.Controls.Add(this.lblBDateForm);
            this.tpNew.Controls.Add(this.lblTelForm);
            this.tpNew.Controls.Add(this.lblPinRemind);
            this.tpNew.Controls.Add(this.lblRemind);
            this.tpNew.Controls.Add(this.btnClear);
            this.tpNew.Controls.Add(this.txtLast);
            this.tpNew.Controls.Add(this.btnAdd);
            this.tpNew.Controls.Add(this.txtWAd);
            this.tpNew.Controls.Add(this.lblWAd);
            this.tpNew.Controls.Add(this.txtPin);
            this.tpNew.Controls.Add(this.lblPin);
            this.tpNew.Controls.Add(this.txtPhone);
            this.tpNew.Controls.Add(this.lblPhone);
            this.tpNew.Controls.Add(this.txtTel);
            this.tpNew.Controls.Add(this.lblTel);
            this.tpNew.Controls.Add(this.txtJob);
            this.tpNew.Controls.Add(this.lblJob);
            this.tpNew.Controls.Add(this.txtHAd);
            this.tpNew.Controls.Add(this.lblHAd);
            this.tpNew.Controls.Add(this.dtpBdate);
            this.tpNew.Controls.Add(this.lblBDate);
            this.tpNew.Controls.Add(this.cbStatus);
            this.tpNew.Controls.Add(this.lblStat);
            this.tpNew.Controls.Add(this.cbGender);
            this.tpNew.Controls.Add(this.lblGen);
            this.tpNew.Controls.Add(this.txtFirst);
            this.tpNew.Controls.Add(this.lblName);
            this.tpNew.ForeColor = System.Drawing.Color.White;
            this.tpNew.Location = new System.Drawing.Point(4, 31);
            this.tpNew.Name = "tpNew";
            this.tpNew.Padding = new System.Windows.Forms.Padding(3);
            this.tpNew.Size = new System.Drawing.Size(968, 540);
            this.tpNew.TabIndex = 0;
            this.tpNew.Text = "New Customer";
            // 
            // lblBDateForm
            // 
            this.lblBDateForm.AutoSize = true;
            this.lblBDateForm.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDateForm.Location = new System.Drawing.Point(204, 271);
            this.lblBDateForm.Name = "lblBDateForm";
            this.lblBDateForm.Size = new System.Drawing.Size(66, 16);
            this.lblBDateForm.TabIndex = 34;
            this.lblBDateForm.Text = "yyyy-MM-dd";
            // 
            // lblTelForm
            // 
            this.lblTelForm.AutoSize = true;
            this.lblTelForm.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelForm.Location = new System.Drawing.Point(735, 116);
            this.lblTelForm.Name = "lblTelForm";
            this.lblTelForm.Size = new System.Drawing.Size(65, 16);
            this.lblTelForm.TabIndex = 33;
            this.lblTelForm.Text = "09(9 digits)";
            // 
            // lblPinRemind
            // 
            this.lblPinRemind.AutoSize = true;
            this.lblPinRemind.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinRemind.Location = new System.Drawing.Point(736, 271);
            this.lblPinRemind.Name = "lblPinRemind";
            this.lblPinRemind.Size = new System.Drawing.Size(103, 16);
            this.lblPinRemind.TabIndex = 32;
            this.lblPinRemind.Text = "Must be four digits";
            // 
            // lblRemind
            // 
            this.lblRemind.AutoSize = true;
            this.lblRemind.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemind.Location = new System.Drawing.Point(19, 14);
            this.lblRemind.Name = "lblRemind";
            this.lblRemind.Size = new System.Drawing.Size(159, 16);
            this.lblRemind.TabIndex = 31;
            this.lblRemind.Text = "*Required fields in Red Orange";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(125)))), ((int)(((byte)(55)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(838, 477);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 41);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLast.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(250, 64);
            this.txtLast.MaxLength = 100;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(180, 28);
            this.txtLast.TabIndex = 1;
            this.txtLast.Text = "last";
            this.txtLast.Enter += new System.EventHandler(this.txtLast_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(68)))), ((int)(((byte)(39)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(669, 477);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 41);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtWAd
            // 
            this.txtWAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtWAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWAd.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWAd.Location = new System.Drawing.Point(541, 372);
            this.txtWAd.MaxLength = 100;
            this.txtWAd.Name = "txtWAd";
            this.txtWAd.Size = new System.Drawing.Size(381, 96);
            this.txtWAd.TabIndex = 10;
            this.txtWAd.Text = "";
            // 
            // lblWAd
            // 
            this.lblWAd.AutoSize = true;
            this.lblWAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(68)))), ((int)(((byte)(39)))));
            this.lblWAd.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWAd.ForeColor = System.Drawing.Color.Black;
            this.lblWAd.Location = new System.Drawing.Point(515, 345);
            this.lblWAd.Name = "lblWAd";
            this.lblWAd.Size = new System.Drawing.Size(217, 27);
            this.lblWAd.TabIndex = 27;
            this.lblWAd.Text = "  Working Address     ";
            // 
            // txtPin
            // 
            this.txtPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPin.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.Location = new System.Drawing.Point(541, 292);
            this.txtPin.MaxLength = 4;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(381, 28);
            this.txtPin.TabIndex = 9;
            this.txtPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtINT_KeyPress);
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(68)))), ((int)(((byte)(39)))));
            this.lblPin.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.ForeColor = System.Drawing.Color.Black;
            this.lblPin.Location = new System.Drawing.Point(515, 265);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(215, 27);
            this.lblPin.TabIndex = 25;
            this.lblPin.Text = "  Pin Number             ";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(541, 216);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(381, 28);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtINT_KeyPress);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(118)))));
            this.lblPhone.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(515, 189);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(215, 27);
            this.lblPhone.TabIndex = 23;
            this.lblPhone.Text = "  Phone Number        ";
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(541, 138);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(381, 28);
            this.txtTel.TabIndex = 7;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtINT_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(118)))));
            this.lblTel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.Black;
            this.lblTel.Location = new System.Drawing.Point(515, 111);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(214, 27);
            this.lblTel.TabIndex = 21;
            this.lblTel.Text = "  Telephone Number ";
            // 
            // txtJob
            // 
            this.txtJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtJob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJob.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.Location = new System.Drawing.Point(541, 64);
            this.txtJob.MaxLength = 100;
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(381, 28);
            this.txtJob.TabIndex = 6;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(68)))), ((int)(((byte)(39)))));
            this.lblJob.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.Black;
            this.lblJob.Location = new System.Drawing.Point(515, 37);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(212, 27);
            this.lblJob.TabIndex = 19;
            this.lblJob.Text = "  Job Description      ";
            // 
            // txtHAd
            // 
            this.txtHAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtHAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHAd.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHAd.Location = new System.Drawing.Point(49, 372);
            this.txtHAd.MaxLength = 100;
            this.txtHAd.Name = "txtHAd";
            this.txtHAd.Size = new System.Drawing.Size(381, 96);
            this.txtHAd.TabIndex = 5;
            this.txtHAd.Text = "";
            // 
            // lblHAd
            // 
            this.lblHAd.AutoSize = true;
            this.lblHAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(68)))), ((int)(((byte)(39)))));
            this.lblHAd.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHAd.ForeColor = System.Drawing.Color.Black;
            this.lblHAd.Location = new System.Drawing.Point(23, 345);
            this.lblHAd.Name = "lblHAd";
            this.lblHAd.Size = new System.Drawing.Size(179, 27);
            this.lblHAd.TabIndex = 17;
            this.lblHAd.Text = "  Home Address   ";
            // 
            // dtpBdate
            // 
            this.dtpBdate.CustomFormat = "yyyy-MM-dd";
            this.dtpBdate.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBdate.Location = new System.Drawing.Point(49, 291);
            this.dtpBdate.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.dtpBdate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBdate.Name = "dtpBdate";
            this.dtpBdate.Size = new System.Drawing.Size(381, 30);
            this.dtpBdate.TabIndex = 4;
            this.dtpBdate.Value = new System.DateTime(2017, 2, 13, 0, 0, 0, 0);
            // 
            // lblBDate
            // 
            this.lblBDate.AutoSize = true;
            this.lblBDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(68)))), ((int)(((byte)(39)))));
            this.lblBDate.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDate.ForeColor = System.Drawing.Color.Black;
            this.lblBDate.Location = new System.Drawing.Point(23, 264);
            this.lblBDate.Name = "lblBDate";
            this.lblBDate.Size = new System.Drawing.Size(175, 27);
            this.lblBDate.TabIndex = 15;
            this.lblBDate.Text = "  Birthdate          ";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "",
            "Single",
            "Married",
            "Widowed"});
            this.cbStatus.Location = new System.Drawing.Point(49, 214);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(381, 30);
            this.cbStatus.TabIndex = 3;
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(68)))), ((int)(((byte)(39)))));
            this.lblStat.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat.ForeColor = System.Drawing.Color.Black;
            this.lblStat.Location = new System.Drawing.Point(23, 187);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(175, 27);
            this.lblStat.TabIndex = 13;
            this.lblStat.Text = "  Civil Status       ";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(49, 138);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(381, 30);
            this.cbGender.TabIndex = 2;
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(68)))), ((int)(((byte)(39)))));
            this.lblGen.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.ForeColor = System.Drawing.Color.Black;
            this.lblGen.Location = new System.Drawing.Point(23, 111);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(173, 27);
            this.lblGen.TabIndex = 20;
            this.lblGen.Text = "  Gender             ";
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirst.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(49, 64);
            this.txtFirst.MaxLength = 100;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(195, 28);
            this.txtFirst.TabIndex = 0;
            this.txtFirst.Text = "first";
            this.txtFirst.Enter += new System.EventHandler(this.txtFirst_Enter);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(68)))), ((int)(((byte)(39)))));
            this.lblName.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(23, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(184, 27);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "  Customer Name ";
            // 
            // tpManage
            // 
            this.tpManage.BackColor = System.Drawing.Color.Black;
            this.tpManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpManage.Controls.Add(this.panel4);
            this.tpManage.Controls.Add(this.panel2);
            this.tpManage.Controls.Add(this.panel3);
            this.tpManage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpManage.Location = new System.Drawing.Point(4, 31);
            this.tpManage.Name = "tpManage";
            this.tpManage.Padding = new System.Windows.Forms.Padding(3);
            this.tpManage.Size = new System.Drawing.Size(968, 540);
            this.tpManage.TabIndex = 1;
            this.tpManage.Text = "Customer and Account Management";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::boombroom.Properties.Resources.paymentPan;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnAddP);
            this.panel4.Controls.Add(this.txtTotalPaid);
            this.panel4.Controls.Add(this.payment);
            this.panel4.Location = new System.Drawing.Point(650, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 512);
            this.panel4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(57, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Payment Overview of Selected Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Total Paid_____________________________";
            // 
            // btnAddP
            // 
            this.btnAddP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(26)))), ((int)(((byte)(199)))));
            this.btnAddP.FlatAppearance.BorderSize = 0;
            this.btnAddP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddP.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.btnAddP.ForeColor = System.Drawing.Color.Black;
            this.btnAddP.Location = new System.Drawing.Point(7, 457);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(292, 42);
            this.btnAddP.TabIndex = 33;
            this.btnAddP.Text = "Add Payment";
            this.btnAddP.UseVisualStyleBackColor = false;
            this.btnAddP.Click += new System.EventHandler(this.addP_Click);
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.txtTotalPaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPaid.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.txtTotalPaid.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPaid.Location = new System.Drawing.Point(8, 363);
            this.txtTotalPaid.MaxLength = 100;
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.ReadOnly = true;
            this.txtTotalPaid.Size = new System.Drawing.Size(291, 28);
            this.txtTotalPaid.TabIndex = 7;
            this.txtTotalPaid.Text = "0";
            this.txtTotalPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // payment
            // 
            this.payment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payment.GridColor = System.Drawing.Color.White;
            this.payment.Location = new System.Drawing.Point(7, 51);
            this.payment.Name = "payment";
            this.payment.ReadOnly = true;
            this.payment.RowHeadersVisible = false;
            this.payment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payment.Size = new System.Drawing.Size(292, 277);
            this.payment.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::boombroom.Properties.Resources.customerPan;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.rbInactive);
            this.panel2.Controls.Add(this.rbActive);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.dtCustomer);
            this.panel2.Location = new System.Drawing.Point(12, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 512);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(68)))), ((int)(((byte)(39)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(7, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 42);
            this.button1.TabIndex = 35;
            this.button1.Text = "Update Customer Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(94, 393);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 16);
            this.label22.TabIndex = 39;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(129, 122);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 22);
            this.label21.TabIndex = 38;
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbInactive.Location = new System.Drawing.Point(163, 97);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(85, 26);
            this.rbInactive.TabIndex = 2;
            this.rbInactive.TabStop = true;
            this.rbInactive.Text = "Inactive";
            this.rbInactive.UseVisualStyleBackColor = true;
            this.rbInactive.CheckedChanged += new System.EventHandler(this.rbInactive_CheckedChanged);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbActive.Location = new System.Drawing.Point(77, 97);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(74, 26);
            this.rbActive.TabIndex = 1;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(136, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 16);
            this.label20.TabIndex = 37;
            this.label20.Text = "Status";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(120, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 16);
            this.label19.TabIndex = 34;
            this.label19.Text = "Search Name";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(8, 51);
            this.txtSearch.MaxLength = 100;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(290, 28);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(94, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Click to select customer\r\n";
            // 
            // dtCustomer
            // 
            this.dtCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dtCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCustomer.GridColor = System.Drawing.Color.White;
            this.dtCustomer.Location = new System.Drawing.Point(7, 160);
            this.dtCustomer.Name = "dtCustomer";
            this.dtCustomer.ReadOnly = true;
            this.dtCustomer.RowHeadersVisible = false;
            this.dtCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCustomer.Size = new System.Drawing.Size(292, 287);
            this.dtCustomer.TabIndex = 1;
            this.dtCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCustomer_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::boombroom.Properties.Resources.accountPan;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbl1);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtBalance);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.txtBorrowed);
            this.panel3.Controls.Add(this.dtAccount);
            this.panel3.Location = new System.Drawing.Point(330, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 512);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Overall Borrowed_______________________";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(5, 397);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(296, 18);
            this.lbl1.TabIndex = 33;
            this.lbl1.Text = "Overall Balance________________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(34, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(250, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Click to select account and view payments made";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(196)))));
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBalance.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.Black;
            this.txtBalance.Location = new System.Drawing.Point(7, 419);
            this.txtBalance.MaxLength = 100;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(292, 28);
            this.txtBalance.TabIndex = 5;
            this.txtBalance.Text = "0";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(7, 458);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(292, 42);
            this.button3.TabIndex = 31;
            this.button3.Text = "Add Account";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtBorrowed
            // 
            this.txtBorrowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(196)))));
            this.txtBorrowed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBorrowed.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowed.ForeColor = System.Drawing.Color.Black;
            this.txtBorrowed.Location = new System.Drawing.Point(8, 363);
            this.txtBorrowed.MaxLength = 100;
            this.txtBorrowed.Name = "txtBorrowed";
            this.txtBorrowed.ReadOnly = true;
            this.txtBorrowed.Size = new System.Drawing.Size(292, 28);
            this.txtBorrowed.TabIndex = 3;
            this.txtBorrowed.Text = "0";
            this.txtBorrowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtAccount
            // 
            this.dtAccount.AllowDrop = true;
            this.dtAccount.AllowUserToResizeColumns = false;
            this.dtAccount.AllowUserToResizeRows = false;
            this.dtAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dtAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAccount.GridColor = System.Drawing.Color.White;
            this.dtAccount.Location = new System.Drawing.Point(7, 50);
            this.dtAccount.Name = "dtAccount";
            this.dtAccount.ReadOnly = true;
            this.dtAccount.RowHeadersVisible = false;
            this.dtAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtAccount.Size = new System.Drawing.Size(292, 278);
            this.dtAccount.TabIndex = 2;
            this.dtAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAccount_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(962, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 28);
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.BackColor = System.Drawing.Color.Transparent;
            this.lblDT.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.ForeColor = System.Drawing.Color.White;
            this.lblDT.Location = new System.Drawing.Point(12, 7);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(0, 35);
            this.lblDT.TabIndex = 9;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1000, 634);
            this.ControlBox = false;
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpNew.ResumeLayout(false);
            this.tpNew.PerformLayout();
            this.tpManage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCustomer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpNew;
        private System.Windows.Forms.TabPage tpManage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Label lblBDate;
        private System.Windows.Forms.DateTimePicker dtpBdate;
        private System.Windows.Forms.Label lblHAd;
        private System.Windows.Forms.RichTextBox txtHAd;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.RichTextBox txtWAd;
        private System.Windows.Forms.Label lblWAd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dtAccount;
        private System.Windows.Forms.DataGridView dtCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView payment;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtBorrowed;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblRemind;
        private System.Windows.Forms.Label lblPinRemind;
        private System.Windows.Forms.Label lblTelForm;
        private System.Windows.Forms.Label lblBDateForm;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnAdd;
    }
}