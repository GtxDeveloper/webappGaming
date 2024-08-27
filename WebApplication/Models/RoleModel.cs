using System.Collections.Generic;
using System.Linq;
using WebApplication.Entities;

namespace WebApplication.Models
{
	public class RoleModel
	{
		private readonly GamePortalDbContext _gamePortalDbContext;

		public RoleModel(GamePortalDbContext gamePortalDbContext)
		{
			_gamePortalDbContext = gamePortalDbContext;
		}

		public List<Role> Roles
		{
			get {
				return _gamePortalDbContext.Roles.ToList();	
			}
		}
		public Role GetRole(int id)
		{
			return _gamePortalDbContext.Roles.SingleOrDefault(r => r.Id == id);
		}
	}
}
