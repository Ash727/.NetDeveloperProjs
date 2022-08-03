using MessagWallAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessagWallAPI.Controllers
{
    // We can change it to anything we want like something/[controller]
    [Route("api/[controller]")]
    [ApiController]
    public class MessageWallController : ControllerBase
    {
        private ILogger<MessageWallController> _logger;

        // Has to be created with CTOR TAB and create the ILOGGER<Messagewall> yourself
        public MessageWallController(ILogger<MessageWallController> logger)
        {
            _logger = logger; 
        }
        // GET: api/<MessageWallController>
        [HttpGet]
        //public IEnumerable<string> Get(string message = "something") can be used like api/Messagewall?message=something 
        //public IEnumerable<string> Get(string message = "something", int id=0) can be used like api/Messagewall?message=something&&id=4 
        public IEnumerable<string> Get()
        {
            //List<string> output = new List<string>()
            //{
            //    "Hello World",
            //    "How are you?"
            //};
            //if (string.IsNullOrEmpty(message) == false)
            //{
            //    output.Add(message);
            //}
            //return output;
            return new string[] { "value1", "value2" };
        }

        // GET api/<MessageWallController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MessageWallController>
        [HttpPost]
        public void Post([FromBody] MessageModel message)
            // With custome created Message Model we capture json data 
            // With postman we can test these things without going 
        {
            _logger.LogInformation("Our mesage was {Message}", message.Message);
        }

        // PUT api/<MessageWallController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MessageWallController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
