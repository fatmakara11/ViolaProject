using Microsoft.AspNetCore.Mvc;

namespace ViolaProject_UI.ViewComponents.HomePage
{
    public class _DefaultHomePageBestseller:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
