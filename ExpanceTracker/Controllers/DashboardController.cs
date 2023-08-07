using Microsoft.AspNetCore.Mvc;

namespace ExpanceTracker.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
