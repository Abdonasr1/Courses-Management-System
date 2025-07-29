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
    public class SolutionConfiguration : IEntityTypeConfiguration<Solution>
    {
        public void Configure(EntityTypeBuilder<Solution> builder)
        {
            builder.ToTable("Solutions");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.SubmittedAt)
                   .IsRequired();

            builder.Property(s => s.FileUrl)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(s => s.Grade)
                   .IsRequired()
                   .HasColumnType("decimal(5,2)");

            builder.HasOne(s => s.Student)
                   .WithMany(st => st.Solutions)
                   .HasForeignKey(s => s.StudentId);

            builder.HasOne(s => s.SessionTask)
                   .WithMany(t => t.Solutions)
                   .HasForeignKey(s => s.TaskId);
        }
    }

}
