﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComputerPurchase.Views
{
    public partial class SplashScreen : Form
    {
       
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           timer.Enabled = false;
           Program.splashScreen.Hide();
           Program.startForm.Show();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }
    }
}
