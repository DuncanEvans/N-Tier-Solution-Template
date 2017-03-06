using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BusinessLogic
    {

        static void Main()
        {
            
        }

        public List<dishe> GetDishes()
        {
            DataAccess.DataAccess data = new DataAccess.DataAccess();
            List<dishe> dishes = data.GetDishes();

            return dishes;
        }

        public dishe GetRandomDish()
        {
            DataAccess.DataAccess dal = new DataAccess.DataAccess();
            List<dishe> dishes = dal.GetDishes();

            Random rnd = new Random();
            int i = rnd.Next(0, dishes.Count);

            return dishes[i];
        }

    }
}
