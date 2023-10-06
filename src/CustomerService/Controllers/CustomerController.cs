using CustomerService.Models;
using CustomerService.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customers = await _customerService.GetAllAsync();
            return Ok(customers);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var customer = await _customerService.GetByIdAsync(id);
            if (customer == null)
                return NotFound();

            return Ok(customer);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Customer customer)
        {
            var newCustomer = await _customerService.CreateAsync(customer);
            return CreatedAtAction(nameof(Get), new { id = newCustomer.Id }, newCustomer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _customerService.DeleteAsync(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Customer customer)
        {
            if (id != customer.Id)
                return BadRequest();

            var updated = await _customerService.UpdateAsync(customer);
            if (updated == null)
                return NotFound();

            return NoContent();
        }
    }
}
