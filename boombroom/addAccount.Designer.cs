namespace boombroom
{
    partial class addAccount
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
            this.txtPay = new System.Windows.Forms.TextBox();
            this.cbInstallment = new System.Windows.Forms.ComboBox();
            this.txtCard1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.txtCard2 = new System.Windows.Forms.TextBox();
            this.txtCard3 = new System.Windows.Forms.TextBox();
            this.txtCard4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPay
            // 
            this.txtPay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPay.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPay.ForeColor = System.Drawing.Color.Black;
            this.txtPay.Location = new System.Drawing.Point(262, 89);
            this.txtPay.MaxLength = 10;
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(271, 32);
            this.txtPay.TabIndex = 0;
            this.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMONEY_KeyPress);
            // 
            // cbInstallment
            // 
            this.cbInstallment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbInstallment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstallment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbInstallment.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInstallment.ForeColor = System.Drawing.Color.Black;
            this.cbInstallment.FormattingEnabled = true;
            this.cbInstallment.Items.AddRange(new object[] {
            "",
            "6 Months - 7%",
            "3 Months - 5%",
            "1 Month - 3%"});
            this.cbInstallment.Location = new System.Drawing.Point(262, 234);
            this.cbInstallment.Name = "cbInstallment";
            this.cbInstallment.Size = new System.Drawing.Size(271, 37);
            this.cbInstallment.TabIndex = 5;
            // 
            // txtCard1
            // 
            this.txtCard1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCard1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCard1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard1.ForeColor = System.Drawing.Color.Black;
            this.txtCard1.Location = new System.Drawing.Point(261, 165);
            this.txtCard1.MaxLength = 4;
            this.txtCard1.Name = "txtCard1";
            this.txtCard1.Size = new System.Drawing.Size(65, 32);
            this.txtCard1.TabIndex = 1;
            this.txtCard1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCard1.TextChanged += new System.EventHandler(this.txtCard1_TextChanged);
            this.txtCard1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtINT_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(99, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Account";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(295, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 42);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = global::boombroom.Properties.Resources.eraser;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(539, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(30, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.BackColor = System.Drawing.Color.Transparent;
            this.btnClear2.BackgroundImage = global::boombroom.Properties.Resources.eraser;
            this.btnClear2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear2.FlatAppearance.BorderSize = 0;
            this.btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear2.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear2.Location = new System.Drawing.Point(539, 165);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(30, 30);
            this.btnClear2.TabIndex = 6;
            this.btnClear2.UseVisualStyleBackColor = false;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // txtCard2
            // 
            this.txtCard2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCard2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCard2.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard2.ForeColor = System.Drawing.Color.Black;
            this.txtCard2.Location = new System.Drawing.Point(330, 165);
            this.txtCard2.MaxLength = 4;
            this.txtCard2.Name = "txtCard2";
            this.txtCard2.Size = new System.Drawing.Size(65, 32);
            this.txtCard2.TabIndex = 2;
            this.txtCard2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCard2.TextChanged += new System.EventHandler(this.txtCard2_TextChanged);
            this.txtCard2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtINT_KeyPress);
            // 
            // txtCard3
            // 
            this.txtCard3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCard3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCard3.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard3.ForeColor = System.Drawing.Color.Black;
            this.txtCard3.Location = new System.Drawing.Point(399, 165);
            this.txtCard3.MaxLength = 4;
            this.txtCard3.Name = "txtCard3";
            this.txtCard3.Size = new System.Drawing.Size(65, 32);
            this.txtCard3.TabIndex = 3;
            this.txtCard3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCard3.TextChanged += new System.EventHandler(this.txtCard3_TextChanged);
            this.txtCard3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtINT_KeyPress);
            // 
            // txtCard4
            // 
            this.txtCard4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCard4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCard4.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard4.ForeColor = System.Drawing.Color.Black;
            this.txtCard4.Location = new System.Drawing.Point(468, 165);
            this.txtCard4.MaxLength = 4;
            this.txtCard4.Name = "txtCard4";
            this.txtCard4.Size = new System.Drawing.Size(65, 32);
            this.txtCard4.TabIndex = 4;
            this.txtCard4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCard4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtINT_KeyPress);
            // 
            // addAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::boombroom.Properties.Resources.bg_addAccount;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(581, 372);
            this.ControlBox = false;
            this.Controls.Add(this.txtCard4);
            this.Controls.Add(this.txtCard3);
            this.Controls.Add(this.txtCard2);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCard1);
            this.Controls.Add(this.cbInstallment);
            this.Controls.Add(this.txtPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.ComboBox cbInstallment;
        private System.Windows.Forms.TextBox txtCard1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.TextBox txtCard2;
        private System.Windows.Forms.TextBox txtCard3;
        private System.Windows.Forms.TextBox txtCard4;
    }
}