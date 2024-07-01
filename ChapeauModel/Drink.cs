using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Drink
    {
        public int ItemId { get; set; }         //Id for the drinks (Primary key)
        public string Name { get; set; }        //Name for the drinks 
        public string Category { get; set; }    //Category for the drinks 
        public string Card { get; set; }        //Card for the drinks 
        public int Stock { get; set; }          //Stock amount for the drinks 
        public float Price { get; set; }        //Price of the drinks  
        public Drink(){}
        public Drink(int itemId, string name, string category, string card, int stock, float price)
        {
            ItemId = itemId;
            Name = name;
            Category = category;
            Card = card;
            Stock = stock;
            Price = price;
        }

    }
}
