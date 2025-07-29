using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Session : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime SessionDate { get; set; } 
        public DateTime StartTime { get; set; } 



        public ICollection<SessionGroup> SessionsGroup { get; set;} = new List<SessionGroup>();
        public ICollection<SessionTask> Tasks { get; set;} = new List<SessionTask>();
        public ICollection<Attendance> Attendances { get; set;} = new List<Attendance>();

    }
}
