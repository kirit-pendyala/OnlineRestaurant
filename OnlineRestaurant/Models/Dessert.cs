using System;
using System.Collections.Generic;

namespace OnlineRestaurant.Models
{
    public partial class Dessert
    {
        public int Id { get; set; }
        public string Dname { get; set; }
        public int? Dprice { get; set; }
        public string Dcalories { get; set; }
    }
}
