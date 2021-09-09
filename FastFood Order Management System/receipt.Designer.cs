
namespace FastFood_Order_Management_System
{
    partial class Receipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelReceipt = new System.Windows.Forms.Panel();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.dataGridReceipt = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltimeDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblorderDate = new System.Windows.Forms.Label();
            this.lblcashierCharge = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReceipt
            // 
            this.panelReceipt.BackColor = System.Drawing.Color.White;
            this.panelReceipt.Controls.Add(this.lblChange);
            this.panelReceipt.Controls.Add(this.lblCash);
            this.panelReceipt.Controls.Add(this.dataGridReceipt);
            this.panelReceipt.Controls.Add(this.lbltimeDate);
            this.panelReceipt.Controls.Add(this.label6);
            this.panelReceipt.Controls.Add(this.label14);
            this.panelReceipt.Controls.Add(this.label12);
            this.panelReceipt.Controls.Add(this.label8);
            this.panelReceipt.Controls.Add(this.label4);
            this.panelReceipt.Controls.Add(this.label5);
            this.panelReceipt.Controls.Add(this.label15);
            this.panelReceipt.Controls.Add(this.lblTotalCost);
            this.panelReceipt.Controls.Add(this.label13);
            this.panelReceipt.Controls.Add(this.lblorderDate);
            this.panelReceipt.Controls.Add(this.lblcashierCharge);
            this.panelReceipt.Controls.Add(this.lblOrderNum);
            this.panelReceipt.Controls.Add(this.label3);
            this.panelReceipt.Controls.Add(this.label2);
            this.panelReceipt.Controls.Add(this.label1);
            this.panelReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.panelReceipt.Location = new System.Drawing.Point(12, 12);
            this.panelReceipt.Name = "panelReceipt";
            this.panelReceipt.Size = new System.Drawing.Size(183, 521);
            this.panelReceipt.TabIndex = 0;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblChange.Location = new System.Drawing.Point(129, 453);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(50, 15);
            this.lblChange.TabIndex = 12;
            this.lblChange.Text = "Change";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCash.Location = new System.Drawing.Point(129, 429);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(35, 15);
            this.lblCash.TabIndex = 11;
            this.lblCash.Text = "Cash";
            // 
            // dataGridReceipt
            // 
            this.dataGridReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReceipt.BackgroundColor = System.Drawing.Color.White;
            this.dataGridReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridReceipt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridReceipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantity,
            this.Item,
            this.Price});
            this.dataGridReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridReceipt.EnableHeadersVisualStyles = false;
            this.dataGridReceipt.Location = new System.Drawing.Point(11, 122);
            this.dataGridReceipt.Name = "dataGridReceipt";
            this.dataGridReceipt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridReceipt.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridReceipt.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridReceipt.Size = new System.Drawing.Size(164, 246);
            this.dataGridReceipt.TabIndex = 10;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty.";
            this.Quantity.Name = "Quantity";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // lbltimeDate
            // 
            this.lbltimeDate.AutoSize = true;
            this.lbltimeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbltimeDate.Location = new System.Drawing.Point(122, 93);
            this.lbltimeDate.Name = "lbltimeDate";
            this.lbltimeDate.Size = new System.Drawing.Size(30, 13);
            this.lbltimeDate.TabIndex = 2;
            this.lbltimeDate.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "_________________________";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "_________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "_________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "_________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(8, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Change";
            this.label4.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(8, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cash";
            this.label5.Click += new System.EventHandler(this.label9_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label15.Location = new System.Drawing.Point(8, 393);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Total";
            this.label15.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalCost.Location = new System.Drawing.Point(129, 393);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(30, 15);
            this.lblTotalCost.TabIndex = 2;
            this.lblTotalCost.Text = "total";
            this.lblTotalCost.Click += new System.EventHandler(this.label9_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(4, 494);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "THANK YOU COME AGAIN!";
            this.label13.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblorderDate
            // 
            this.lblorderDate.AutoSize = true;
            this.lblorderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblorderDate.Location = new System.Drawing.Point(11, 93);
            this.lblorderDate.Name = "lblorderDate";
            this.lblorderDate.Size = new System.Drawing.Size(30, 13);
            this.lblorderDate.TabIndex = 2;
            this.lblorderDate.Text = "Date";
            // 
            // lblcashierCharge
            // 
            this.lblcashierCharge.AutoSize = true;
            this.lblcashierCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblcashierCharge.Location = new System.Drawing.Point(11, 80);
            this.lblcashierCharge.Name = "lblcashierCharge";
            this.lblcashierCharge.Size = new System.Drawing.Size(52, 15);
            this.lblcashierCharge.TabIndex = 2;
            this.lblcashierCharge.Text = "Cashier:";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.Location = new System.Drawing.Point(56, 64);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(75, 16);
            this.lblOrderNum.TabIndex = 2;
            this.lblOrderNum.Text = "Order No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "(+639) 654217393";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "6513, San Roque, Santa Fe Leyte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS Studio\'s Fastfood Chain";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(67, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(207, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelReceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "receipt";
            this.panelReceipt.ResumeLayout(false);
            this.panelReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceipt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReceipt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lbltimeDate;
        public System.Windows.Forms.Label lblorderDate;
        public System.Windows.Forms.Label lblcashierCharge;
        public System.Windows.Forms.Label lblOrderNum;
        public System.Windows.Forms.Label lblTotalCost;
        public System.Windows.Forms.DataGridView dataGridReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        public System.Windows.Forms.Label lblChange;
        public System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}