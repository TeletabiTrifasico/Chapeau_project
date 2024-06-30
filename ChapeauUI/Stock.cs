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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenMenusPage();
        }
        private void OpenMenusPage()
        {
            Menus menus = new();
            menus.Show();
            this.Hide();
        }
        private void OpenMenuItemsPage()
        {
            MenuItems menuItems = new();
            menuItems.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenMenuItemsPage();
        }
    }
}
