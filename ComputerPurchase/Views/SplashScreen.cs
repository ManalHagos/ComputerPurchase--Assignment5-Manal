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
    public partial class SplashScreen : Form
    {
        public StartForm startForm;
        public SplashScreen()
        {
            InitializeComponent();
            startForm = new StartForm();

      
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           timer.Enabled = false;
           this.Hide();
           startForm.Show();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }
    }
}
