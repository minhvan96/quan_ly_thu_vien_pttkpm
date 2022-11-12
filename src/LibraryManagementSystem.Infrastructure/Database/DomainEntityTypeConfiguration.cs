using LibraryManagementSystem.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem.Infrastructure.Database;

/// <summary>
///     <inheritdoc cref="IEntityTypeConfiguration{TEntity}" />
///     <para>Provide default configuration for <see cref="Entity" /> class</para>
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public abstract class DomainEntityTypeConfiguration<TEntity> : IDomainEntityTypeConfiguration<TEntity>
    where TEntity : Entity
{
    /// <inheritdoc />
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.Property(entity => entity.CreatedDate)
            .IsRequired();

        builder.Property(entity => entity.UpdatedDate)
            .IsRequired();
    }
}