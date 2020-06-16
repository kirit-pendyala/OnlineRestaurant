using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public interface IStarterRepo
    {
        Starter GetStarter(int Id);


        IEnumerable<Starter> GetAllStarters();

    }   
}
