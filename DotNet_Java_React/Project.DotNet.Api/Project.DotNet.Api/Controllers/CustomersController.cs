using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.DotNet.Api.Models;
using Project.DotNet.Api.Repositories;

namespace Project.DotNet.Api.Controllers;


[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ICommonRepository<Customer> _customerRepository;


    public CustomersController(ICommonRepository<Customer> customerRepository)
    {
        _customerRepository = customerRepository;
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Customer>>> getAllCustomers()
    {
        var customers = await  _customerRepository.GetAllAsync();

        if(customers.Count>0)
        {
            return Ok(customers);
        }
        else
        {
            return NotFound("Customres Not Found...");
        }
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Customer>> getCustomerDetails(int id)
    {
        var customer = await _customerRepository.GetDetailsAsync(id);

        if (customer != null)
        {
            return Ok(customer);
        }
        else
        {
            return NotFound("Invalid id ["+id+"] Coustomer Not Found...");
        }
    }

    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPost]
    public async Task<ActionResult<Customer>> AddCustomer([FromBody] Customer customer)
    {
        if (ModelState.IsValid)
        {
            int result = await _customerRepository.InsertAsync(customer);

            if (result > 0)
            {
                return CreatedAtAction(nameof(getCustomerDetails), new { id = customer.CustomerId }, customer);
            }
            else
            {
                return BadRequest("Insert Not Successfully...");
            }
        }
        else
        {
            return BadRequest("Invalid Data...");
        }
    }



    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPut]
    public async Task<ActionResult<Customer>> UpdateCustomer(Customer customer)
    {
        if (ModelState.IsValid)
        {
            int result = await _customerRepository.UpdateAsync(customer);
            if (result > 0)
            {
                return Ok("Updated Successfully....");
            }
            else
            {
                return BadRequest("Modification Not Successful!");
            }
        }
        else
        {
            return BadRequest("Invalid Data!");
        }
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteCustomer(int id)
    {
        int result = await _customerRepository.DeleteAsync(id);
        if (result > 0)
        {
            return Ok("Customer Deleted Successfully....");
        }
        else
        {
            return NotFound("this ["+id+"] Customer Not Found...");
        }
    }






}
