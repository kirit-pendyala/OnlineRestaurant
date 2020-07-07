using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public interface ICustomerRepo
    {
        IEnumerable<Customer> GetAllCustomers();
    }
}
