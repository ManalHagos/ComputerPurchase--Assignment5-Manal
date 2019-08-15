using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * CompuuterPurchase
 * Manal Hagos
 * 301027317
 * JULY/28/2019
 * THIS IS THE StartForm
 */

namespace ComputerPurchase.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// to hide startForm and show selectForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrder_Click(object sender, EventArgs e)
        {
            Program.startForm.Hide();
            Program.selectForm.Show();
        }
        //to startForm and show productInfoForm
        private void SavedOrder_Click(object sender, EventArgs e)
        {
            Program.startForm.Hide();
            Program.productInfoForm.Show();
        }
        // to exit from the page
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
