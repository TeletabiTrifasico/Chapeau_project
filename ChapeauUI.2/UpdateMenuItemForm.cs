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
    public partial class UpdateMenuItemForm : Form
    {
        private MenuItem oldMenuItem;

        public UpdateMenuItemForm(MenuItem menuItem)
        {
            InitializeComponent();
            oldMenuItem = menuItem;
            FillBoxesWithOldValues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> menuItemValues = new() { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text };

            try
            {
                UpdateMenuItem(menuItemValues);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private MenuItem fillMenuItem(List<string> list)
        {
            int ItemId = int.Parse(string.IsNullOrEmpty(list[0]) ? oldMenuItem.ItemId.ToString() : list[0]);
            string Name = string.IsNullOrEmpty(list[1]) ? oldMenuItem.Name : list[1];
            string Category = string.IsNullOrEmpty(list[2]) ? oldMenuItem.Category : list[2];
            string Card = string.IsNullOrEmpty(list[3]) ? oldMenuItem.Card : list[3];
            int Stock = int.Parse(string.IsNullOrEmpty(list[4]) ? oldMenuItem.Stock.ToString() : list[4]);
            float Price = float.Parse(string.IsNullOrEmpty(list[5]) ? oldMenuItem.Price.ToString() : list[5]);

            return new MenuItem(oldMenuItem.ItemId, Name, Category, Card, Stock, Price);
        }

        private void UpdateMenuItem(List<string> list)
        {
            MenuItemService menuItemService = new();
            menuItemService.UpdateMenuItems(fillMenuItem(list));
            MessageBox.Show("Menu item updated!");
        }

        private void FillBoxesWithOldValues()
        {
            textBox1.Text = oldMenuItem.ItemId.ToString();
            textBox2.Text = oldMenuItem.Name;
            textBox3.Text = oldMenuItem.Category;
            textBox4.Text = oldMenuItem.Card;
            textBox5.Text = oldMenuItem.Stock.ToString();
            textBox6.Text = oldMenuItem.Price.ToString();
        }
    }
}
