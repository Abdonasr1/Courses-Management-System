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
    public class GroupStudentConfiguration : IEntityTypeConfiguration<GroupStudent>
    {
        public void Configure(EntityTypeBuilder<GroupStudent> builder)
        {
            builder.ToTable("GroupStudents");

            builder.HasKey(gs => new { gs.GroupId, gs.StudentId });

            builder.HasOne(gs => gs.Group)
                   .WithMany(g => g.GroupStudents)
                   .HasForeignKey(gs => gs.GroupId);

            builder.HasOne(gs => gs.Student)
                   .WithMany(s => s.GroupStudents)
                   .HasForeignKey(gs => gs.StudentId);
        }
    }

}
