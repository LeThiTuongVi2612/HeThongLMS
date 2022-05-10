using LMS.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Infrastructure.Data.Config
{
    public class PayoutConfiguration : IEntityTypeConfiguration<Payout>
    {
        public void Configure(EntityTypeBuilder<Payout> builder)
        {
            builder.ToTable("Payout");
            builder.HasKey(p => p.Id);
            builder.HasOne<User>(s => s.Instructor)
               .WithMany(g => g.Payouts)
               .HasForeignKey(x => x.InstructorId)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
