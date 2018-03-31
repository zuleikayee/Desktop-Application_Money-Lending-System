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
    public partial class addPayment : Form
    {
        private bool dot = false;
        private int count = 3;
        public int payActID;
        public int cID;
        
        public Admin refToAdmin { get; set; }

        public MySqlConnection conn;

        public addPayment()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=boombroom;Uid=root;Pwd=root;");            
        }

        private void txtMONEY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && !dot){
                e.Handled = !(e.KeyChar == '.');
                dot = true;
            }
            else e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if(dot) count--;            
            if(count == 0) txtAmtPay.Enabled = false;
                   
        }

        private void addPayment_Load(object sender, EventArgs e)
        {
            this.ActiveControl = dtpPdate;
            dtpPdate.MaxDate = DateTime.Now;

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT balance FROM account WHERE accountID = " + payActID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                txtBal.Text = dt.Rows[0]["balance"].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show("Please Select an Account");
                
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmtPay.Enabled = true;
            txtAmtPay.Clear();
            this.ActiveControl = txtAmtPay;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (double.Parse(txtBal.Text.ToString()) >= double.Parse(txtAmtPay.Text.ToString()))
            {
                try
                {
                    conn.Open();
                    String date = dtpPdate.Value.ToString();
                    MySqlCommand comm = new MySqlCommand("INSERT INTO payment(accountID, amountPaid, payDate) VALUES(" + payActID + ", " + double.Parse(txtAmtPay.Text.ToString()) + ",'" + date.Substring(0, 10) + "')", conn);
                    comm.ExecuteNonQuery();

                    comm = new MySqlCommand("UPDATE account SET balance = balance - " + double.Parse(txtAmtPay.Text.ToString()) + " WHERE accountID = " + payActID, conn);
                    comm.ExecuteNonQuery();

                    if (double.Parse(txtBal.Text.ToString()) - double.Parse(txtAmtPay.Text.ToString()) == 0)
                    {
                        comm = new MySqlCommand("UPDATE account SET status = 'inactive' WHERE accountID = " + payActID, conn);
                        comm.ExecuteNonQuery();
                    }

                    comm = new MySqlCommand("SELECT COUNT(*) FROM account WHERE customerID = " + cID + " AND account.status = 'active'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    int num = int.Parse(dt.Rows[0]["COUNT(*)"].ToString());
                    if (num == 0){
                        comm = new MySqlCommand("UPDATE customer SET customer.status = 'inactive' WHERE customer.customerID = " + cID, conn);
                    }

                    
                    conn.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("CANNOT OVERPAY!", "");
            }
        }

        private void addPayment_FormClosing(object sender, FormClosingEventArgs e)
        {

            refToAdmin.refreshPay();
            refToAdmin.refreshAcc();
            refToAdmin.checkAddAccount();
        }
    }
}
