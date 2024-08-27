using System.Collections.Generic;
using System.Linq;
using WebApplication.Entities;

namespace WebApplication.Models
{
    public class GenresModel
    {
        private readonly GamePortalDbContext _gamePortalDbContext;

        public GenresModel(GamePortalDbContext gamePortalDbContext)
        {
            _gamePortalDbContext = gamePortalDbContext;
        }
        public List<Genre> GetGenres()
        {
            return _gamePortalDbContext.Genres.OrderBy(x => x.Id).ToList();
        }
        public Tag GetGenreById(int Id)
        {
            return _gamePortalDbContext.Tags.FirstOrDefault(t => t.Id == Id);
        }
        public Tag GetGenreBySlug(string slug)
        {
            return _gamePortalDbContext.Tags.FirstOrDefault(t => t.Slug == slug);
        }
    }
}
