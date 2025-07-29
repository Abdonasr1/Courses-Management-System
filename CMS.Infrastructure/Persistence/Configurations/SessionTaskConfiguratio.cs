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
    internal class SessionTaskConfiguratio : IEntityTypeConfiguration<SessionTask>
    {
        public void Configure(EntityTypeBuilder<SessionTask> builder)
        {
            builder.ToTable("Tasks");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(t => t.Description)
                   .HasMaxLength(500);

            builder.Property(t => t.DateLine)
                   .IsRequired();

            builder.HasOne(t => t.Session)
                   .WithMany(s => s.Tasks)
                   .HasForeignKey(t => t.SessionId);
        }
    }
}
