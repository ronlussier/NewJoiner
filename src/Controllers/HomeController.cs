using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewJoiner.Models;

namespace NewJoiner.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            Hotel  hotel = new Hotel() 
            {
                id = 1,
                name = "Doubletree by Hilton Kulala Lumpur",
                stars = 4,
                city = "Kuala Lumpur",
                country = "Malaysia"
            };

            await Task.Yield();
            return this.View(hotel);
        }
        
        public async Task<IActionResult> About()
        {
            ViewData["Message"] = "Your application description page.";

            await Task.Yield();
            return this.View();
        }

        public async Task<IActionResult> Contact()
        {
            ViewData["Message"] = "Your contact page.";

            await Task.Yield();
            return this.View();
        }

        public async Task<IActionResult> Error()
        {
            await Task.Yield();
            return this.View();
        }
    }
}
