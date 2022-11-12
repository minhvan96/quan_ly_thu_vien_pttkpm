﻿using LibraryManagementSystem.Domain.Entities;
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
    }
}