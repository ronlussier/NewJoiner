using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewJoiner.Models;

namespace NewJoiner.Controllers
{
    public class AdminController : Controller
    {
        public async Task<IActionResult> Index()
        {
            await Task.Yield();
            return this.View();
        }
    }
}
