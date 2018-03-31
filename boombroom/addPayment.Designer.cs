namespace boombroom
{
    partial class addPayment
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBal = new System.Windows.Forms.TextBox();
            this.txtAmtPay = new System.Windows.Forms.TextBox();
            this.dtpPdate = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(131)))), ((int)(((byte)(155)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(245, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 42);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(49, 319);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Payment";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtBal
            // 
            this.txtBal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBal.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBal.ForeColor = System.Drawing.Color.Black;
            this.txtBal.Location = new System.Drawing.Point(220, 166);
            this.txtBal.MaxLength = 16;
            this.txtBal.Name = "txtBal";
            this.txtBal.ReadOnly = true;
            this.txtBal.Size = new System.Drawing.Size(212, 32);
            this.txtBal.TabIndex = 0;
            this.txtBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmtPay
            // 
            this.txtAmtPay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAmtPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmtPay.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmtPay.ForeColor = System.Drawing.Color.Black;
            this.txtAmtPay.Location = new System.Drawing.Point(220, 243);
            this.txtAmtPay.MaxLength = 16;
            this.txtAmtPay.Name = "txtAmtPay";
            this.txtAmtPay.Size = new System.Drawing.Size(212, 32);
            this.txtAmtPay.TabIndex = 1;
            this.txtAmtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmtPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMONEY_KeyPress);
            // 
            // dtpPdate
            // 
            this.dtpPdate.CustomFormat = "yyyy-MM-dd";
            this.dtpPdate.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPdate.Location = new System.Drawing.Point(220, 91);
            this.dtpPdate.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.dtpPdate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpPdate.Name = "dtpPdate";
            this.dtpPdate.Size = new System.Drawing.Size(212, 30);
            this.dtpPdate.TabIndex = 7;
            this.dtpPdate.Value = new System.DateTime(2017, 2, 17, 0, 0, 0, 0);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = global::boombroom.Properties.Resources.eraser;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(438, 245);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(30, 30);
            this.btnClear.TabIndex = 2;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // addPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::boombroom.Properties.Resources.bg_addPay;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(480, 372);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtpPdate);
            this.Controls.Add(this.txtAmtPay);
            this.Controls.Add(this.txtBal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addPayment_FormClosing);
            this.Load += new System.EventHandler(this.addPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBal;
        private System.Windows.Forms.TextBox txtAmtPay;
        private System.Windows.Forms.DateTimePicker dtpPdate;
        private System.Windows.Forms.Button btnClear;
    }
}