using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    internal class Menu_itemDao
    {
        public List<Menu_Item> DB_Get_All_Menu_Items()
        {
            string query = "SELECT ItemId, name, category, card, stock, price FROM [menuItem]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Menu_Item> ReadTables(DataTable dataTable)
        {
            List<Menu_Item> menuItems = new List<Menu_Item>();
            foreach (DataRow dr in dataTable.Rows)
            {
                {
                    Menu_Item menuItem = new Menu_Item()
                    {
                        ItemId = (int)dr["itemid"],
                        Name = dr["Name"].ToString(),
                        Category = dr["Category"].ToString(),
                        Card = dr["Card"].ToString(),
                        Price = (float)dr["Price"],
                        Stock = (int)dr["Stock"],
                    };
                    menuItems.Add(menuItem);
                }
                return menuItems;
            }
        }
    }
}
