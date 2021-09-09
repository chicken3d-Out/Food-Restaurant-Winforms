using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace FastFood_Order_Management_System
{
    public partial class Receipt : Form
    {
        PrintPreviewDialog printPreiew = new PrintPreviewDialog();
        PrintDocument printDoc = new PrintDocument();

        public Receipt()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
        //this is for the event when the print button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            Print(this.panelReceipt);
            this.Hide();
        }
        public void Print (Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelReceipt = pnl;
            getprintarea(pnl);
            printPreiew.Document = printDoc;
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_printpage);
            printPreiew.ShowDialog();

        }
        public void printDoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryImg,(pagearea.Width/2)-(this.panelReceipt.Width/2), this.panelReceipt.Location.Y);
        }
        Bitmap memoryImg;
        public void getprintarea(Panel pnl)
        {
            memoryImg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryImg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
    }
}
