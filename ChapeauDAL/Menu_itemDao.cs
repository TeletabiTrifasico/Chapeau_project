using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using Microsoft.Data.SqlClient;

namespace ChapeauDAL
{
    public class Menu_itemDao : BaseDao 
    {
        public List<Menu_item> GetMenu_Items()
        {
            string query = "SELECT ItemId, name, category, card, stock, price FROM [menuItem]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMenu_items(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Menu_item> ReadMenu_items(DataTable dataTable)
        {
            List<Menu_item> menuItems = new List<Menu_item>();
            foreach (DataRow dr in dataTable.Rows)
            {
                {
                    Menu_item menuItem = new Menu_item()
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
            }
            return menuItems;
        }
    }
}
