using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerServices customerServices;

        public CustomerController(ICustomerServices customerServices)
        {
            this.customerServices = customerServices;
        }

        // GET: api/<ClientController>
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Get()
        {
            var result = await customerServices.GetAllCustomerBasic();
            if (result != null) return Ok(result);
            return NotFound(result);
        }



    }
}
