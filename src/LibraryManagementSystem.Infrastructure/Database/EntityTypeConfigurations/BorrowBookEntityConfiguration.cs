using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Infrastructure.Database.EntityTypeConfigurations;

internal class BorrowBookEntityConfiguration : DomainEntityTypeConfiguration<BorrowBook>
{
    public override void Configure(EntityTypeBuilder<BorrowBook> builder)
    {
        base.Configure(builder);
        builder.ToTable("BorrowBooks");
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Reader)
          .WithMany()
          .HasForeignKey(reader => reader.ReaderId)
          .OnDelete(DeleteBehavior.Cascade);
    }
}
