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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        //declaring global variable
        int indexRow;
        int orderNumber = 0;
        int itemPrice;
        int sales = 0;
        string currentDate, currentTime;
        


        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentDate = Convert.ToString(lblcurrentDate.Text = DateTime.Now.ToLongDateString());
            currentTime = Convert.ToString(lblTime.Text = DateTime.Now.ToLongTimeString());
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            //this convert combo box to string to be manipulated
            int quantity = Convert.ToInt32(qty.Text);
            string item = cmboBoxOrder.Text;
            string drinkSize = cmboSize.Text;

            //this if else statement computes the price of the order
            if (item == "Fried Chicken" && drinkSize == "Large")
            {
                int friedChicken = 110;
                int largeDrink = 15;
                int itemPriceQty = (friedChicken * quantity) + (largeDrink * quantity);
                itemPrice = itemPriceQty;
            }
            else if (item == "Fried Chicken" && drinkSize == "Regular")
            {
                int friedChicken = 110;
                int itemPriceQty = friedChicken * quantity;
                itemPrice = itemPriceQty;
            }
            else if (item == "Pork Sinigang" && drinkSize == "Large")
            {
                int porkSinigang = 90;
                int largeDrink = 15;
                int itemPriceQty = (porkSinigang * quantity) + (largeDrink * quantity);
                itemPrice = itemPriceQty;
            }
            else if (item == "Pork Sinigang" && drinkSize == "Regular")
            {
                int porkSinigang = 90;
                int itemPriceQty = porkSinigang * quantity;
                itemPrice = itemPriceQty;
            }
            else if (item == "Fish Sinigang" && drinkSize == "Large")
            {
                int fishSinigang = 90;
                int largeDrink = 15;
                int itemPriceQty = (fishSinigang * quantity) + (largeDrink * quantity);
                itemPrice = itemPriceQty;
            }
            else if (item == "Fish Sinigang" && drinkSize == "Regular")
            {
                int fishSinigang = 90;
                int itemPriceQty = fishSinigang * quantity;
                itemPrice = itemPriceQty;
            }
            else if (item == "Barbecue" && drinkSize == "Large")
            {
                int barbecue = 40;
                int largeDrink = 15;
                int itemPriceQty = (barbecue * quantity) + (largeDrink * quantity);
                itemPrice = itemPriceQty;
            }
            else if (item == "Barbecue" && drinkSize == "Regular")
            {
                int barbecue = 40;
                int itemPriceQty = barbecue * quantity;
                itemPrice = itemPriceQty;
            }
            //checks if fields have data
            if (cmboBoxOrder.Text == "" && cmboDrink.Text == "" && cmboSize.Text == "")
            {
                MessageBox.Show("You've not selected yet a menu yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmboBoxOrder.Text == "" && cmboDrink.Text == "")
            {
                MessageBox.Show("PLease input the missing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmboDrink.Text == "" && cmboSize.Text == "")
            {
                MessageBox.Show("PLease input the missing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmboBoxOrder.Text == "" && cmboSize.Text == "")
            {
                MessageBox.Show("PLease input the missing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmboBoxOrder.Text == "")
            {
                MessageBox.Show("PLease input the missing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmboDrink.Text == "")
            {
                MessageBox.Show("PLease input the missing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmboSize.Text == "")
            {
                MessageBox.Show("PLease input the missing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //this if else is to avoid redundancy of cashier name and time of order
            else
            {
                lblSales.Text = Convert.ToString(sales += itemPrice);

                dataGridView.Rows.Add(quantity, cmboBoxOrder.Text+"/"+cmboDrink.Text+cmboSize.Text[0], itemPrice);
                cmboBoxOrder.Text = "";
                cmboDrink.Text = "";
                cmboSize.Text = "";
                qty.Text = "1";
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //this allows the cashier to choose cell where to manipulate
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView.Rows[indexRow];
        }

        private void btn_EditOrder_Click(object sender, EventArgs e)
        {

        }

        private void btn_DeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                //ask the user if he/she wants to delete the selected row
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //delete row from the datagridview
                    int rowIndex = dataGridView.CurrentCell.RowIndex;
                    dataGridView.Rows.RemoveAt(rowIndex);
                }
            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this is the log-out button it asks the cashier if he/she wants to exit the program
            if (MessageBox.Show("Are you sure you want to Quit?", "Exit the Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_CreateReceipt_Click(object sender, EventArgs e)
        {
            


            if (txtCashRecieved.Text == "")
            {
                MessageBox.Show("Please Fill the cash area", "Please state Cash recieced", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtCashRecieved.Text) < Convert.ToInt32(lblSales.Text))
            {
                MessageBox.Show("Not enought cash", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int change = Convert.ToInt32(txtCashRecieved.Text) - Convert.ToInt32(lblSales.Text);
                //order num increments in every receipt
                orderNumber++;
                //instantiate receipt form
                Receipt receiptPreview = new Receipt();
                //this fills the important data on the receipt
                receiptPreview.lblcashierCharge.Text = "Cashier: "+lblCashierIncharge.Text;
                receiptPreview.lblorderDate.Text = DateTime.Now.ToShortDateString();
                receiptPreview.lbltimeDate.Text = currentTime;
                receiptPreview.lblTotalCost.Text = "Php"+lblSales.Text;
                receiptPreview.lblOrderNum.Text = Convert.ToString("Order No. "+orderNumber);
                receiptPreview.lblCash.Text = "Php"+txtCashRecieved.Text;
                receiptPreview.lblChange.Text = Convert.ToString("Php"+change);

                //this code transfer the data from the datagrid to the receipt
                int n = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (dataGridView.Rows.Count != n + 1)
                    {
                        receiptPreview.dataGridReceipt.Rows.Add();
                        receiptPreview.dataGridReceipt.Rows[n].Cells[0].Value = row.Cells[0].Value.ToString();
                        receiptPreview.dataGridReceipt.Rows[n].Cells[1].Value = row.Cells[1].Value.ToString();
                        receiptPreview.dataGridReceipt.Rows[n].Cells[2].Value = row.Cells[2].Value.ToString();
                    }
                    n += 1;
                }

                receiptPreview.Show();

                txtCashRecieved.Text = "";
                dataGridView.Rows.Clear();
                lblSales.Text = "000";

            }
        }
    }
}
