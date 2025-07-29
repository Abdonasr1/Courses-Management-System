using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CMS.Core.Domain.Entities;

namespace CMS.Infrastructure.Configurations
{
    public class AttendanceConfiguration :IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.ToTable("Attendances");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Status)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasDefaultValue("Present");

            builder.Property(a => a.Note)
                   .HasMaxLength(250);

            builder.HasOne(a => a.Session)
                   .WithMany(s => s.Attendances)
                   .HasForeignKey(a => a.SessionId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Student)
                   .WithMany(s => s.Attendances)
                   .HasForeignKey(a => a.StudentId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
