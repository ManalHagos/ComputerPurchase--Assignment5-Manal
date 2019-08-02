using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerPurchase.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            var _result = openFileDialog.ShowDialog();
            if (_result != DialogResult.Cancel)
            {
                // open file stream to read
                using (StreamReader inputStream = new StreamReader(
                    File.Open(openFileDialog.FileName, FileMode.Open)))
                {
                    // read stuff from the file into the Student object
                    Program.product.productID = short.Parse(inputStream.ReadLine());
                    Program.product.manufacturer = inputStream.ReadLine();
                }


            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            Program.selectForm.Hide();
        }

        private void AnotherProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }
    }
}
