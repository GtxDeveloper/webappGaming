using System.Collections.Generic;
using WebApplication.Entities;

namespace WebApplication.ViewModel
{
    public class BlogOnePostModel
    {
        public Post Post { get; set; }

        public List<Tag> Tags { get; set; }

    }
}
