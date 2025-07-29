namespace CMS.Core.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


        public int? CreatedById { get; set; }
        public UserBase? CreatedBy { get; set; }


        public int? UpdatedById { get; set; }
        public UserBase? UpdatedBy { get; set; }
    }
}