using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Components
{
    public class SocialLinksViewComponent:ViewComponent
    {
        private OptionsModel _optionsModel;
        public SocialLinksViewComponent()
        {
            _optionsModel = new OptionsModel(new GamePortalDbContext(new DbContextOptions<GamePortalDbContext>()));
        }

        public IViewComponentResult Invoke()
        {
            return View("SocialLinks", _optionsModel.GetOptionsByRelation("socialLinks"));
        }
    }
}
