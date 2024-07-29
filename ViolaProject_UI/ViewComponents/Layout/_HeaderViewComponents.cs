using Microsoft.AspNetCore.Mvc;

namespace ViolaProject_UI.ViewComponents.Layout
{
    public class _HeaderViewComponents : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
