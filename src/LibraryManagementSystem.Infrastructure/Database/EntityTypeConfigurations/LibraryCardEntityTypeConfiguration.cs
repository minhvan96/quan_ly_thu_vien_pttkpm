using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Infrastructure.Database.EntityTypeConfigurations;

internal class LibraryCardEntityTypeConfiguration : DomainEntityTypeConfiguration<LibraryCard>
{
    public override void Configure(EntityTypeBuilder<LibraryCard> builder)
    {
        base.Configure(builder);
        builder.ToTable("LibraryCards");
        builder.HasKey(x => x.Id);
    }
}