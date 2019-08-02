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
          
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var rows = ProductDataGridView.Rows;
            var columCount = ProductDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;
            rows[rowIndex].Selected = true;
            string outputString = string.Empty;
            for (int index = 0; index < columCount; index++)
            {
                outputString += cells[index].Value.ToString() + "";
            }
            textBox.Text = outputString;
            //Program.p.id = int.Parse(cells[(int)StudentField.ID].Value.ToString());
            //Program.student.StudentID = cells[(int)StudentField.STUDENT_ID].Value.ToString();
            //Program.student.FirstName = cells[(int)StudentField.FIRST_NAME].Value.ToString();
            //Program.student.LastName = cells[(int)StudentField.LAST_NAME].Value.ToString();


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }
    }
    
}
