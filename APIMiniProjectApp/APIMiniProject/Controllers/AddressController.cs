using APIMiniProject.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private ILogger<PersonController> _logger;

        public AddressController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        // POST api/<AddressController>
        [HttpPost]
        public void Post([FromBody] AddressModel address)
        {
            _logger.LogInformation("The address was logged as {Address}", address);
        }
    }
}
