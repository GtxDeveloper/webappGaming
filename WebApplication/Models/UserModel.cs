using System;
using System.Linq;
using WebApplication.Entities;

namespace WebApplication.Models
{
	public class UserModel
	{
		private readonly GamePortalDbContext _gamePortalDbContext;
		public UserModel(GamePortalDbContext gamePortalDbContext)
		{
			_gamePortalDbContext = gamePortalDbContext;

			/* каждому user назначить role */
			foreach (var user in _gamePortalDbContext.Users)
			{
				foreach (var role in _gamePortalDbContext.Roles)
				{
					if(user.RoleId == role.Id)
					{
						user.Role = role;
						break;
					}
				}
			}
		}

		public User GetUser(string email, string password)
		{
			return _gamePortalDbContext.Users.SingleOrDefault(u => u.Email == email && u.Password == password);
		}

		public bool AddUser(User user)
		{
			_gamePortalDbContext.Users.Add(user);
			return _gamePortalDbContext.SaveChanges() == 1? true: false;
		}

		public bool ChangePassword(int userId, string password)
		{
			_gamePortalDbContext.Users.SingleOrDefault(u => u.Id == userId).Password = password;
			return _gamePortalDbContext.SaveChanges() == 1 ? true : false;
		}
		public bool ChangePassword(string email, string password)
		{
			_gamePortalDbContext.Users.SingleOrDefault(u => u.Email == email).Password = password;
			return _gamePortalDbContext.SaveChanges() == 1 ? true : false;
		}

	

		public User GetUser(string email)
		{
			return _gamePortalDbContext.Users.SingleOrDefault(u => u.Email == email);
		}

        public bool ChangeLogin(int id, string login)
        {
			_gamePortalDbContext.Users.FirstOrDefault(u => u.Id == id).Login = login;
			return _gamePortalDbContext.SaveChanges() == 1 ? true : false;
		}
    }
}
