using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public class Dessert
    {
        public int Id { get; set; }
        public string Dname { get; set; }

        public int Dprice { get; set; }

        public int Dcalories { get; set; }
    }
}
