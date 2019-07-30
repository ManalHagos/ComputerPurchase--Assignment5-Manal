using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerPurchase
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SavedOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
