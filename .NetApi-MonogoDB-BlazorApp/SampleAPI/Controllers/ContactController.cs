using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private static MongoDataAccess db;
        private static string tableName = "Contacts"; // or the Collection cause Collection = table 
        private static IConfiguration _config;
        public ContactsController(IConfiguration config)
        {
            _config = config;
            db = new MongoDataAccess("MongoContactsDB", _config.GetConnectionString("Default"));

        }
        [HttpGet]
        public List<ContactModel> GetAll()
        {
            return db.LoadRecords<ContactModel>(tableName);
        }
 
    }
}