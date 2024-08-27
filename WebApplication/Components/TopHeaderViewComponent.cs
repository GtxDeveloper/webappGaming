using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Components
{
    public class TopHeaderViewComponent:ViewComponent
    {
        public TopHeaderViewComponent()
        {
        }
        public IViewComponentResult Invoke()
        {
            return View("TopHeader");
        }
    }
}
