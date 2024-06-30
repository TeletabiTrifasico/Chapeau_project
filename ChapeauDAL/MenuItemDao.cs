using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class MenuItemDao : BaseDao 
    {
        public List<MenuItem> GetMenu_Items()
        {
            string query = "SELECT ItemId, name, category, card, stock, price FROM [menuItem]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMenu_items(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem> ReadMenu_items(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                {
                    MenuItem menuItem = new MenuItem()
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
        private SqlParameter[] Menu_itemParameters(MenuItem menu_item)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@itemId", SqlDbType.Int) {Value = menu_item.ItemId},
                new("@name", SqlDbType.VarChar) {Value = menu_item.Name},
                new("@category", SqlDbType.VarChar) {Value = menu_item.Category},
                new("@card", SqlDbType.VarChar) {Value = menu_item.Card},
                new("@stock", SqlDbType.Int) {Value = menu_item.Stock},
                new("@price", SqlDbType.Float) {Value = menu_item.Price},
            };
            return parameters;
        }

        public void UpdateMenu_item(MenuItem menu_item)
        {
            string query = "UPDATE menuItem SET name = @name, category = @category, card = @card, stock = @stock, price = @price WHERE itemId = @itemId";
            ExecuteEditQuery(query, Menu_itemParameters(menu_item));
        }
        public void DeleteMenu_item(MenuItem menu_item)
        {
            string query = "DELETE FROM menuItem WHERE itemId = @itemId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@itemId", SqlDbType.Int) {Value = menu_item.ItemId}
            };

            ExecuteEditQuery(query, parameters);
        }
        private void CheckMenu_itemValues(MenuItem menu_item)
        {
            if (IdExists(menu_item.ItemId, "menuItem", "itemId"))
            {
                throw new Exception("This id already exists!");
            }
        }
        public void AddMenu_item(MenuItem menu_item)
        {
            CheckMenu_itemValues(menu_item);

            string query = "INSERT menuItem(name, category, card, stock, price) VALUES (@name, @category, @card, @stock, @price)";

            ExecuteEditQuery(query, Menu_itemParameters(menu_item));
        }

    }
}
