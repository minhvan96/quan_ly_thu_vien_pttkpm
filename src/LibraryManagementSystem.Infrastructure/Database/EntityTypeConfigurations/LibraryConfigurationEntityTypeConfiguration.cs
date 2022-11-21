using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Infrastructure.Database.EntityTypeConfigurations;

internal class LibraryConfigurationEntityTypeConfiguration : DomainEntityTypeConfiguration<LibraryConfiguration>
{
    public override void Configure(EntityTypeBuilder<LibraryConfiguration> builder)
    {
        base.Configure(builder);
        builder.ToTable("LibraryConfigurations");
        builder.HasKey(x => x.Id);
        builder.HasIndex(configuration => configuration.Code)
            .IsUnique();
        builder.Property(configuration => configuration.Name)
            .IsRequired()
            .HasMaxLength(254);
        builder.Property(configuration => configuration.Code)
            .IsRequired()
            .HasMaxLength(30);
        builder.Property(configuration => configuration.Value)
            .IsRequired();
    }
}