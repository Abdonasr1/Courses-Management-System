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
    public class GroupInstructorConfiguration : IEntityTypeConfiguration<GroupInstructor>
    {
        public void Configure(EntityTypeBuilder<GroupInstructor> builder)
        {
            builder.ToTable("GroupInstructors");

            builder.HasKey(gi => new { gi.GroupId, gi.InstructorId });

            builder.HasOne(gi => gi.Group)
                   .WithMany(g => g.GroupInstructors)
                   .HasForeignKey(gi => gi.GroupId);

            builder.HasOne(gi => gi.Instructor)
                   .WithMany(i => i.GroubInstructors)
                   .HasForeignKey(gi => gi.InstructorId);
        }
    }

}
