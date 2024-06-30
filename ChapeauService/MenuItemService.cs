using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    internal class MenuItemService
    {

        public MenuItemDao menuItemDao;


        //constructor
        public MenuItemService()
        {
            menuItemDao = new MenuItemDao();
        }

        // get GetMenuItems method from MenuItemDao and assign it a list.
        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItems = menuItemDao.GetMenu_Items();
            return menuItems;
        }

        // Delete menu item from the database
        public void DeleteMenuItems(MenuItem menu_item)
        {
            menuItemDao.DeleteMenu_item(menu_item);
        }

        // Add menu item from the database
        public void AddMenuItems(MenuItem menu_item)
        {
            menuItemDao.AddMenu_item(menu_item);
        }

        // Update menu item from the database
        public void UpdateMenuItems(MenuItem menu_item)
        {
            menuItemDao.UpdateMenu_item(menu_item);
        }
    }
}
