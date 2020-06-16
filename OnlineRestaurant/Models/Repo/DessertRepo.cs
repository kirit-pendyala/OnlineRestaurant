using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models.Repo
{
    public class DessertRepo : IDessertRepo
    {
        private List<Dessert> _dessert;
        public Dessert GetDessert(int Id)
        {
            return _dessert.FirstOrDefault(e => e.Id == Id);
        }

        
        public IEnumerable<Dessert> GetAllDesserts()
        {
            return _dessert;
        }
    }
}
