using System;
using System.Collections.Generic;

namespace OnlineRestaurant.Models
{
    public class MainCourse
    {
        public int Id { get; set; }
        public string Mname { get; set; }
        public int? Mprice { get; set; }
        public int? Mcalories { get; set; }
    }
}
