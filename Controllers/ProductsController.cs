using Microsoft.AspNetCore.Mvc;
using ControllersApiDemo.Models;

namespace ControllersApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new();

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            products.Add(product);
            return Ok(product);
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(products);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            products.Remove(product);
            return Ok();
        }
    }
}
