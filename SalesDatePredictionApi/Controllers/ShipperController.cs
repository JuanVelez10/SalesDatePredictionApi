using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private readonly IShipperServices shipperServices;

        public ShipperController(IShipperServices shipperServices)
        {
            this.shipperServices = shipperServices;
        }

        // GET api/<ShipperController>
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Get()
        {
            var result = await shipperServices.GetAll();
            if (result != null) return Ok(result);
            return NotFound(result);
        }
    }
}
