using Microsoft.AspNetCore.Mvc;
using ControllersApiDemo.Models;

namespace ControllersApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private static List<Customer> customers = new();

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            customers.Add(customer);
            return Ok(customer);
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(customers);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer == null) return NotFound();
            customers.Remove(customer);
            return Ok();
        }
    }
}
