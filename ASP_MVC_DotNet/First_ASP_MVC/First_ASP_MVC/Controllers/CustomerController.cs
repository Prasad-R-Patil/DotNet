using First_ASP_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace First_ASP_MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly List<Customer> _customers;
        public CustomerController()
        {
            _customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Prasad Patil", Email = "prasad@gmail.com", City = "Pune" },
                new Customer { Id = 2, Name = "Alisha C.", Email = "alisha@gmail.com", City = "Mumbai" },
                new Customer { Id = 3, Name = "Rohan K.", Email = "rohan@gmail.com", City = "Nagpur" },
                new Customer { Id = 4, Name = "Sneha R.", Email = "sneha@gmail.com", City = "Nashik" },
                new Customer { Id = 5, Name = "Amit S.", Email = "amit@gmail.com", City = "Kolhapur" }
            };
        }
        public IActionResult Index()
        {
           
            return Content("<h1>Welcome to Infoway Technology</h1><hr><h5>CDAC Training Center</h5>","text/html");
        }

        public IActionResult data()
        {
        

            return Json(_customers);
        }

        public IActionResult List()
        {

            return View(_customers);
        }

        public IActionResult ContactUs()
        {
            //if (DateTime.Now.Hour < 6)
            //{
            //    return View("ContactPuneOffice", _customers);
            //}
            //else
            //{
            //    return View("ContactMumbaiOffice", _customers); // this one test time 3PM
            //}

            if (DateTime.Now.Hour >= 6)
            {
                return View("ContactPuneOffice", _customers); // this one test time 3PM
            }
            else
            {
                return View("ContactMumbaiOffice", _customers);
            }

        }


    }
}
