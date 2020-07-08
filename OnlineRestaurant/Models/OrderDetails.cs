﻿using System;
using System.Collections.Generic;

namespace OnlineRestaurant.Models
{
    public partial class OrderDetails
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int? ItemId { get; set; }
        public int? Quantity { get; set; }

        public virtual Orders Order { get; set; }
    }
}
