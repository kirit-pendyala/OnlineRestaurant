using System;
using System.Collections.Generic;

namespace OnlineRestaurant.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobile { get; set; }
    }
}
