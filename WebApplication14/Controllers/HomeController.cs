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

        private readonly AddDbContext _context;

        private readonly AddDbContext _e;

        public HomeController(ILogger<HomeController> logger, AddDbContext context, AddDbContext e)
        {
            _logger = logger;
            _context = context;
            _e = e;
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
        [HttpPost]
        public IActionResult Privacy(e data)
        {
            _e.Add(data);
            _e.SaveChanges();
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact data) {
            _context.Add(data);
            _context.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
