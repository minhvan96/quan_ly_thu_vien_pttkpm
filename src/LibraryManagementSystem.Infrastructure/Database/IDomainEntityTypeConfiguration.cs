using LibraryManagementSystem.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Infrastructure.Database;

public interface IDomainEntityTypeConfiguration<TEntity> :
    IEntityTypeConfiguration<TEntity>
    where TEntity : Entity
{
}