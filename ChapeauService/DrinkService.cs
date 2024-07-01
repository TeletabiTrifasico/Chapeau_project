using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class DrinkService
    {

        public DrinkDao drinkDao;


        public DrinkService()
        {
            drinkDao = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drink = drinkDao.GetDrinks();
            return drink;
        }

        public void DeleteDrink(Drink drink)
        {
            drinkDao.DeleteDrink(drink);
        }

        public void AddDrink(Drink drink)
        {
            drinkDao.AddDrink(drink);
        }

        public void UpdateDrink(Drink drink)
        {
            drinkDao.UpdateDrink(drink);
        }
    }
}
