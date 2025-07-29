using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Course : BaseEntity
    {
        public string Titel { get; set; } = string.Empty;
        public string? Description { get; set; }

        public int CategoryID { get; set; }
        public Category? Category { get; set; }
        public ICollection<Group> Groubs { get; set; } = new List<Group>();
    }
}
