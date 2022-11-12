using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Infrastructure.Database.EntityTypeConfigurations
{
    internal class LibraryConfigurationEntityTypeConfiguration : IEntityTypeConfiguration<LibraryConfiguration>
    {
        public void Configure(EntityTypeBuilder<LibraryConfiguration> builder)
        {
            builder.ToTable("LibraryConfigurations");
            builder.HasKey(x => x.Id);
        }
    }
}