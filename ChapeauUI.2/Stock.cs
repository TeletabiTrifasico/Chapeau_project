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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }
        private void OpenEmployeePage()
        {
            Employees employees = new();
            employees.Show();
            this.Hide();
        }
        private void OpenHomePage()
        {
            HomePage homePage = new();
            homePage.Show();
            this.Hide();
        }
        private void OpenDrinksPage()
        {
            Drinks drinks = new();
            drinks.Show();
            this.Hide();
        }
        private void OpenMenuItemsPage()
        {
            Food food = new();
            food.Show();
            this.Hide();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEmployeePage();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenHomePage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenDrinksPage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenMenuItemsPage();
        }
    }
}
