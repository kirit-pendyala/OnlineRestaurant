using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public class DishesRepo : IDishesRepo
    {
        private readonly RestaurantContext context;

        public DishesRepo(RestaurantContext context)
        {
            this.context = context;
        }
        public IEnumerable<Dishes> GetAllDishes()
        {
            return context.Dishes;
        }
    }
}
