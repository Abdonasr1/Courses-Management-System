using CMS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Persistence.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.FullName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(s => s.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(s => s.Phone)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(s => s.PasswordHash)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(s => s.Faculty)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(s => s.IsGraduated)
                   .HasDefaultValue(false);

            builder.Property(s => s.BirthDate)
                   .HasColumnType("date");
        }
    }
}
