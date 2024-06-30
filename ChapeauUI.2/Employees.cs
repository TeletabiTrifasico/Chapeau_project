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
    public partial class Employees : Form
    {
        public Employees()
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
    }
}
