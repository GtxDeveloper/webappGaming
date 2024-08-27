
using System.Collections.Generic;

namespace WebApplication.Entities
{
    public class Category
    { 
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Slug { get; set; }

        public int? ParentId { get; set; } = null;

        public ICollection<Category> Childs { get; set; }
    }
}
