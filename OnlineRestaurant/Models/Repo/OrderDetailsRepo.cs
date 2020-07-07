using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public class OrderDetailsRepo : IOrderDetailsRepo
    {
        private List<OrderDetails> _orderDetailsList;

        private readonly RestaurantContext context;

        public OrderDetailsRepo(RestaurantContext context)
        {
            this.context = context;
        }

        public OrderDetails Add(OrderDetails orderDetails)
        {
            //orderDetails.Id = _orderDetailsList.Max(e => e.Id) + 1;
            context.OrderDetails.Add(orderDetails);
            context.SaveChanges();
            return orderDetails;
        }

        public IEnumerable<OrderDetails> GetAllOrderDetails()
        {
            return _orderDetailsList;
        }

        public OrderDetails GetOrderDetails(int Id)
        {
            return _orderDetailsList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
