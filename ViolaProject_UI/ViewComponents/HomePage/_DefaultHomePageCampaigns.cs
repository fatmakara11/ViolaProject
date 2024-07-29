using Microsoft.AspNetCore.Mvc;

namespace ViolaProject_UI.ViewComponents.HomePage
{
    public class _DefaultHomePageCampaigns:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
