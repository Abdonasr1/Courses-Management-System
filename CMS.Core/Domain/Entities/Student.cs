using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Student : UserBase
    {
        public string PasswordHash { get; set; } = string.Empty;
        public string Faculty { get; set; } = string.Empty;
        public bool IsGraduated { get; set; } = false;
        public DateTime? BirthDate { get; set; }


        public ICollection<GroupStudent> GroupStudents { get; set; } = new List<GroupStudent>();
        public ICollection<Solution> Solutions { get; set; } = new List<Solution>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
    }
}
