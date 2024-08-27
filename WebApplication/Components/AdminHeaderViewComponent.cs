using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Components
{
    public class AdminHeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("AdminHeader");
        }
    }
}
