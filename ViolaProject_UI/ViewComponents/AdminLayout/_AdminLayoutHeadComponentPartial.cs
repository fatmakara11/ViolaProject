using Microsoft.AspNetCore.Mvc;

namespace ViolaProject_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {  
            return View();
        }
    }
}
