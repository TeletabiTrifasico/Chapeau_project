using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI._2
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenStockPage();
        }
        private void OpenStockPage()
        {
            Stock stock = new();
            stock.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenEmployeePage();
        }
        private void OpenEmployeePage()
        {
            Employees employees = new();
            employees.Show();
            this.Hide();
        }
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEmployeePage();
        }
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenStockPage();
        }
    }
}