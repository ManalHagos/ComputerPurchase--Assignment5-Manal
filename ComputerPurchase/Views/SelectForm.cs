using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ComputerPurchase.Data;

namespace ComputerPurchase.Views
{
    public partial class SelectForm : Form
    {
        
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new ProductModel())
            {
                db.products.Load();

               // productsBindingSource.DataSaurce = db.products.Local.ToBindingList();
            }
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            ProductDataGridView.ClearSelection();
            NextButton.Enabled = false;
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            //var currentrows = ProductDataGridView.Rows;
            //var columCount = ProductDataGridView.ColumnCount;
            //var cells = currentrows[rowIndex].Cells;
            //currentrows[rowIndex].Selected = true;
            //string outputString = string.Empty;
            //for (int index = 0; index < columCount; index++)
            //{
            //    outputString += cells[index].Value.ToString() + "";
            //}
            textBox.Text = ProductDataGridViewSelectedItem();
            NextButton.Enabled = true;
            //Program.p.id = int.Parse(cells[(int)StudentField.ID].Value.ToString());
            //Program.student.StudentID = cells[(int)StudentField.STUDENT_ID].Value.ToString();
            //Program.student.FirstName = cells[(int)StudentField.FIRST_NAME].Value.ToString();
            //Program.student.LastName = cells[(int)StudentField.LAST_NAME].Value.ToString();
        }

        public string ProductDataGridViewSelectedItem()
        {
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductDataGridView.Rows[rowIndex];
            var cost = currentRow.Cells[1].Value.ToString();
            var costDecimal = Decimal.Parse(cost);

            cost = costDecimal.ToString("C2");

            var manufacturer = currentRow.Cells[2].Value.ToString();
            var model = currentRow.Cells[3].Value.ToString();

            string outputString = manufacturer + " " + model + " " + cost;

            return outputString;
        }

            private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var currentrows = ProductDataGridView.Rows;
            var columCount = ProductDataGridView.ColumnCount;
            var cells = currentrows[rowIndex].Cells;
            currentrows[rowIndex].Selected = true;
            string outputString = string.Empty;
            List<string> columnInfo = new List<string>();
            for (int index = 0; index < columCount; index++)
            {
                //outputString += cells[index].Value.ToString() + ",";
                columnInfo.Add(cells[index].Value.ToString());
            }


            Program.productInfoForm.NextButton.Enabled = true;
            Program.productInfoForm.FillForm(columnInfo);

            Program.productInfoForm.Show();
        }

        
    }
    
}
