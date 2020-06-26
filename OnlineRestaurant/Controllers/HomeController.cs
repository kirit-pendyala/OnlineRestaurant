using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineRestaurant.Models;

namespace DevExtreme.NETCore.Demos.OnlineRestaurant.Controllers

    //namespace DevExtreme.NETCore.Demos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        private readonly IStarterRepo _starterRepo;
        private readonly IMainCourseRepo _mainCourseRepo;
        private readonly IDessertRepo _dessertRepo;
        private readonly IDishesRepo _dishesRepo;

        public HomeController(IStarterRepo starterRepo
                             ,IMainCourseRepo mainCourseRepo
                             ,IDessertRepo dessertRepo
                             ,IDishesRepo dishesRepo)
        {
            _starterRepo = starterRepo;
            _mainCourseRepo = mainCourseRepo;
            _dessertRepo = dessertRepo;
            _dishesRepo = dishesRepo;
        }


        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Customer()
        {
            //OrderDetailsViewModel orderDetailsViewModel = new OrderDetailsViewModel();
            //orderDetailsViewModel.DishesList = _dishesRepo.GetAllDishes();
            //List<Dishes> dishes = new List<Dishes>();
            var model = _dishesRepo.GetAllDishes();
            return View(model);
        }

        [HttpPost]
        public IActionResult CustomerPost(IList<Dishes> dishes)
        {
            
            return View();
        }

        public IActionResult FrontDesk()
        {
            return View();
        }

        public IActionResult Kitchen()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ViewResult StarterMenu()
        {
            var model = _starterRepo.GetAllStarters();
            return View(model);
        }

        public ViewResult MainCourseMenu()
        {
            var model = _mainCourseRepo.GetAllMainCourses();
            return View(model);
        }

        public ViewResult DessertMenu()
        {
            var model = _dessertRepo.GetAllDesserts();
            return View(model);
        }

    }
}
