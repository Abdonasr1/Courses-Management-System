using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CMS.Core.Domain.Entities
{
    public class SessionGroup
    {
        public int SessionId { get; set; }
        public Session Session { get; set; } = null!;



        public int GroupId { get; set; }
        public Group Group { get; set; } = null!;
    }
}