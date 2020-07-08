using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public class OrdersRepo : IOrdersRepo
    {
        private List<Orders> _ordersList;

        private readonly RestaurantContext context;

        public OrdersRepo(RestaurantContext context)
        {
            this.context = context;
            _ordersList = context.Orders.ToList();
        }

        public bool Add(Orders orders)
        {
            try
            {
                context.Orders.Add(orders);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
