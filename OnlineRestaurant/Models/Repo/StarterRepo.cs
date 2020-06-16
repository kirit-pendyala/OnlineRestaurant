using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models.Repo
{
    public class StarterRepo : IStarterRepo
    {
        private List<Starter> _starter;
        public Starter GetStarter(int Id)
        {
            return _starter.FirstOrDefault(e => e.Id == Id);
        }

        public IEnumerable<Starter> GetAllStarters()
        {
            return _starter;
        }
    }
}
