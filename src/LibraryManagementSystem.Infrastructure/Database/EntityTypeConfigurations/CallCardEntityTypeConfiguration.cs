using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Infrastructure.Database.EntityTypeConfigurations
{
    internal class CallCardEntityTypeConfiguration : IEntityTypeConfiguration<CallCard>
    {
        public void Configure(EntityTypeBuilder<CallCard> builder)
        {
            builder.ToTable("CallCards");
            builder.HasKey(x => x.Id);
        }
    }
}