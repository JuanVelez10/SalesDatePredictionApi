using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrderServices orderServices;

        public OrderController(IOrderServices orderServices)
        {
            this.orderServices = orderServices;
        }

        // GET api/<OrderController>/5
        [HttpGet("Customer/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await orderServices.GetOrdersForCustomerId(id);
            if (result != null) return Ok(result);
            return NotFound(result);
        }

    }
}
