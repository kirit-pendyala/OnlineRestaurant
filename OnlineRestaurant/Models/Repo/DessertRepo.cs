using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public class DessertRepo : IDessertRepo
    {
        private readonly RestaurantContext context;

        public DessertRepo(RestaurantContext context)
        {
            this.context = context;
        }
        
        public IEnumerable<Dessert> GetAllDesserts()
        {
            return context.Dessert;
        }
    }
}
