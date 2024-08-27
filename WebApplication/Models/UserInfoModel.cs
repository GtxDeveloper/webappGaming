using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Entities;

namespace WebApplication.Models
{
	public class UserInfoModel
	{
		private readonly GamePortalDbContext _gamePortalDbContext;
		public UserInfoModel(GamePortalDbContext gamePortalDbContext)
		{
			_gamePortalDbContext = gamePortalDbContext;
			foreach (var user in _gamePortalDbContext.Users)
			{
				foreach (var uInfo in _gamePortalDbContext.UsersInfo)
				{
					if (user.Id == uInfo.UserId)
					{
						uInfo.User = user;
					}
				}
			}
		}

		public UserInfo UserInfo(string userEmail)
		{
			return (from uin in _gamePortalDbContext.UsersInfo
			join usr in _gamePortalDbContext.Users on uin.UserId equals usr.Id
			where usr.Email == userEmail
			select uin).SingleOrDefault();
		}

		public UserInfo UserInfo(int userId)
		{
			return _gamePortalDbContext.UsersInfo.SingleOrDefault(ui => ui.UserId == userId);
		}

        public UserInfo GetUserInfoByLogin(string login)
        {
			return _gamePortalDbContext.UsersInfo.SingleOrDefault(ui => ui.User.Login == login);
		}

        public bool ChangeAvatar(string vatarPath, string login)
        {
			GetUserInfoByLogin(login).Avatar = vatarPath;
			return _gamePortalDbContext.SaveChanges() == 1 ? true : false;
		}

        public bool ChangeInfo(UserInfo userInfo)
        {
			var userInf = UserInfo(userInfo.Id);
			userInf.Address = userInfo.Address;
			userInf.CompanySite = userInfo.CompanySite;
			userInf.CompanyTitle = userInfo.CompanyTitle;
			userInf.Country = userInfo.Country;
			userInf.Info = userInfo.Info;
			userInf.JobTitle = userInfo.JobTitle;
			userInf.Name = userInfo.Name;
			userInf.PhoneNumber = userInfo.PhoneNumber;
			userInf.Surname = userInfo.Surname;
			return _gamePortalDbContext.SaveChanges() == 1 ? true : false;
		}
    }
}
