using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class MenuItem
    {
        public int ItemId { get; set; }         //Id for the items in the menu (Primary key)
        public string Name { get; set; }        //Name for the item in the menu
        public string Category { get; set; }    //Category for the item in the menu
        public string Card { get; set; }        //Card for the item in the menu
        public int Stock { get; set; }          //Stock amount for the item in the menu
        public float Price { get; set; }        //Price of the item in the menu 
        public MenuItem(){}
        public MenuItem(int itemId, string name, string category, string card, int stock, float price)
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
