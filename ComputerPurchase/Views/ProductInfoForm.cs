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
/*
 * CompuuterPurchase
 * Manal Hagos
 * 301027317
 * JULY/28/2019
 * THIS IS THE ProductInfoForm
 */

namespace ComputerPurchase.Views
{
    public partial class ProductInfoForm : Form
    {
        private List<string> _productInfo;

        public ProductInfoForm()
        {
            InitializeComponent();
            
            NextButton.Enabled = false;
        }
        // to open a file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.FileName = "Product.txt";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            var _result = openFileDialog.ShowDialog();
            if (_result != DialogResult.Cancel)
            {
                // open file stream to read
                using (StreamReader inputStream = new StreamReader(
                    File.Open(openFileDialog.FileName, FileMode.Open)))
                {
                    // read stuff from the file into the Student object
                    PlatForm.Text = inputStream.ReadLine();
                    Product.Text = inputStream.ReadLine();
                    Manufaturer.Text = inputStream.ReadLine();
                    MemoryBox.Text = inputStream.ReadLine();
                    BrandBox.Text = inputStream.ReadLine();
                    TypeBox.Text = inputStream.ReadLine();
                    Condition.Text = inputStream.ReadLine();
                    Cost.Text = inputStream.ReadLine();
                    OS.Text = inputStream.ReadLine();
                    Model.Text = inputStream.ReadLine();
                    size.Text = inputStream.ReadLine();
                    number.Text = inputStream.ReadLine();
                    speed.Text = inputStream.ReadLine();
                    HDDtBox.Text = inputStream.ReadLine();
                    GPUBox.Text = inputStream.ReadLine();
                    WebCamBox.Text = inputStream.ReadLine();
                    inputStream.Close();
                    inputStream.Dispose();
                }

                NextButton.Enabled = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // to display the user choice in the next page
        private void NextButton_Click(object sender, EventArgs e)
        {
            _productInfo = new List<string>();
            _productInfo.Add(Product.Text);
            _productInfo.Add(PlatForm.Text); 
            _productInfo.Add(Manufaturer.Text);
            _productInfo.Add(MemoryBox.Text);
            _productInfo.Add(BrandBox.Text);
            _productInfo.Add(TypeBox.Text);
            _productInfo.Add(Condition.Text);
            _productInfo.Add(OS.Text);
            _productInfo.Add(Model.Text);
            _productInfo.Add(size.Text);
            _productInfo.Add(number.Text);
            _productInfo.Add(speed.Text);
            _productInfo.Add(Cost.Text); 
            _productInfo.Add(HDDtBox.Text);
            _productInfo.Add(GPUBox.Text);
            _productInfo.Add(WebCamBox.Text);
            Program.orderForm.FillForm(_productInfo);
            Program.orderForm.Show();
            Program.selectForm.Hide();
        }
        // to open selectForm
        private void AnotherProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }
        // to save a file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.FileName = "Product.txt";
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            var _result = saveFileDialog.ShowDialog();//add function to save to file stream writer

            if (_result != DialogResult.Cancel)
            {
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(saveFileDialog.FileName, FileMode.Create)))
                {
                    outputStream.WriteLine(PlatForm.Text);
                    outputStream.WriteLine(Product.Text);
                    outputStream.WriteLine(Manufaturer.Text);
                    outputStream.WriteLine(MemoryBox.Text);
                    outputStream.WriteLine(BrandBox.Text);
                    outputStream.WriteLine(TypeBox.Text);
                    outputStream.WriteLine(Condition.Text);
                    outputStream.WriteLine(Cost.Text);
                    outputStream.WriteLine(OS.Text);
                    outputStream.WriteLine(Model.Text);
                    outputStream.WriteLine(size.Text);
                    outputStream.WriteLine(number.Text);
                    outputStream.WriteLine(speed.Text);
                    outputStream.WriteLine(HDDtBox.Text);
                    outputStream.WriteLine(GPUBox.Text);
                    outputStream.WriteLine(WebCamBox.Text);


                    outputStream.Close();
                    outputStream.Dispose();
                }
            }
        }

      
        public void FillForm(List<string> info)
        {
            Product.Text = info[0];
            Cost.Text = info[1];
            Manufaturer.Text = info[2];
            Model.Text = info[3];
            Condition.Text = info[14];
            PlatForm.Text = info[16];
            OS.Text = info[15];
            size.Text = info[6];
            MemoryBox.Text = info[7];
            BrandBox.Text = info[10];
            TypeBox.Text = info[11];
            speed.Text = info[12];
            number.Text = info[13];
            WebCamBox.Text = info[30];
            GPUBox.Text = info[19];
            HDDtBox.Text = info[17];
        }

       
    }
}
