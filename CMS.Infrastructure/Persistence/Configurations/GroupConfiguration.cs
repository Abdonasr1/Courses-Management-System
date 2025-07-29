using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Core.Domain.Entities;

namespace CMS.Infrastructure.Persistence.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("Groups");

            builder.HasKey(g => g.Id);

            builder.Property(g => g.GroubName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(g => g.StartDate)
                   .HasColumnType("date");

            builder.Property(g => g.EndDate)
                   .HasColumnType("date");

            builder.HasOne(g => g.Course)
                   .WithMany(c => c.Groubs)
                   .HasForeignKey(g => g.CourseId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
