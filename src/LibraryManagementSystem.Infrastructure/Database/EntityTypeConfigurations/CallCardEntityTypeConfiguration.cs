using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Infrastructure.Database.EntityTypeConfigurations;

internal class CallCardEntityTypeConfiguration : DomainEntityTypeConfiguration<CallCard>
{
    public override void Configure(EntityTypeBuilder<CallCard> builder)
    {
        base.Configure(builder);
        builder.ToTable("CallCards");
        builder.HasKey(x => x.Id);

        //builder.HasOne(x => x.LibraryCard)
        // .WithMany()
        // .HasForeignKey(l => l.LibraryCardId)
        // .OnDelete(DeleteBehavior.Cascade);
    }
}