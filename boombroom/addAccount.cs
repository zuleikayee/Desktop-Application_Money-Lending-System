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
    public partial class addAccount : Form
    {
        private bool dot = false;
        public int count = 3, currentCID;
        public Admin ref_to_admin { get; set; }
        public MySqlConnection conn;

        public addAccount()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=boombroom;Uid=root;Pwd=root;");

            try{
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT customerID FROM customer", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                currentCID = int.Parse(dt.Rows[dt.Rows.Count - 1]["customerID"].ToString());
                conn.Close();
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
                conn.Close();
            }                                            
        }

        private void txtMONEY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && !dot)
            {
                e.Handled = !(e.KeyChar == '.');
                dot = true;
            }
            else e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (dot) count--;            
            if (count == 0) txtPay.Enabled = false;
        }

        private void txtINT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPay.Enabled = true;
            txtPay.Clear();
            this.ActiveControl = txtPay;
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtCard1.Clear(); txtCard2.Clear(); txtCard3.Clear(); txtCard4.Clear();
            this.ActiveControl = txtCard1;
        }

        private void txtCard1_TextChanged(object sender, EventArgs e)
        {
            if(txtCard1.TextLength == txtCard1.MaxLength) txtCard2.Focus();
        }

        private void txtCard2_TextChanged(object sender, EventArgs e)
        {
            if (txtCard2.TextLength == txtCard2.MaxLength) txtCard3.Focus();
        }

        private void txtCard3_TextChanged(object sender, EventArgs e)
        {
            if (txtCard3.TextLength == txtCard3.MaxLength) txtCard4.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addAccount_FormClosing(object sender, FormClosedEventArgs e)
        {
            ref_to_admin.refreshAcc();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtPay.Text.Equals("") || cbInstallment.SelectedItem == null){
                MessageBox.Show("Please fill up search field.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(double.Parse(txtPay.Text.ToString()) > 20000){
                MessageBox.Show("Cannot Lend More Than 20,000.00", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                try{
                    int installment = 0;
                    double interest = 0;
                    String card_numbers = txtCard1.Text.ToString() + txtCard2.Text.ToString() + txtCard3.Text.ToString() + txtCard4.Text.ToString();

                    if (cbInstallment.SelectedIndex == 1){
                        interest = 0.07;
                        installment = 6;
                    }
                    else if (cbInstallment.SelectedIndex == 2){
                        interest = 0.05;
                        installment = 3;
                    }
                    else if (cbInstallment.SelectedIndex == 3){
                        interest = 0.03;
                        installment = 1;
                    }

                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("INSERT into account(customerID, card_numbers, money_lent, status, interest, installment, balance)"
                                                        + " VALUES(" + currentCID + ",'" + card_numbers + "'," + txtPay.Text.ToString() + ",'active',"
                                                        + interest + "," + installment + "," + (double.Parse(txtPay.Text) + double.Parse(txtPay.Text) * interest) + ")", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Account Added Successfully.");
                    this.Close();                    
                }
                catch (Exception ex){
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }

            }
        }
    }
}
