using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mysqlproject.Controllers.data;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IActionResult _result;
        //private readonly AddDbContext result;

        //private readonly AddDbContext _Contact;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_login = login; 
            //_Contact = Contact;
            

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
