using Microsoft.AspNetCore.Mvc;
using NewJoiner.Models;

namespace NewJoiner.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Hotel  hotel = new Hotel() 
            {
                id = 1,
                name = "Doubletree by Hilton Kulala Lumpur",
                stars = 4,
                city = "Kuala Lumpur",
                country = "Malaysia"
            };

            return View(hotel);
        }
        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
