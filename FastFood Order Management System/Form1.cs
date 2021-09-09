using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood_Order_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmboBoxCashier.Text == "" && txtUsername.Text == "" && txtPassword.Text == "" )
            {
                MessageBox.Show("Please Fill the blank Data", "Missing Data",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmboBoxCashier.Text == "")
            {
                MessageBox.Show("Please Fill the blank Data", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Please Fill the blank Data", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Fill the blank Data", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmboBoxCashier.Text == "" && txtUsername.Text == "")
            {
                MessageBox.Show("Please Fill the blank Data", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please Fill the blank Data", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmboBoxCashier.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please Fill the blank Data", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text != "admin" && txtPassword.Text != "admin")
            {
                MessageBox.Show("Username or Password is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text != "admin" && txtPassword.Text == "admin")
            {
                MessageBox.Show("Username is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text == "admin" && txtPassword.Text != "admin")
            {
                MessageBox.Show("Password is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text == "admin" && txtPassword.Text == "admin" && cmboBoxCashier.Text == "")
            {
                MessageBox.Show("Fill the cashier in-charge field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.lblCashierIncharge.Text = cmboBoxCashier.Text;
                dashboard.Show();

                this.Hide();
            }
        }
    }
}
