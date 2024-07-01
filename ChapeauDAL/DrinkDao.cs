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
    public class DrinkDao : BaseDao<Drink>
    {
        internal protected override Drink ConvertItem(DataRow reader)
        {
            int ItemId = (int)reader["ItemId"];
            string Name = (string)reader["name"];
            string Category = (string)reader["category"];
            string Card = (string)reader["card"];
            int Stock = (int)reader["stock"];
            float Price = Convert.ToSingle(reader["price"]);


            return new Drink(ItemId, Name, Category, Card, Stock, Price);
        }
        private protected override string GetAllQuery()
        {
            return "SELECT ItemId, name, category, card, stock, price FROM [drinks]";
        }
        public List<Drink> GetDrinks()
        {
            string query = "SELECT ItemId, name, category, card, stock, price FROM [drinks]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadDrinks(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();
            foreach (DataRow dr in dataTable.Rows)
            {
                {
                    Drink drink = new Drink()
                    {
                        ItemId = (int)dr["itemid"],
                        Name = dr["Name"].ToString(),
                        Category = dr["Category"].ToString(),
                        Card = dr["Card"].ToString(),
                        Price = Convert.ToSingle(dr["Price"]),
                        Stock = (int)dr["Stock"],
                    };
                    drinks.Add(drink);
                }
            }
            return drinks;
        }
        private SqlParameter[] DrinkParameters(Drink drink)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@itemId", SqlDbType.Int) {Value = drink.ItemId},
                new("@name", SqlDbType.VarChar) {Value = drink.Name},
                new("@category", SqlDbType.VarChar) {Value = drink.Category},
                new("@card", SqlDbType.VarChar) {Value = drink.Card},
                new("@stock", SqlDbType.Int) {Value = drink.Stock},
                new("@price", SqlDbType.Float) {Value = (double)drink.Price},
            };
            return parameters;
        }

        public void UpdateDrink(Drink drink)
        {
            string query = "UPDATE drinks SET name = @name, category = @category, card = @card, stock = @stock, price = @price WHERE itemId = @itemId";
            ExecuteEditQuery(query, DrinkParameters(drink));
        }
        public void DeleteDrink(Drink drink)
        {
            string query = "DELETE FROM drinks WHERE itemId = @itemId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@itemId", SqlDbType.Int) {Value = drink.ItemId}
            };

            ExecuteEditQuery(query, parameters);
        }
        private void CheckDrinkValues(Drink drink)
        {
            if (IdExists(drink.ItemId, "drinks", "itemId"))
            {
                throw new Exception("This id already exists!");
            }
        }
        public void AddDrink(Drink drink)
        {
            CheckDrinkValues(drink);

            string query = "INSERT drinks(name, category, card, stock, price) VALUES (@name, @category, @card, @stock, @price)";

            ExecuteEditQuery(query, DrinkParameters(drink));
        }

    }
}
