using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.Models
{
    public interface IMainCourseRepo
    {
        MainCourse GetMainCourse(int Id);


        IEnumerable<MainCourse> GetAllMainCourses();

    }
}
