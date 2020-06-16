using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public interface IDessertRepo
    {
        Dessert GetDessert(int Id);
    }
}
