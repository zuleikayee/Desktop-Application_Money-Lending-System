namespace boombroom
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtP4 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtP3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(394, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(155, 363);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLogin_KeyPress);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(125, 31);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(183, 151);
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::boombroom.Properties.Resources.pin_bg;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.txtP4);
            this.panel4.Location = new System.Drawing.Point(299, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 75);
            this.panel4.TabIndex = 11;
            // 
            // txtP4
            // 
            this.txtP4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtP4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtP4.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtP4.ForeColor = System.Drawing.Color.White;
            this.txtP4.Location = new System.Drawing.Point(18, 20);
            this.txtP4.Name = "txtP4";
            this.txtP4.PasswordChar = 'l';
            this.txtP4.Size = new System.Drawing.Size(40, 36);
            this.txtP4.TabIndex = 3;
            this.txtP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtP4.TextChanged += new System.EventHandler(this.txtP4_TextChanged);
            this.txtP4.Enter += new System.EventHandler(this.txtP4_Enter);
            this.txtP4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdmin_KeyDown);
            this.txtP4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPin_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::boombroom.Properties.Resources.pin_bg;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.txtP3);
            this.panel3.Location = new System.Drawing.Point(218, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 75);
            this.panel3.TabIndex = 10;
            // 
            // txtP3
            // 
            this.txtP3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtP3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtP3.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtP3.ForeColor = System.Drawing.Color.White;
            this.txtP3.Location = new System.Drawing.Point(18, 20);
            this.txtP3.Name = "txtP3";
            this.txtP3.PasswordChar = 'l';
            this.txtP3.Size = new System.Drawing.Size(40, 36);
            this.txtP3.TabIndex = 2;
            this.txtP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtP3.TextChanged += new System.EventHandler(this.txtP3_TextChanged);
            this.txtP3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdmin_KeyDown);
            this.txtP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPin_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::boombroom.Properties.Resources.pin_bg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtP2);
            this.panel2.Location = new System.Drawing.Point(137, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 75);
            this.panel2.TabIndex = 9;
            // 
            // txtP2
            // 
            this.txtP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtP2.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtP2.ForeColor = System.Drawing.Color.White;
            this.txtP2.Location = new System.Drawing.Point(18, 20);
            this.txtP2.Name = "txtP2";
            this.txtP2.PasswordChar = 'l';
            this.txtP2.Size = new System.Drawing.Size(40, 36);
            this.txtP2.TabIndex = 1;
            this.txtP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtP2.TextChanged += new System.EventHandler(this.txtP2_TextChanged);
            this.txtP2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdmin_KeyDown);
            this.txtP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPin_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::boombroom.Properties.Resources.pin_bg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtP1);
            this.panel1.Location = new System.Drawing.Point(56, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 75);
            this.panel1.TabIndex = 8;
            // 
            // txtP1
            // 
            this.txtP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtP1.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtP1.ForeColor = System.Drawing.Color.White;
            this.txtP1.Location = new System.Drawing.Point(18, 21);
            this.txtP1.Name = "txtP1";
            this.txtP1.PasswordChar = 'l';
            this.txtP1.Size = new System.Drawing.Size(40, 36);
            this.txtP1.TabIndex = 0;
            this.txtP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtP1.TextChanged += new System.EventHandler(this.txtP1_TextChanged);
            this.txtP1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdmin_KeyDown);
            this.txtP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPin_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = global::boombroom.Properties.Resources.btnClear;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(155, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.BackColor = System.Drawing.Color.Transparent;
            this.btnPeek.BackgroundImage = global::boombroom.Properties.Resources.open;
            this.btnPeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPeek.FlatAppearance.BorderSize = 0;
            this.btnPeek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPeek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeek.Location = new System.Drawing.Point(155, 304);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(125, 40);
            this.btnPeek.TabIndex = 14;
            this.btnPeek.TabStop = false;
            this.btnPeek.UseVisualStyleBackColor = false;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(432, 489);
            this.ControlBox = false;
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.TextBox txtP3;
        private System.Windows.Forms.TextBox txtP4;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPeek;
    }
}

