using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public interface IOrderDetailsRepo
    {
        OrderDetails Add(OrderDetails orderDetails);

        OrderDetails GetOrderDetails(int Id);

        IEnumerable<OrderDetails> GetAllOrderDetails();
    }
}
