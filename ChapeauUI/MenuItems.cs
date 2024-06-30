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
    public partial class MenuItems : Form
    {
        public MenuItems()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenHomePage();
        }
        private void OpenHomePage()
        {
            HomePage homePage = new();
            homePage.Show();
            this.Hide();
        }
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenStockPage();
        }
        private void OpenStockPage()
        {
            Stock stock = new();
            stock.Show();
            this.Hide();
        }
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEmployeePage();
        }
        private void OpenEmployeePage()
        {
            Employees employees = new();
            employees.Show();
            this.Hide();
        }
        private void OpenDrinksPage()
        {
            Drinks drinks = new();
            drinks.Show();
            this.Hide();
        }
        private void OpenFoodPage()
        {
            Food food = new();
            food.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenDrinksPage();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFoodPage();
        }
    }
}
