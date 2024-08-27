using System.Collections.Generic;
using System.Linq;
using WebApplication.Entities;

namespace WebApplication.Models
{
    public class PlatformsModel
    {
        private readonly GamePortalDbContext _gamePortalDbContext;

        public PlatformsModel(GamePortalDbContext gamePortalDbContext)
        {
            _gamePortalDbContext = gamePortalDbContext;
        }
        public List<Platform> GetPlatforms()
        {
            return _gamePortalDbContext.Platforms.OrderBy(x => x.Id).ToList();
        }
        public Platform GetPlatformById(int Id)
        {
            return _gamePortalDbContext.Platforms.FirstOrDefault(t => t.Id == Id);
        }
        public Platform GetPlatformBySlug(string slug)
        {
            return _gamePortalDbContext.Platforms.FirstOrDefault(t => t.Slug == slug);
        }
    }
}
