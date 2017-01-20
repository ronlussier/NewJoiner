using Microsoft.AspNetCore.Mvc;
using NewJoiner.Models;

namespace NewJoiner.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
