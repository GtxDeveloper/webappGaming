using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entities;

namespace WebApplication.Models
{
    public class CommentModel
    {
        private readonly GamePortalDbContext _gamePortalDbContext;

        public CommentModel(GamePortalDbContext gamePortalDbContext)
        {
            _gamePortalDbContext = gamePortalDbContext;
        }

        public List<Comment> GetCommentsByPostId(int postId)
        {
            return _gamePortalDbContext.Comments.Where(c => c.IsValid == true).ToList();
        }

        public List<Comment> GetCommentsTreeByPostId(int postId)
        {
            var comments = _gamePortalDbContext.Comments;

            foreach (var oneComm in comments)
            {
                oneComm.Childs = new List<Comment>();
                foreach (var item in _gamePortalDbContext.Comments)
                {
                    if(oneComm.Id == item.ParentId)
                    {
                        oneComm.Childs.Add(item);
                    }
                }
            }
            return comments.Where(c => c.ParentId == null && c.PostId == postId && c.IsValid == true).ToList();
        }

        public bool AddComment(Comment comment)
        {
            _gamePortalDbContext.Comments.Add(comment);
            return _gamePortalDbContext.SaveChanges() == 1 ? true : false;
        }
    }
}
