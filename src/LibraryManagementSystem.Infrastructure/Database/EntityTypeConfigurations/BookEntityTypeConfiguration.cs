using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Infrastructure.Database.EntityTypeConfigurations;

internal class BookEntityTypeConfiguration : DomainEntityTypeConfiguration<Book>
{
    public override void Configure(EntityTypeBuilder<Book> builder)
    {
        base.Configure(builder);
        builder.ToTable("Books");
        builder.HasKey(book => book.Id);

        builder.HasOne(x => x.BookType)
            .WithMany()
            .HasForeignKey(book => book.BookTypeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(book => book.Author)
            .WithMany()
            .HasForeignKey(book => book.AuthorId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(book => book.Name)
            .IsRequired()
            .HasMaxLength(512);
        builder.Property(book => book.Code)
            .IsRequired()
            .HasMaxLength(128);

        builder.HasOne(book => book.Publisher)
            .WithMany()
            .HasForeignKey(book => book.PublisherId)
            .IsRequired();

        builder.Property(book => book.Published)
            .IsRequired();
    }
}