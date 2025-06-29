using Infoway.Api.Models;
using Infoway.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Infoway.Api.Controllers;

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
    public async Task<ActionResult<IEnumerable<Customer>>> Get()
    {
        var customers = await _customerRepository.GetAllAsync();
        if (customers.Count > 0)
        {
            return Ok(customers);
        }
        else
        {
            return NotFound();
        }
    }
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Customer>> Get(int id)
    {
        var customer = await _customerRepository.GetDetailsAsync(id);
        if (customer != null)
        {
            return Ok(customer);
        }
        else
        {
            return NotFound();
        }
    }
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPost]
    public async Task<ActionResult<Customer>> Post(Customer customer)
    {
        if (ModelState.IsValid)
        {
            int result = await _customerRepository.InsertAsync(customer);
            if (result > 0)
            {
                return CreatedAtAction("Get", customer.CustomerId, customer);
            }
            else
            {
                return BadRequest("Insert Not Successful!");
            }
        }
        else
        {
            return BadRequest("Invalid Data!");
        }

    }

    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPut]
    public async Task<ActionResult<Customer>> Put(Customer customer)
    {
        if (ModelState.IsValid)
        {
            int result = await _customerRepository.UpdateAsync(customer);
            if (result > 0)
            {
                return NoContent();
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
    public async Task<ActionResult> Delete(int id)
    {
        int result = await _customerRepository.DeleteAsync(id);
        if (result > 0)
        {
            return Ok();
        }
        else
        {
            return NotFound();
        }
    }
}