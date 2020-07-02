using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineRestaurant.Models
{
    public class Dishes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? Calories { get; set; }
        [NotMapped]
        public int count { get; set; }

        [NotMapped]
        public Boolean isChecked { get; set; }
    }
}