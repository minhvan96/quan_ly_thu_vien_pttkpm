using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Infrastructure.Database.EntityTypeConfigurations;

internal class BookStatusEntityTypeConfiguration : IEntityTypeConfiguration<BookStatus>
{
    public void Configure(EntityTypeBuilder<BookStatus> builder)
    {
        builder.ToTable("BookStatus");
        builder.HasKey(x => x.Id);
    }
}