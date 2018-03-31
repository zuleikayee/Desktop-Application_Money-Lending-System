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
    public partial class Admin : Form
    {
        public MySqlConnection conn;
        public Form refToLogin { get; set; }
        public addPayment addP;
        public int payID;
        private String name;
        private int cID;

        public Admin()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=boombroom;Uid=root;Pwd=root;");
            refreshDate();
        }

        private void refreshDate()
        {
            DateTime karon = new DateTime();
            karon = DateTime.Now;
            dtpBdate.MaxDate = DateTime.Now;
            dtpBdate.Value = karon;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
            timer.Start();
            
        }

        private void displayDT()
        {            
            lblDT.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt");
        }          

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            refToLogin.Show();            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            displayDT();
        }

        private void txtINT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFirst_Enter(object sender, EventArgs e)
        {
            txtFirst.Clear();
        }

        private void txtLast_Enter(object sender, EventArgs e)
        {
            txtLast.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool gora = true;
            if (txtFirst.Text.Equals("") || txtLast.Text.Equals("") || cbGender.SelectedItem == null || cbStatus.SelectedItem == null || txtHAd.Text.Equals("") || txtPin.Text.Equals("") || txtJob.Text.Equals("") || txtWAd.Text.Equals("")){
                MessageBox.Show("Please fill up required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                try{
                    String name = txtFirst.Text + " " + txtLast.Text;
                    char gender = cbGender.Text[0];
                    String civilstatus = cbStatus.Text; String homeaddress = txtHAd.Text; String workaddress = txtWAd.Text;
                    String job = txtJob.Text; String telephone = txtTel.Text; String phone = txtPhone.Text;
                    String birthdate = dtpBdate.Value.ToString("yyyy-MM-dd");
                    int pin = int.Parse(txtPin.Text);

                    // Check Pin Availability
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT pin_number FROM customer", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++){
                        if (pin == int.Parse(dt.Rows[i]["pin_number"].ToString())) gora = false;
                        else gora = true; 
                    }
                    //

                    if(gora){
                        comm = new MySqlCommand("INSERT into customer(customer_name, gender, civil_status, birthdate, home_address, job_description, working_address, tel_number, phone_number, pin_number, status)"
                                                        + " VALUES('" + name + "','" + gender + "','" + civilstatus + "','" + birthdate + "','"
                                                        + homeaddress + "','" + job + "','" + workaddress + "','" + telephone + "','" + phone
                                                        + "'," + pin + ", 'active')", conn);
                        comm.ExecuteNonQuery();

                        conn.Close();
                        clearTextBoxes();

                        MessageBox.Show("Customer Added Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        addAccount addaccount = new addAccount();
                        addaccount.currentCID = this.cID;
                        addaccount.Show();
                    }
                    else{
                        MessageBox.Show("Pin already taken.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
        }

        private void clearTextBoxes()
        {
            txtFirst.Text = "first"; txtLast.Text = "last";
            cbGender.SelectedIndex = 0; cbStatus.SelectedIndex = 0;
            txtHAd.Clear(); txtJob.Clear(); txtWAd.Clear(); txtTel.Clear(); txtPhone.Clear(); txtPin.Clear();
            refreshDate();
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text != null){
                try{
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT DISTINCT customerID, customer.customer_name, customer.status"
                                                        + " FROM customer"
                                                        + " WHERE customer.status = 'Active' AND customer.customer_name LIKE '%" + txtSearch.Text + "%'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    

                    dtCustomer.DataSource = dt;
                    dtCustomer.Columns["customerID"].Visible = false;
                    dtCustomer.Columns["customer_name"].HeaderText = "Name";                    
                    dtCustomer.Columns["customer_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dtCustomer.Columns["status"].HeaderText = "Status";
                    dtCustomer.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
            else MessageBox.Show("Please fill up search field.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }

        private void rbInactive_CheckedChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text != null){
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT DISTINCT customerID, customer.customer_name, customer.status"
                                                        + " FROM customer"
                                                        + " WHERE customer.status = 'inactive' AND customer.customer_name LIKE '%" + txtSearch.Text + "%'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    dtCustomer.DataSource = dt;
                    dtCustomer.Columns["customerID"].Visible = false;
                    dtCustomer.Columns["customer_name"].HeaderText = "Name";
                    dtCustomer.Columns["customer_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dtCustomer.Columns["status"].HeaderText = "Status";
                    dtCustomer.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    conn.Close();                    
                }
                catch (Exception ex){
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
            else MessageBox.Show("Please fill up search field.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            rbActive.Checked = false;
            rbInactive.Checked = false;
        }

        private void dtCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cID = int.Parse(dtCustomer.Rows[e.RowIndex].Cells["customerID"].Value.ToString());
            name = dtCustomer.Rows[e.RowIndex].Cells["customer_name"].Value.ToString();
            txtBalance.Text = "0";
            txtBorrowed.Text = "0";
            refreshAcc();
            checkAddAccount();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addAccount addaccount = new boombroom.addAccount();
            addaccount.ref_to_admin = this;
            addaccount.currentCID = this.cID;
            refreshAcc();
            addaccount.Show();
        }

        private void addP_Click(object sender, EventArgs e)
        {
            try {
                addP = new addPayment();
                addP.refToAdmin = this;
                addP.payActID = payID;
                addP.cID = this.cID;
                checkAddAccount();
                addP.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Select an Account");
            }
            
        }
        private void dtAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT payment.amountPaid, payment.payDate"
                                                    + " FROM payment INNER JOIN account ON account.accountID = payment.accountID", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                comm = new MySqlCommand("SELECT SUM(amountPaid)"
                                       + " FROM payment INNER JOIN account ON account.accountID = payment.accountID WHERE account.status = 'active'", conn);
                adp = new MySqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);

                txtTotalPaid.Text = dt.Rows[0]["SUM(amountPaid)"].ToString();
                
                addP = new addPayment();
                payID = int.Parse(dtAccount.Rows[e.RowIndex].Cells["accountID"].Value.ToString());
                conn.Close();
                checkAddAccount();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }

            refreshPay();
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        public void refreshAcc()
        {
            try{
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT account.accountID, account.money_lent, account.balance"
                                                    + " FROM account INNER JOIN customer ON account.customerID = customer.customerID"
                                                    + " WHERE customer.customer_name = '" + name + "' AND account.status = 'active'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dtAccount.DataSource = dt;

                dtAccount.Columns["accountID"].Visible = false;
                dtAccount.Columns["money_lent"].HeaderText = "Money Lent";                
                dtAccount.Columns["money_lent"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtAccount.Columns["balance"].HeaderText = "Balance";
                dtAccount.Columns["balance"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                comm = new MySqlCommand("SELECT SUM(money_lent), SUM(balance) FROM account INNER JOIN customer ON account.customerID = customer.customerID"
                                                    + " WHERE customer.customerID = " + cID + " AND account.status = 'active'", conn);
                adp = new MySqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);

                String totallent = dt.Rows[0]["SUM(money_lent)"].ToString();
                String totalbalance = dt.Rows[0]["SUM(balance)"].ToString();

                if (totallent != "" && totalbalance != "") {
                    txtBorrowed.Text = totallent;
                    txtBalance.Text = totalbalance;
                }
                else
                {
                    txtBorrowed.Text = "0";
                    txtBalance.Text = "0";
                }

                if (txtBorrowed.Text == "0" && txtBalance.Text == "0")
                {
                    comm = new MySqlCommand("UPDATE customer SET customer.status = 'inactive' WHERE customer.customerID = " + cID, conn);
                    comm.ExecuteNonQuery();
                } 
                
                conn.Close();
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        public void refreshPay(){
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT paymentID, amountPaid, payDate"
                                                    + " FROM payment INNER JOIN account ON payment.accountID = account.accountID"
                                                    + " WHERE account.accountID = " + payID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                payment.DataSource = dt;

                payment.Columns["paymentID"].Visible = false;
                payment.Columns["amountPaid"].HeaderText = "Amount Paid";
                payment.Columns["amountPaid"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                payment.Columns["payDate"].HeaderText = "Payment Date";
                payment.Columns["payDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                comm = new MySqlCommand("SELECT SUM(amountPaid) FROM payment INNER JOIN account ON account.accountID = payment.accountID"
                                                    + " WHERE account.accountID = " + payID, conn);
                adp = new MySqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);

                txtTotalPaid.Text = dt.Rows[0]["SUM(amountPaid)"].ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            
        }

        public void checkAddAccount()
        {            
                Boolean check = false;
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT account.balance, account.interest, account.money_lent FROM account WHERE account.customerID = " + cID , conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    double balance;
                    double lent;
                    double total;
                    double allLent;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        balance = double.Parse(dt.Rows[i]["balance"].ToString());
                        lent = double.Parse(dt.Rows[i]["money_lent"].ToString());
                        total = lent + (lent * double.Parse(dt.Rows[i]["interest"].ToString()));

                    //comm = new MySqlCommand("SELECT SUM(money_lent) FROM account WHERE account.customerID = " + cID, conn);
                        allLent = double.Parse(txtBorrowed.Text.ToString());

                        if (total / 2 > total - balance || allLent > 20000.00)
                        {
                            button3.Enabled = false;
                            break;
                        }
                        else
                        {
                            button3.Enabled = true;
                        }
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Select an Account. Error: " + ex.ToString());
                    conn.Close();
                }
                if (txtBalance.Text.Equals("") && txtBorrowed.Text.Equals("") && check == false)
                {
                    button3.Enabled = false;
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                UpdateCustomer upcust = new UpdateCustomer();

                MySqlCommand comm = new MySqlCommand("SELECT customer_name, civil_status, home_address, working_address, job_description, tel_number, phone_number FROM customer WHERE customerID = "  + cID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                upcust.txtName.Text = dt.Rows[0]["customer_name"].ToString();
                upcust.cbStatus.Text = dt.Rows[0]["civil_status"].ToString();
                upcust.txtTel.Text = dt.Rows[0]["tel_number"].ToString();
                upcust.txtPhone.Text = dt.Rows[0]["phone_number"].ToString();
                upcust.txtHome.Text = dt.Rows[0]["home_address"].ToString();
                upcust.txtWork.Text = dt.Rows[0]["working_address"].ToString();
                upcust.txtJob.Text = dt.Rows[0]["job_description"].ToString();

                upcust.cID = this.cID;
                upcust.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select A Customer");
            }

        }
       
    }

}
