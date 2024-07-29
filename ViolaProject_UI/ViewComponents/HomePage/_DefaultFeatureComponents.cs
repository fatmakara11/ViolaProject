using Microsoft.AspNetCore.Mvc;

namespace ViolaProject_UI.ViewComponents.HomePage
{
    public class _DefaultFeatureComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
