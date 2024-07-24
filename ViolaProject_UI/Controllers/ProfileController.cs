using Microsoft.AspNetCore.Mvc;

namespace ViolaProject_UI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
