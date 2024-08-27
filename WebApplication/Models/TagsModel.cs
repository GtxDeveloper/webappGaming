using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Entities;

namespace WebApplication.Models
{
    public class TagsModel
    {
        private readonly GamePortalDbContext _gamePortalDbContext;

        public TagsModel(GamePortalDbContext gamePortalDbContext)
        {
            _gamePortalDbContext = gamePortalDbContext;
        }
        public List<Tag> GetTags()
        {
            return _gamePortalDbContext.Tags.OrderBy(x => x.Id).ToList();
        }
        public Tag GetTagById(int Id)
        {
            return _gamePortalDbContext.Tags.FirstOrDefault(t => t.Id == Id);
        }
        public Tag GetTagBySlug(string slug)
        {
            return _gamePortalDbContext.Tags.FirstOrDefault(t => t.Slug == slug);
        }

        public List<Tag> GetTagsByPostId(int postId)
        {
            return (from pstM in _gamePortalDbContext.PostTags
                    join tag in _gamePortalDbContext.Tags on pstM.TagId equals tag.Id
                    where pstM.PostId == postId
                    orderby tag.Id
                    select tag).ToList();
        }
    }
}
