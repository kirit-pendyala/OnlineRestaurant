using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly RestaurantContext context;

        public CustomerRepo(RestaurantContext context)
        {
            this.context = context;
        }
        
        public IEnumerable<Customer> GetAllCustomers()
        {
            return context.Customer;
        }
    }
}
