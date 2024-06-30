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
    public partial class Menus : Form
    {
        public Menus()
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
        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenHomePage();
        }
        private void stockToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenStockPage();
        }
        private void employeesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenEmployeePage();
        }
    }
}
