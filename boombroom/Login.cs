using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace boombroom
{
    public partial class Login : Form
    {
        public MySqlConnection conn;
        public bool peek = false;

        public Login()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=boombroom;Uid=root;Pwd=root;");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pbLogo.BackgroundImage = new Bitmap(boombroom.Properties.Resources.login);
            pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            this.ActiveControl = txtP1;
            txtP2.Enabled = false; txtP3.Enabled = false; txtP4.Enabled = false; btnLogin.Enabled = false;
            if (txtP1.Text.Equals("") || txtP2.Text.Equals("") || txtP3.Text.Equals("") || txtP4.Text.Equals("")) {
                btnLogin.Enabled = false;
                btnLogin.BackgroundImage = new Bitmap(boombroom.Properties.Resources.btnLogin_false);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (peek) {
                btnPeek.BackgroundImage = new Bitmap(boombroom.Properties.Resources.close);
                btnPeek.BackgroundImageLayout = ImageLayout.Stretch;
                pbLogo.BackgroundImage = new Bitmap(boombroom.Properties.Resources.login_close);
                pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
                txtP1.PasswordChar = '\0'; txtP2.PasswordChar = '\0'; txtP3.PasswordChar = '\0'; txtP4.PasswordChar = '\0';
                txtP1.Font = new Font("Myriad Pro", 20); txtP2.Font = new Font("Myriad Pro", 20); txtP3.Font = new Font("Myriad Pro", 20); txtP4.Font = new Font("Myriad Pro", 20);
                peek = false;
            }
            else {
                btnPeek.BackgroundImage = new Bitmap(boombroom.Properties.Resources.open);
                btnPeek.BackgroundImageLayout = ImageLayout.Stretch;
                pbLogo.BackgroundImage = new Bitmap(boombroom.Properties.Resources.login);
                pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
                txtP1.PasswordChar = 'l'; txtP2.PasswordChar = 'l'; txtP3.PasswordChar = 'l'; txtP4.PasswordChar = 'l';
                txtP1.Font = new Font("Wingdings", 24); txtP2.Font = new Font("Wingdings", 24); txtP3.Font = new Font("Wingdings", 24); txtP4.Font = new Font("Wingdings", 24);
                peek = true;
            }
        }

        private void txtP1_TextChanged(object sender, EventArgs e)
        {
            txtP2.Focus();
            txtP2.Enabled = true; txtP1.Enabled = false;
        }

        private void txtP2_TextChanged(object sender, EventArgs e)
        {
            txtP3.Focus();
            txtP3.Enabled = true; txtP2.Enabled = false;
        }

        private void txtP3_TextChanged(object sender, EventArgs e)
        {
            txtP4.Focus();
            txtP4.Enabled = true; txtP3.Enabled = false;
        }

        private void txtP4_TextChanged(object sender, EventArgs e)
        {
            txtP4.Enabled = false;
            btnLogin.Enabled = true;
            btnLogin.Focus();
            btnLogin.BackgroundImage = new Bitmap(boombroom.Properties.Resources.btnLogin);
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtP1.Clear(); txtP2.Clear(); txtP3.Clear(); txtP4.Clear();
            txtP1.Enabled = true; txtP1.Focus();
            txtP2.Enabled = false; txtP3.Enabled = false; txtP4.Enabled = false;
            btnLogin.Enabled = false;
            btnLogin.BackgroundImage = new Bitmap(boombroom.Properties.Resources.btnLogin_false);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CustomerAccount CA = new CustomerAccount();
            int pinfinal = int.Parse(txtP1.Text.ToString() + txtP2.Text.ToString() + txtP3.Text.ToString() + txtP4.Text.ToString());
            int customerID = 0;

            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT customerID, pin_number FROM customer WHERE pin_number = " + pinfinal, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count != 0) {
                    for (int i = 0; i < dt.Rows.Count; i++) {
                        customerID = int.Parse(dt.Rows[i]["customerID"].ToString());
                    }

                    conn.Close();

                    CA.refToLogin = this;
                    CA.cID = customerID;
                    CA.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Pin number does not exist or invalid pin number.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        

        private void txtAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11) {
                Admin admin = new Admin();
                admin.Show();
                admin.refToLogin = this;
                this.Hide();
            }
        }

        private void txtP4_Enter(object sender, EventArgs e)
        {
            
        }

        private void enter_KeyPress()
        {
            if (txtP4.Text.Equals("") || btnLogin.Enabled == false)
            {
                MessageBox.Show("Please Enter Required Fields");
            }
            else
            {
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            enter_KeyPress();
        }
    }
}
