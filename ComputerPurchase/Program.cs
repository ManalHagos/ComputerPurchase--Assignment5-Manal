using ComputerPurchase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerPurchase
{
    public static class Program
    {
        public static Product product;

        public static SplashScreen splashScreen;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            product = new Product();

            splashScreen = new SplashScreen();

            Application.Run(splashScreen);
        }
    }
}
