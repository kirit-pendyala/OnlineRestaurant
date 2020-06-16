using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models.Repo
{
    public class MainCourseRepo :IMainCourseRepo
    {
        private List<MainCourse> _mainCourse;
        public MainCourse GetMainCourse(int Id)
        {
            return _mainCourse.FirstOrDefault(e => e.Id == Id);
        }
    }
}
