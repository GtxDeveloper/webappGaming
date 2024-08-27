using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class PostTags
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public int TagId { get; set; }

        public Post Post { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
