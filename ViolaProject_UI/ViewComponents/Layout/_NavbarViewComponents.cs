using Microsoft.AspNetCore.Mvc;

namespace ViolaProject_UI.ViewComponents.Layout
{
    public class _NavbarViewComponents:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
