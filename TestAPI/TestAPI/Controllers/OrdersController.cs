using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly TestAPIContext _context;

        public OrdersController(TestAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("orders")]
        public IEnumerable<Order> Get()
        {
            return _context.Orders;
        }

        [HttpGet]
        [Route("orders/{id}/products")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var products = await _context.Products.Where(x => x.OrderToProductList.Any(c => c.OrderId == id)).ToListAsync();

            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);
        }
    }
}