using System;
using System.Collections.Generic;

namespace OnlineRestaurant.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int OrderDetailsId { get; set; }
        public string Status { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
