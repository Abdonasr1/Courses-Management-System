using CMS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Persistence.Configurations
{
    public class SessionGroupConfiguration : IEntityTypeConfiguration<SessionGroup>
    {
        public void Configure(EntityTypeBuilder<SessionGroup> builder)
        {
            builder.ToTable("SessionGroups");

            builder.HasKey(sg => new { sg.SessionId, sg.GroupId });

            builder.HasOne(sg => sg.Session)
                   .WithMany(s => s.SessionsGroup)
                   .HasForeignKey(sg => sg.SessionId);

            builder.HasOne(sg => sg.Group)
                   .WithMany(g => g.SessionGroups)
                   .HasForeignKey(sg => sg.GroupId);
        }
    }

}
