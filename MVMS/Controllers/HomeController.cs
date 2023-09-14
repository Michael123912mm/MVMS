using Microsoft.AspNetCore.Mvc;
using MVMS.Models;
using System.Diagnostics;

namespace MVMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }

        public IActionResult NewTeam()
        {
            return View();
        }
        public IActionResult Rooms()
        {
            return View();
        }
        public IActionResult Booking()
        {
            return View();
        }
        public IActionResult AddRooms()
        {
            return View();
        }
        public IActionResult AddBooking()
        {
            return View();
        }
        public IActionResult Report()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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