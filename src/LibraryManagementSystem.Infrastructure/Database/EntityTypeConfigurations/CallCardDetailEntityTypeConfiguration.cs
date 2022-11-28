using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Infrastructure.Database.EntityTypeConfigurations;

internal class CallCardDetailEntityTypeConfiguration : DomainEntityTypeConfiguration<CallCardDetail>
{
    public override void Configure(EntityTypeBuilder<CallCardDetail> builder)
    {
        base.Configure(builder);
        builder.ToTable("CallCardDetails");
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Book)
         .WithMany()
         .HasForeignKey(l => l.BookId)
         .OnDelete(DeleteBehavior.Cascade);
    }
}