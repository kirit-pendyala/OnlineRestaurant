using System;
using System.Collections.Generic;

namespace OnlineRestaurant.Models
{
    public partial class Dishes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? Calories { get; set; }
    }
}
