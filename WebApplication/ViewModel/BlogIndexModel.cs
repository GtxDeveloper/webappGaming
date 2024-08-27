
using System.Collections.Generic;
using WebApplication.Common;
using WebApplication.Entities;

namespace WebApplication.ViewModel
{
    public class BlogIndexModel
    {
        public List<Post> Posts{ get; set; }
        public List<Category> Categories { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Platform> Platforms { get; set; }
        public List<Tag> Tags { get; set; }

        public PaginateHelper PaginateHelper { get; set; }
    }
}
