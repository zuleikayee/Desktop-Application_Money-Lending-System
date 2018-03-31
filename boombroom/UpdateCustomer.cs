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
    public partial class UpdateCustomer : Form
    {
        public MySqlConnection conn;
        public int cID;
        public UpdateCustomer()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=boombroom;Uid=root;Pwd=root;");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtHome.Text != "" && txtJob.Text != "" && txtName.Text != "" && txtWork.Text != "" && cbStatus.SelectedIndex != 0)
            {
                try
                {
                    String name = txtName.Text;
                    String civil = cbStatus.Text;
                    String job = txtJob.Text;
                    String work = txtWork.Text;
                    String home = txtHome.Text;
                    String tele = txtTel.Text;
                    String phone = txtPhone.Text;

                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("UPDATE customer SET customer_name = '" + name + "', civil_status = '" + civil + "', job_description = '" + job + "', working_address = '" + work + "', home_address = '" + home + "', tel_number = '" + tele + "', phone_number = '" + phone +"' WHERE customerID = " + cID , conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated customer");
                    this.Close();
                    conn.Close();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Please enter requires fields");
            }
        }
    }
}
