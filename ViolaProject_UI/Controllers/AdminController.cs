using Microsoft.AspNetCore.Mvc;

namespace ViolaProject_UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
