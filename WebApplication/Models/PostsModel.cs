using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entities;

namespace WebApplication.Models
{
    public class PostsModel
    {
        private readonly GamePortalDbContext _gamePortalDbContext;
        public PostsModel(GamePortalDbContext gamePortalDbContext)
        {
            _gamePortalDbContext = gamePortalDbContext;
        }
        public List<Post> GetPosts(int limit = 4, int offset = 0)
        {
            return _gamePortalDbContext.Posts.OrderByDescending(x => x.DateOfPunlished).Skip(offset).Take(limit).ToList();
        }

        public List<Post> FilteredPostsByTag(string tagSlug, int limit = 10, int skip = 0)
        {
            return (from pst in _gamePortalDbContext.Posts
                    join pstTag in _gamePortalDbContext.PostTags on pst.Id equals pstTag.PostId
                    join tg in _gamePortalDbContext.Tags on pstTag.TagId equals tg.Id
                    where tg.Slug.Equals(tagSlug) && pst.Status == PostStatus.Published
                    orderby pst.DateOfPunlished
                    select pst).Skip(skip).Take(limit).ToList();
        }

        internal int GetPostCount()
        {
            return _gamePortalDbContext.Posts.Where(p => p.Status == PostStatus.Published).Count();
        }

        public List<Post> FilteredPostsByGenre(string genreSlug, int limit = 10, int skip = 0)
        {
            return (from pst in _gamePortalDbContext.Posts
                    join gen in _gamePortalDbContext.Genres on pst.GenreId equals gen.Id
                    where gen.Slug.Equals(genreSlug) && pst.Status == PostStatus.Published
                    orderby pst.DateOfPunlished
                    select pst).Skip(skip).Take(limit).ToList();
        }

        public List<Post> FilteredPostsByCategory(string categorySlug, int limit = 10, int skip = 0)
        {
            return (from pst in _gamePortalDbContext.Posts
                    join cat in _gamePortalDbContext.Categories on pst.CategoryId equals cat.Id
                    where cat.Slug.Equals(categorySlug) && pst.Status == PostStatus.Published
                    orderby pst.DateOfPunlished
                    select pst).Skip(skip).Take(limit).ToList();
        }

        public List<Post> FilteredPostsByPlatform(string platformSlug, int limit = 10, int skip = 0)
        {
            return (from pst in _gamePortalDbContext.Posts
                        join plt in _gamePortalDbContext.Platforms on pst.PlatformId equals plt.Id
                        where plt.Slug.Equals(platformSlug) && pst.Status == PostStatus.Published
                        orderby pst.DateOfPunlished
                        select pst).Skip(skip).Take(limit).ToList();
        }

        public List<Post> GetLastPosts(int count)
        {
           return _gamePortalDbContext.Posts.Where(p => p.Status == PostStatus.Published).OrderByDescending(pst => pst.DateOfPunlished).ToList();
        }

        public Post GetPostBySlug(string postslug)
        {
            var post =  _gamePortalDbContext.Posts.FirstOrDefault(p => p.Slug == postslug && p.Status == PostStatus.Published);
            post.Category = _gamePortalDbContext.Categories.FirstOrDefault(c => c.Id == post.CategoryId);
            post.Genre = _gamePortalDbContext.Genres.FirstOrDefault(g => g.Id == post.GenreId);
            post.Platform = _gamePortalDbContext.Platforms.FirstOrDefault(p => p.Id == post.PlatformId);

            return post;
        }
    }
}
