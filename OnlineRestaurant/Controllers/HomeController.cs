using System;

using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineRestaurant.Models;

namespace DevExtreme.NETCore.Demos.OnlineRestaurant.Controllers

{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //RestaurantContext restaurantContext = new RestaurantContext(options);

        private readonly RestaurantContext _restaurantContext;

        private readonly IStarterRepo _starterRepo;
        private readonly IMainCourseRepo _mainCourseRepo;
        private readonly IDessertRepo _dessertRepo;
        private readonly IDishesRepo _dishesRepo;
        private readonly ICustomerRepo _customerRepo;
        private readonly IOrderDetailsRepo _orderDetailsRepo;
        private readonly IOrdersRepo _ordersRepo;

        public HomeController(IStarterRepo starterRepo
                             ,IMainCourseRepo mainCourseRepo
                             ,IDessertRepo dessertRepo
                             ,IDishesRepo dishesRepo
                             ,ICustomerRepo customerRepo
                             ,IOrderDetailsRepo orderDetailsRepo
                             ,IOrdersRepo ordersRepo)
        {
            _starterRepo = starterRepo;
            _mainCourseRepo = mainCourseRepo;
            _dessertRepo = dessertRepo;
            _dishesRepo = dishesRepo;
            _customerRepo = customerRepo;
            _orderDetailsRepo = orderDetailsRepo;
            _ordersRepo = ordersRepo;
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
            var model = _dishesRepo.GetAllDishes();
            return View(model);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public JsonResult CustomerPost(string[] values)
        {
            Orders newOrder = new Orders();
            newOrder.CustomerId = 2;
            newOrder.Status = "Pending";
            bool result = _ordersRepo.Add(newOrder);
            List<Int32> itemId = new List<Int32>();
            List<Int32> itemCount = new List<Int32>();
            
            for (int i = 0; i < values.Length; i++)
            {
                var items = values[i].Split('_');
                itemId.Add(Int32.Parse(items[0]));
                itemCount.Add(Int32.Parse(items[1]));
            }
            int b = 0;
            foreach (var item in itemId)
            {
                OrderDetails od = new OrderDetails();
                od.ItemId = item;
                od.OrderId = newOrder.Id;
                od.Quantity = itemCount[b++];
                _orderDetailsRepo.Add(od);
            }
            return Json(true);   
        }   

        public IActionResult FrontDesk()
        {
            return View();
        }

        public IActionResult Kitchen()
        {
            return View();
        }

        public IActionResult CustomerList()
        {
            var model = _customerRepo.GetAllCustomers();
            return View(model);
        }

        public ActionResult ModalPopUp()
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
