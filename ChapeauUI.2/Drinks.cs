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
    public partial class Drinks : Form
    {
        public Drinks()
        {
            InitializeComponent();
            ShowDrink();
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
        public List<Drink> GetDrink()
        {
            DrinkService drinkService = new();
            return drinkService.GetDrinks();
        }

        public void DisplayDrink(List<Drink> drinks, string checkpanel)
        {
            listViewDrink.Items.Clear();

            Action<ListViewItem> addItem = AddDrink(checkpanel);

            foreach (Drink drink in drinks)
            {
                ListViewItem item = new(drink.ItemId.ToString());
                item.SubItems.Add(drink.Name);
                item.SubItems.Add(drink.Category);
                item.SubItems.Add(drink.Card);
                item.SubItems.Add(drink.Stock.ToString());
                item.SubItems.Add(drink.Price.ToString());
                item.Tag = drink;

                addItem(item);
            }
        }

        public Action<ListViewItem> AddDrink(string checkPanel)
        {
            Action<ListViewItem> addItem;
            addItem = item => listViewDrink.Items.Add(item);
            return addItem;
        }
        public void DeleteDrink()
        {
            ListViewItem selectedDrink = listViewDrink.SelectedItems[0];

            if (CreateDeleteCheckForm("Are you sure you wish to remove this menu item?").DeleteMessage())
            {
                DrinkService drinkService = new();
                drinkService.DeleteDrink((Drink)selectedDrink.Tag);
                MessageBox.Show("Menu item deleted!");
                Food drink = new();
                drink.Show();
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

        public void ShowDrink()
        {
            try
            {
                List<Drink> drinks = GetDrink();
                DisplayDrink(drinks, "drinks");
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the menu items: " + e.Message);
            }
        }
        private void OpenDrinkAddForm()
        {
            AddDrinkForm addDrinkForm = new();
            addDrinkForm.ShowDialog();
            Drinks drink = new Drinks();
            drink.Show();
            this.Close();
        }

        private void OpenUpdateDrinkForm()
        {
            ListViewItem selectedDrink = listViewDrink.SelectedItems[0];

            UpdateDrinkForm drinkUpdateForm = new((Drink)selectedDrink.Tag);
            drinkUpdateForm.ShowDialog();
            Drinks drink = new Drinks();
            drink.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)//add
        {
            OpenDrinkAddForm();
        }
        private void button2_Click(object sender, EventArgs e)//delete
        {
            if (listViewDrink.SelectedItems.Count != 0)
            {
                OpenUpdateDrinkForm();
            }
            else
            {
                MessageBox.Show("Select a menu item!");
            }
        }
        private void button3_Click(object sender, EventArgs e)//update
        {
            if (listViewDrink.SelectedItems.Count != 0)
            {
                DeleteDrink();
            }
            else
            {
                MessageBox.Show("Select a menu item!");
            }
        }
    }
}
