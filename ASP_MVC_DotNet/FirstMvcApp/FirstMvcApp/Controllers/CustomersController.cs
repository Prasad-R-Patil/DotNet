using FirstMvcApp.Models;
using FirstMvcApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvcApp.Controllers
{
    //  url/Customers/<action method>
    public class CustomersController : Controller
    {
        private List<Customer> _customers;
        private List<Order> _orders;

        public CustomersController()
        {
            _customers = new List<Customer>()
            {
                new() { CustomerId = 1, ContactName = "Alisha C.", City = "Mumbai" },
                new() { CustomerId = 2, ContactName = "Manisha K.", City = "Pune" },
                new() { CustomerId = 3, ContactName = "Manish Sharma", City = "Pune" },
                new() { CustomerId = 4, ContactName = "Anjala Johns", City = "Berlin" }
            };

            _orders = new List<Order>()
            {
                new() { OrderId = 101, OrderDate = DateTime.Now.AddDays(-3), Quantity = 2, UnitPrice = 500, CustomerId = 1 },
                new() { OrderId = 102, OrderDate = DateTime.Now.AddDays(-1), Quantity = 1, UnitPrice = 1200, CustomerId = 2 },
                new() { OrderId = 103, OrderDate = DateTime.Now.AddDays(-2), Quantity = 5, UnitPrice = 300, CustomerId = 3 },
                new() { OrderId = 104, OrderDate = DateTime.Now.AddDays(-5), Quantity = 3, UnitPrice = 700, CustomerId = 4 }
            };
        }

        public IActionResult Index()
        {
            return File("~/css/site.css", "text/css");
        }

        public IActionResult Data()
        {
            return Json(_customers);
        }

        public IActionResult ContactUs()
        {
            if (DateTime.Now.Hour > 11)
            {
                return View("ContactMumbaiOffice");
            }
            else
            {
                return View("ContactPuneOffice");
            }
        }

        public IActionResult List()
        {
            return View(_customers);
        }

        public IActionResult CustomersOrders()
        {
            var vm = new CustomersOrdersVM
            {
                Customers = _customers,
                Orders = _orders
            };

            ViewData["PageTitle"] = "Customers & Orders";
            ViewBag.SubTitle = "List from our records";

            return View(vm);  
        }
    }
}
