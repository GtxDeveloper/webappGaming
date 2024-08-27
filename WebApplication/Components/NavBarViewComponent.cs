using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication.Common;
using WebApplication.Entities;
using WebApplication.Models;

namespace WebApplication.Components
{
    public class NavBarViewComponent:ViewComponent
    {
        private NavigateModel _navigateModel;
        public NavBarViewComponent()
        {
            _navigateModel = new NavigateModel(new GamePortalDbContext(new DbContextOptions<GamePortalDbContext>()));
        }
        public IViewComponentResult Invoke()
        {
			List<Navigate> tree = _navigateModel.GetNavigateTree();
			if (CustomHttpContext.HttpContext.User.Identity.IsAuthenticated)
			{
				var elem = new Entities.Navigate()
				{
					Href = "/Account/Logout",
					Title = "Выход",
					Order = 100
				};
				elem.Childs = new List<Navigate>();
				tree.Add(elem);
			}
			else
			{
				var elem = new Entities.Navigate()
				{
					Href = "/Account/Login",
					Title = "Вход",
					Order = 100
				};
				elem.Childs = new List<Navigate>();
				tree.Add(elem);

				elem = new Entities.Navigate()
				{
					Href = "/Account/Register",
					Title = "Регистрация",
					Order = 100
				};
				elem.Childs = new List<Navigate>();
				tree.Add(elem);
			}
			return View("NavBar", tree);
        }
    }
}
