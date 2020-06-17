using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public class StarterRepo : IStarterRepo
    {

        private readonly RestaurantContext context;

        public StarterRepo(RestaurantContext context)
        {
            this.context = context;
        }
        
        public IEnumerable<Starter> GetAllStarters()
        {
            return context.Starter;
        }
    }
}
