using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCMiniProject.Controllers
{
    public class Person : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public Person(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET: Person
        public ActionResult Index()
        {
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
        public ActionResult Create(IFormCollection collection)
        {
            if(ModelState.IsValid == false)
            {

                return View();
            }

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
