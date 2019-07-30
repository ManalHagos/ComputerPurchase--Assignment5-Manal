using System;
using ComputerPurchase.Data;
using ComputerPurchase.Views;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerPurchase
{
    public static class Program
    {
        public static Product product;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static StartForm startForm;

        public static SplashScreen splashScreen;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            selectForm = new SelectForm();
            splashScreen = new SplashScreen();
            product = new Product();
            productInfoForm = new ProductInfoForm();
            startForm = new StartForm();

            Application.Run(splashScreen);
        }
    }
}
