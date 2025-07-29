using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Core.Domain.Entities
{
    public class Payment : BaseEntity
    {

        public int StudentId { get; set; }
        public Student? Student { get; set; }


        public int? GroupId { get; set; }
        public Group? Group { get; set; }


        public decimal Amount { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; } 
        public string PaymentMethod { get; set; } = string.Empty;

        
    }
}