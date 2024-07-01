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
    public partial class AddDrinkForm : Form
    {
        public AddDrinkForm()
        {
            InitializeComponent();
        }
        private void AddDrink(List<string> list)
        {
            if (list.Any(x => x == ""))
            {
                throw new Exception("Enter all values!");
            }
            else
            {
                DrinkService drinkService = new();
                drinkService.AddDrink(FillDrink(list));
                Close();
            }
        }
        private Drink FillDrink(List<string> list)
        {
            if (!int.TryParse(list[0], out int DrinkId))
            {
                throw new ArgumentException("DrinkId should be a valid integer!");
            }

            if (!int.TryParse(list[4], out int Stock))
            {
                throw new ArgumentException("Stock should be a valid integer!");
            }
            if (!float.TryParse(list[5], out float Price))
            {
                throw new ArgumentException("Price should be a valid integer!");
            }

            return new Drink(DrinkId, list[1], list[2], list[3], Stock, Price);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> drinkValues = new() { textBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, textBox6.Text };

            try
            {
                AddDrink(drinkValues);
                MessageBox.Show("Drink added!");
            }
            catch (Exception eu)
            {
                MessageBox.Show(eu.Message);
            }
        }
    }
}
