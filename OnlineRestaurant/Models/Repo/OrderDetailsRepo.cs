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
            _orderDetailsList = context.OrderDetails.ToList();
        }

        public OrderDetails Add(OrderDetails orderDetails)
        {
            //orderDetails.OrderDetailsId = _orderDetailsList.Max(e => e.OrderDetailsId) + 1;
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
