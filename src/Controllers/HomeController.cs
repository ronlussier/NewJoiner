using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using NewJoiner.Models;

namespace NewJoiner.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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

        public async Task<IActionResult> Errors()
        {
            int  errCode = HttpContext.Response.StatusCode;

            _logger.LogInformation( "Value of errCode is '{errCode}'", errCode );
            if (errCode == 500 | errCode == 404) 
            {
                await Task.Yield();
                return this.View($"~/Views/Errors/{errCode}.cshtml");
            }

            await Task.Yield();
            return this.View("~/Views/Errors/genericError.cshtml");
        }
    }
}
