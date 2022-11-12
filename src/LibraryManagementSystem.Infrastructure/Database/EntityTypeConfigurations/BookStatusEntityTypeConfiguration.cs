using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Infrastructure.Database.EntityTypeConfigurations;

internal class BookStatusEntityTypeConfiguration : DomainEntityTypeConfiguration<BookStatus>
{
    public override void Configure(EntityTypeBuilder<BookStatus> builder)
    {
        base.Configure(builder);
        builder.ToTable("BookStatus");
        builder.HasKey(x => x.Id);
    }
}