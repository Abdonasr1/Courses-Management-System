using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMS.Core.Domain.Entities
{
    public class GroupStudent
    {
        public int GroupId { get; set; }
        public Group Group { get; set; } = null!;


        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
    }
}