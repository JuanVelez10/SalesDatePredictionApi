using Application.Interfaces;
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

        // GET: api/<ClientController>/name
        [HttpGet]
        public IEnumerable<string> Get(string name)
        {
            return new string[] { "value1", "value2" };
        }

    }
}
