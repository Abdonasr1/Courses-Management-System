using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMS.Core.Domain.Entities
{
    public class GroupInstructor
    {
        public int GroupId { get; set; }
        public Group Group { get; set; } = null!;

        
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } = null!;
    }
}