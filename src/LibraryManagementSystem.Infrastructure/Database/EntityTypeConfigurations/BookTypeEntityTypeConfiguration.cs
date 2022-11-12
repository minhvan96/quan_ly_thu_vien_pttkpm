using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Infrastructure.Database.EntityTypeConfigurations;

internal class BookTypeEntityTypeConfiguration : IEntityTypeConfiguration<BookType>
{
    public void Configure(EntityTypeBuilder<BookType> builder)
    {
        builder.ToTable("BookTypes");
        builder.HasKey(x => x.Id);
    }
}