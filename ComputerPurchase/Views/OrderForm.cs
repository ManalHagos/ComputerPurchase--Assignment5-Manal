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

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        public void FillForm(List<string> info)
        {
            PlatFormBox.Text = info[0];
            ManufacturerBox.Text = info[1];
            ConditionBox.Text = info[2];
            ModelBox.Text = info[3];
            richTextBox.Text = info[4] + "\n\n" + info[5];
            PriceTextBox.Text = "$" + info[6];
            SalesTextBox.Text = (decimal.Parse(info[6]) * 0.13M).ToString("c");
            TotalTextBox.Text = (decimal.Parse(info[6]) + (decimal.Parse(info[6]) * .13m)).ToString("c");
            //richTextBox.Text = info[5];

        }
    }
}
