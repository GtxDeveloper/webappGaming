using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Error", "PageNotFound");
        }

        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}
