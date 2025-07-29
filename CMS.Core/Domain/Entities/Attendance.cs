using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Core.Domain.Entities
{
    public class Attendance : BaseEntity
    {

        public int SessionId { get; set; }
        public Session? Session { get; set; }

        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public string Status { get; set; } = "Present";
        public string? Note { get; set; }
    }
}