using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int PostId { get; set; }
        public string VisitorName { get; set; }
        public string VisitorEmail { get; set; }
        public string VisitorAvatar { get; set; } = "/images/avatar-1.jpg";
        public string Subject { get; set; }
        public bool IsValid { get; set; } = false;

        public DateTime DateOfCreated = DateTime.Now;
        public int? ParentId { get; set; } = null;
        public Post Post { get; set; }
        public ICollection<Comment> Childs { get; set; }

    }
}
