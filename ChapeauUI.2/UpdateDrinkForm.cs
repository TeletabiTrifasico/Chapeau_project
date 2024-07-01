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
    public partial class UpdateDrinkForm : Form
    {
        private Drink oldDrink;

        public UpdateDrinkForm(Drink drink)
        {
            InitializeComponent();
            oldDrink = drink;
            FillBoxesWithOldValues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> drinkValues = new() { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text };

            try
            {
                UpdateDrink(drinkValues);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Drink fillDrink(List<string> list)
        {
            int ItemId = int.Parse(string.IsNullOrEmpty(list[0]) ? oldDrink.ItemId.ToString() : list[0]);
            string Name = string.IsNullOrEmpty(list[1]) ? oldDrink.Name : list[1];
            string Category = string.IsNullOrEmpty(list[2]) ? oldDrink.Category : list[2];
            string Card = string.IsNullOrEmpty(list[3]) ? oldDrink.Card : list[3];
            int Stock = int.Parse(string.IsNullOrEmpty(list[4]) ? oldDrink.Stock.ToString() : list[4]);
            float Price = float.Parse(string.IsNullOrEmpty(list[5]) ? oldDrink.Price.ToString() : list[5]);

            return new Drink(oldDrink.ItemId, Name, Category, Card, Stock, Price);
        }

        private void UpdateDrink(List<string> list)
        {
            DrinkService drinkService = new();
            drinkService.UpdateDrink(fillDrink(list));
            MessageBox.Show("Menu item updated!");
        }

        private void FillBoxesWithOldValues()
        {
            textBox1.Text = oldDrink.ItemId.ToString();
            textBox2.Text = oldDrink.Name;
            textBox3.Text = oldDrink.Category;
            textBox4.Text = oldDrink.Card;
            textBox5.Text = oldDrink.Stock.ToString();
            textBox6.Text = oldDrink.Price.ToString();
        }
    }
}
