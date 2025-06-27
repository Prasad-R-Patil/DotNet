using FirstMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvcApp.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> _customers;
        public CustomersController() 
        {
            _customers = new List<Customer>()
            {
                new(){CustomerId = 1, ContactName="Alisha C.",City="Mumbai"},
                new(){CustomerId = 2, ContactName="Manisha K.",City="Pune"},
                new(){CustomerId = 3, ContactName="Manish Sharma",City="Pune"},
                new(){CustomerId = 4, ContactName="Anjala Johns",City="Berlin"}
            };
        }
        public IActionResult Index()
        {
            //return Content("<h1>Welcome To Infoway Pvt. Ltd.</h1><hr/><h6>CDAC Training Center!</h6>","text/html");
            return File("~/css/site.css","text/css");
        }
        public IActionResult Data()
        {
            return Json(_customers);
        }
        public IActionResult ContactUs()
        {
            if (DateTime.Now.Hour>11)
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

    }
}
