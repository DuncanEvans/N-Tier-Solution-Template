using Entities;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataAccess
    {
        public List<dishe> GetDishes()
        {
            DataObjectsDataContext db = new DataObjectsDataContext();
            Table<dishe> dishes = db.dishes;

            return dishes.ToList();
        }
    }
}
