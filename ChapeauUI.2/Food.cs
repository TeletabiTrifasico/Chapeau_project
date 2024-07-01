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
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
            ShowMenuItem();
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
        public List<MenuItem> GetMenuItem()
        {
            MenuItemService menuItemService = new();
            return menuItemService.GetMenuItems();
        }

        public void DisplayMenuItem(List<MenuItem> menuItems, string checkpanel)
        {
            listViewMenuItem.Items.Clear();

            Action<ListViewItem> addItem = AddMenuItem(checkpanel);

            foreach (MenuItem menuItem in menuItems)
            {
                ListViewItem item = new(menuItem.ItemId.ToString());
                item.SubItems.Add(menuItem.Name);
                item.SubItems.Add(menuItem.Category);
                item.SubItems.Add(menuItem.Card);
                item.SubItems.Add(menuItem.Stock.ToString());
                item.SubItems.Add(menuItem.Price.ToString());
                item.Tag = menuItem;

                addItem(item);
            }
        }

        public Action<ListViewItem> AddMenuItem(string checkPanel)
        {
            Action<ListViewItem> addItem;
            addItem = item => listViewMenuItem.Items.Add(item);
            return addItem;
        }
        public void DeleteMenuItem()
        {
            ListViewItem selectedMenuItem = listViewMenuItem.SelectedItems[0];

            if (CreateDeleteCheckForm("Are you sure you wish to remove this menu item?").DeleteMessage())
            {
                MenuItemService menuItemService = new();
                menuItemService.DeleteMenuItems((MenuItem)selectedMenuItem.Tag);
                MessageBox.Show("Menu item deleted!");
                Food menuItem = new();
                menuItem.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Action canceled!");
            }
        }

        public DeleteConfirmation CreateDeleteCheckForm(string message)
        {
            DeleteConfirmation deleteCheckForm = new(message);
            deleteCheckForm.ShowDialog();
            return deleteCheckForm;
        }

        public void ShowMenuItem()
        {
            try
            {
                List<MenuItem> menuItems = GetMenuItem();
                DisplayMenuItem(menuItems, "menuItems");
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the menu items: " + e.Message);
            }
        }
        private void OpenMenuItemAddForm()
        {
            AddMenuItemForm addMenuItemForm = new();
            addMenuItemForm.ShowDialog();
            Food menuItem = new Food();
            menuItem.Show();
            this.Close();
        }

        private void OpenUpdateMenuItemForm()
        {
            ListViewItem selectedMenuItem = listViewMenuItem.SelectedItems[0];

            UpdateMenuItemForm menuItemUpdateForm = new((MenuItem)selectedMenuItem.Tag);
            menuItemUpdateForm.ShowDialog();
            Food menuItem = new Food();
            menuItem.Show();
            this.Close();
        }
        private void button3_Click_1(object sender, EventArgs e)//delete
        {
            if (listViewMenuItem.SelectedItems.Count != 0)
            {
                DeleteMenuItem();
            }
            else
            {
                MessageBox.Show("Select a menu item!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)//add
        {
            OpenMenuItemAddForm();
        }

        private void button2_Click_1(object sender, EventArgs e)//update
        {
            if (listViewMenuItem.SelectedItems.Count != 0)
            {
                OpenUpdateMenuItemForm();
            }
            else
            {
                MessageBox.Show("Select a menu item!");
            }
        }
    }
}
