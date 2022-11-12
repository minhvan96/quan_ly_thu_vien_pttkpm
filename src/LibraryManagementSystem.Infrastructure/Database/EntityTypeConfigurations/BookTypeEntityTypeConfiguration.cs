using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Infrastructure.Database.EntityTypeConfigurations;

internal class BookTypeEntityTypeConfiguration : DomainEntityTypeConfiguration<BookType>
{
    public override void Configure(EntityTypeBuilder<BookType> builder)
    {
        base.Configure(builder);
        builder.ToTable("BookTypes");
        builder.HasKey(x => x.Id);

        builder.Property(bookType => bookType.Name)
            .IsRequired()
            .HasMaxLength(128);
    }
}