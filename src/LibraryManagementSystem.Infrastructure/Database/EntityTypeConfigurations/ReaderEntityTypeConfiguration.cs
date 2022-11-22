using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Infrastructure.Database.EntityTypeConfigurations;

internal class ReaderEntityTypeConfiguration : DomainEntityTypeConfiguration<Reader>
{
    public override void Configure(EntityTypeBuilder<Reader> builder)
    {
        base.Configure(builder);
        builder.ToTable("Readers");
        builder.HasKey(x => x.Id);

        builder.Property(reader => reader.Name)
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(reader => reader.Address)
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(reader => reader.Email)
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(reader => reader.CreatedDate)
            .IsRequired();

        builder.Property(reader => reader.Dob)
            .IsRequired();

        builder.Property(reader => reader.ReaderType)
            .IsRequired()
            .HasMaxLength(50);
    }
}