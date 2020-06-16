using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public class RestaurantRepo : IRestaurantRepo
    {
        private List<Restaurant> _restaurant;
        public Restaurant GetRestaurant(int Id)
        {
            return _restaurant.FirstOrDefault(e => e.Id == Id);
        }
    }
}
