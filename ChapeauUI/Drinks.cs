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
    public partial class Drinks : Form
    {
        public Drinks()
        {
            InitializeComponent();
        }
        private void OpenHomePage()
        {
            HomePage homePage = new();
            homePage.Show();
            this.Hide();
        }
        private void OpenStockPage()
        {
            Stock stock = new();
            stock.Show();
            this.Hide();
        }
        private void OpenEmployeePage()
        {
            Employees employees = new();
            employees.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenHomePage();
        }
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenStockPage();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEmployeePage();
        }
    }
}
