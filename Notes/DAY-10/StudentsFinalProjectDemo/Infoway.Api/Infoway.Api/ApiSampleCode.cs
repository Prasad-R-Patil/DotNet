/*using Infoway.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Infoway.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly List<Customer> _customers;
    public CustomersController()
    {
        _customers = new List<Customer>()
        {
            new Customer(){CustomerId=1,ContactName="Alisha C.",City="Mumbai"},
            new Customer(){CustomerId=2,ContactName="Manish Kaushik",City="Bangalore"},
            new Customer(){CustomerId=3,ContactName="Pravinkumar R. D.",City="Pune"},
        };
    }
    //[HttpGet]
    //public IEnumerable<Customer> Get()
    //{
    //    return _customers;
    //}

    //[ProducesResponseType(typeof(IEnumerable<Customer>),StatusCodes.Status200OK,"application/json")]
    //[ProducesResponseType(StatusCodes.Status404NotFound)]
    //[HttpGet]
    //public IActionResult Get()
    //{
    //    if (_customers.Count>0)
    //    {
    //        return Ok(_customers);
    //    }
    //    else
    //    {
    //        return NotFound("Customers Records not found!");
    //    }
    //}
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet]
    public ActionResult<IEnumerable<Customer>> Get()
    {
        if (_customers.Count > 0)
        {
            return Ok(_customers);
        }
        else
        {
            return NotFound("Customers Records not found!");
        }
    }
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{id:int}")]
    public ActionResult<Customer> Get(int id)
    {
        if (_customers.Count > 0)
        {
            return Ok(_customers.Find(c => c.CustomerId == id));
        }
        else
        {
            return NotFound("Customer Record not found!");
        }
    }
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{city:alpha}")]
    public ActionResult<IEnumerable<Customer>> Get(string city)
    {
        var cityWiseCustomers = _customers.Where(c => c.City == city);
        if (cityWiseCustomers.Count() > 0)
        {
            return Ok(cityWiseCustomers);
        }
        else
        {
            return NotFound("Customers Records not found!");
        }
    }
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{id:int}/{city:alpha}")]
    public ActionResult<IEnumerable<Customer>> Get(int id, string city = "Mumbai")
    {
        var cityWiseCustomers = _customers.Where(c => c.City == city);
        if (cityWiseCustomers.Count() > 0)
        {
            return Ok(cityWiseCustomers);
        }
        else
        {
            return NotFound("Customers Records not found!");
        }
    }
}
*/
