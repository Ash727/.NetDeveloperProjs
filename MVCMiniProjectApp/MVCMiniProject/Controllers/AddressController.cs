using Microsoft.AspNetCore.Mvc;
using MVCMiniProject.Models;

namespace MVCMiniProject.Controllers
{
    public class AddressController : Controller
    {
        public string City { get; set; }
        private readonly ILogger<HomeController> _logger;
        //private AddressModel _addressModel = new AddressModel();
  
        public AddressController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // GET: Person
        public ActionResult Index()
        {
            // Wont Work because stateless
            //ViewBag.City2 = _addressModel.City;
            //Console.WriteLine($"Here's the City {ViewBag.City2}");

            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Person/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddressModel data)
        {
            // Performs server sisde validation of during posting of data
            // Checks the model of the Address 
            if(ModelState.IsValid == false)
            {
                _logger.LogWarning("The user submitted an invliad address upon create");
            }
            // The data here is how we wwould get the user from the user
            Console.WriteLine($"Here's the postal {data.PostalCode}");
            
            // Wpont work because its stateless 
            //_addressModel.City = data.City;
            //Console.WriteLine($"aDDRESS cITY{_addressModel.City}");

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
