using Microsoft.AspNetCore.Mvc;

namespace ViolaProject_UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
