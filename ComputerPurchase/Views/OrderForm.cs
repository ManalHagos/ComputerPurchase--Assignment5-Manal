using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * CompuuterPurchase
 * Manal Hagos
 * 301027317
 * JULY/28/2019
 * THIS IS THE OrderForm
 */

namespace ComputerPurchase.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }
        // to print
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }
        // to exit using exit tool strip menue 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //to exit using cancel button
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("thank you for your business and your order will be processed in 7-10 business days");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.Show();
        }
        // to display the user input in orderForm
        public void FillForm(List<string> info)
        {
            PlatFormBox.Text = info[0];
            ManufacturerBox.Text = info[1];
            ConditionBox.Text = info[2];
            ModelBox.Text = info[3];
            richTextBox.Text = info[4] + "\n\n" + info[5];/* + "\n\n" + info[10]; + "\n\n" + info[11] + "\n\n" + info[13];/* + "\n\n" +
            info[12] +"\n\n"+info[17]+"\n\n"+info[19]+"\n\n"+info[30];*/
            PriceTextBox.Text = "$" + info[6];
            SalesTextBox.Text = (decimal.Parse(info[6]) * 0.13M).ToString("c");
            TotalTextBox.Text = (decimal.Parse(info[6]) + (decimal.Parse(info[6]) * .13m)).ToString("c");
           

        }
    }
}
