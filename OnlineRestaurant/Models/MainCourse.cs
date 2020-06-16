using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public class MainCourse
    {
        public int Id { get; set; }
        public string Mname { get; set; }

        public int Mprice { get; set; }

        public int MCalories { get; set; }
    }
}
