using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Infrastructure.Database.EntityTypeConfigurations;

public class BorrowBookDetailEntityConfiguration : DomainEntityTypeConfiguration<BorrowBookDetail>
{
    public override void Configure(EntityTypeBuilder<BorrowBookDetail> builder)
    {
        base.Configure(builder);
        builder.ToTable("BorrowBookDetails");
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Book)
          .WithMany()
          .HasForeignKey(reader => reader.BookId)
          .OnDelete(DeleteBehavior.Cascade);

        //builder.HasOne(x => x.BorrowBook)
        //  .WithMany()
        //  .HasForeignKey(br => br.BorrowBookId)
        //  .OnDelete(DeleteBehavior.Cascade);
    }
}
