using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Entities
{
    public class Navigate
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Href { get; set; }

        public int Order { get; set; }

        [DefaultValue(false)]
        [ForeignKey("Id")]
        public int? Parent_Id { get; set; }

        public ICollection<Navigate> Childs { get; set; }
    }
}
