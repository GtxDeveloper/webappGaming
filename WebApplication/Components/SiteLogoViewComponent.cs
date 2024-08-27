using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Components
{
    public class SiteLogoViewComponent: ViewComponent
    {
        private OptionsModel _optionsModel;
        public SiteLogoViewComponent()
        {
            _optionsModel = new OptionsModel(new GamePortalDbContext(new DbContextOptions<GamePortalDbContext>()));
        }
        public IViewComponentResult Invoke()
        {
            return View("SiteLogo", _optionsModel.GetOptionByName("siteLogo"));
        }
    }
}
