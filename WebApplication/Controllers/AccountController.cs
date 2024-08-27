using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using WebApplication.Entities;
using WebApplication.Models;

namespace WebApplication.Controllers
{
	public class AccountController : Controller
	{
		private GamePortalDbContext _gamePortalDb = new GamePortalDbContext(new DbContextOptions<GamePortalDbContext>());

		private UserModel _userModel;

        public AccountController()
        {
			_userModel = new UserModel(_gamePortalDb);
		}

		[HttpPost]
		public IActionResult CheckUser(string email, string password)
		{

			User user = _userModel.GetUser(email);

			string hashPass =  SecurePasswordHasher.Hash(password);

			if (user != null && password == user.Password)
			{
				Autentificate(user);
				return RedirectToAction("Index", "Admin");
			} else
			{
				ErrorViewModel errorViewModel = new ErrorViewModel()
				{
					ErrorMessage = "Incorrect User data"
				};
				return View("Login", errorViewModel);
			}
		}

		private void Autentificate(User user)
		{
			var claims = new List<Claim> {

				new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
				new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.Name),
				new Claim(ClaimTypes.Email, user.Email),
			};

			ClaimsIdentity claimsIdentity = 
				new ClaimsIdentity(claims, "ApplicationCoockie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
			HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
		}

		[HttpGet]
		public IActionResult Logout()
		{
			HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Login");
		}


		[HttpGet]
		public IActionResult Index()
		{
			return RedirectToAction("Login");
		}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}



		[HttpGet]
		public IActionResult ForgotPassword()
		{
			return View();
		}

		[HttpGet]
		public IActionResult AccsessDenied()
		{
			return View();
		}

		[HttpGet]
		public IActionResult SetupNewPassword()
		{
			return View();
		}




		[HttpPost]
		public IActionResult CreateUser(string email, string login, string password, string cpassword)
		{
			// Валидация полученных данных
			// создать юзера и добавить в бд
			// RedirectToAction("Login", "Account");
			throw new Exception();
		}
	}
}
