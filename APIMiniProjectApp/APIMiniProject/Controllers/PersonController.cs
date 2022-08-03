using Microsoft.AspNetCore.Mvc;
using APIMiniProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private ILogger _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        // POST api/<PersonController>
        /// <summary>
        /// With the use of postman using the post lik and hitting send https://localhost:7265/api/Person
        /// We can get the information at this end point 
        /// </summary>
        /// <param name="person"></param>
        [HttpPost]
        public void Post([FromBody]PersonModel person)
        {
            _logger.LogInformation("The person was logged as {Person}", person);
        }

    }
}
