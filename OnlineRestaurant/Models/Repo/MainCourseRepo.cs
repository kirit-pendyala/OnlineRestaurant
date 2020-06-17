using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public class MainCourseRepo :IMainCourseRepo
    {
        private readonly RestaurantContext context;

        public MainCourseRepo(RestaurantContext context)
        {
            this.context = context;
        }

        public IEnumerable<MainCourse> GetAllMainCourses()
        {
            return context.MainCourse;
        }
    }
}
