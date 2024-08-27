using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class Platform
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImgSrc { get; set; }

        public string ImgAlt { get; set; }

        public string Slug { get; set; }

        public int? ParentId { get; set; } = null;

        public ICollection<Platform> Childs { get; set; }
    }
}
