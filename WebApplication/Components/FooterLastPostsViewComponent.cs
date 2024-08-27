using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Components
{
    public class FooterLastPostsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("FooterLastPosts");
        }
    }
}
