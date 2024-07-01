using ChapeauModel;
using ChapeauService;
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
    public partial class AddMenuItemForm : Form
    {
        public AddMenuItemForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> menuItemValues = new() { textBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, textBox6.Text};

            try
            {
                AddMenuItem(menuItemValues);
                MessageBox.Show("Menu item added!");
            }
            catch (Exception eu)
            {
                MessageBox.Show(eu.Message);
            }
        }
        private void AddMenuItem(List<string> list)
        {
            if (list.Any(x => x == ""))
            {
                throw new Exception("Enter all values!");
            }
            else
            {
                MenuItemService menuItemService = new();
                menuItemService.AddMenuItems(FillMenuItem(list));
                Close();
            }
        }
        private MenuItem FillMenuItem(List<string> list)
        {
            if (!int.TryParse(list[0], out int MenuItemId))
            {
                throw new ArgumentException("MenuItemId should be a valid integer!");
            }

            if (!int.TryParse(list[4], out int Stock))
            {
                throw new ArgumentException("Stock should be a valid integer!");
            }
            if (!int.TryParse(list[5], out int Price))
            {
                throw new ArgumentException("Price should be a valid integer!");
            }

            return new MenuItem(MenuItemId, list[1], list[2], list[3], Stock, Price);
        }
    }
}
