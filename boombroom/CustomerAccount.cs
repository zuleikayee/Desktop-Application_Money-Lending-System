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
    public partial class CustomerAccount : Form
    {
        public Form refToLogin { get; set; }
        public MySqlConnection conn;
        public int aID;
        public int cID;
        public CustomerAccount()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=boombroom;Uid=root;Pwd=root;");
        }

        private void CustomerAccount_Load(object sender, EventArgs e)
        {
            String bdate;
            try{
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM customer WHERE customerID = " + cID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                lblName.Text = dt.Rows[0]["customer_name"].ToString();
                bdate = dt.Rows[0]["birthdate"].ToString();
                lblBdate.Text = bdate.Substring(0, 10);

                comm = new MySqlCommand("SELECT COUNT(*) FROM account WHERE account.customerID = " + cID + " AND account.status = 'active'", conn);
                adp = new MySqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);

                lblActive.Text = dt.Rows[0]["COUNT(*)"].ToString();

                comm = new MySqlCommand("SELECT account.accountID, account.money_lent, account.interest, account.installment FROM account WHERE account.status = 'active' AND account.customerID = " + cID , conn);
                adp = new MySqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);

                dgvAccount.DataSource = dt;
                
                dgvAccount.Columns["accountID"].Visible = false;
                dgvAccount.Columns["money_lent"].HeaderText = "Money Lent";
                dgvAccount.Columns["money_lent"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAccount.Columns["interest"].Visible = false;
                dgvAccount.Columns["installment"].HeaderText = "Installment (Months)";
                dgvAccount.Columns["installment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            refToLogin.Show();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aID = int.Parse(dgvAccount.Rows[e.RowIndex].Cells["accountID"].Value.ToString());
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT account.accountID, account.card_numbers, account.money_lent, account.balance, account.installment FROM account WHERE account.status = 'active' AND account.accountID = " + aID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                txtCard.Text = dt.Rows[0]["card_numbers"].ToString();
                txtBal.Text = dt.Rows[0]["balance"].ToString();
                txtLent.Text = dt.Rows[0]["money_lent"].ToString();

                comm = new MySqlCommand("SELECT SUM(payment.amountPaid) FROM payment WHERE payment.accountID = " + aID, conn);
                adp = new MySqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);

                txtPaid.Text = dt.Rows[0]["SUM(payment.amountPaid)"].ToString();

                comm = new MySqlCommand("SELECT payment.amountPaid, payment.payDate FROM payment WHERE payment.accountID = " + aID, conn);
                adp = new MySqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);

                dgvPayment.DataSource = dt;
                dgvPayment.Columns["amountPaid"].HeaderText = "Amount Paid";
                dgvPayment.Columns["amountPaid"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvPayment.Columns["payDate"].HeaderText = "Payment Date";
                dgvPayment.Columns["payDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
