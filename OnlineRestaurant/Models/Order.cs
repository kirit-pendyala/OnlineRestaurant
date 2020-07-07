using System;
using System.Collections.Generic;

namespace OnlineRestaurant.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? CustId { get; set; }
        public int? OrderDetailsId { get; set; }
        public string Status { get; set; }
    }
}
