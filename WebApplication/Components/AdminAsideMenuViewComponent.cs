using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Components
{
    public class AdminAsideMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("AdminAsideMenu");
        }
    }
}
