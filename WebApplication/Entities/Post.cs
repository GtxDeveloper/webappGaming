using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int GenreId { get; set; }
        public int PlatformId { get; set; }
        public string ImgSrc { get; set; }
        public string ImgAlt { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreate { get; set; } = DateTime.Now;
        public DateTime DateOfPunlished { get; set; } = DateTime.Now;
        public PostStatus Status { get; set; } = PostStatus.Created;
        public Category Category { get; set; }
        public Genre Genre { get; set; }
        public Platform Platform { get; set; }
    }
}
