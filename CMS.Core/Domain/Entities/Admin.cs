using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Admin : UserBase
    {
        public string PasswordHash { get; set; } = string.Empty;
    }
}
