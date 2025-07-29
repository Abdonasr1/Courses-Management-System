using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class SessionTask : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime DateLine { get; set; } 

        public int? SessionId { get; set; }
        public Session? Session { get; set; }

        
        public ICollection<Solution> Solutions { get; set; } = new List<Solution>();
    }
}
