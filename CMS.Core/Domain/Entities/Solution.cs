using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Core.Domain.Entities
{
    public class Solution : BaseEntity
    {
        public int? TaskId { get; set; }
        public SessionTask? SessionTask { get; set; }


        public int StudentId { get; set; }
        public Student? Student { get; set; }


        public DateTime SubmittedAt { get; set; } 
        public string FileUrl { get; set; } = string.Empty;
        public decimal Grade { get; set; }
        
    }
}