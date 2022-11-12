namespace LibraryManagementSystem.Domain.Common;

public abstract class Entity : IAuditableEntity
{
    protected Entity()
    {
        Id = Guid.NewGuid();
        CreatedDate = DateTimeOffset.UtcNow;
        UpdatedDate = DateTimeOffset.UtcNow;
    }

    protected Entity(Guid id)
    {
        Id = id;
        CreatedDate = DateTimeOffset.UtcNow;
        UpdatedDate = DateTimeOffset.UtcNow;
    }

    public Guid Id { get; }

    /// <inheritdoc />
    public DateTimeOffset CreatedDate { get; }

    /// <inheritdoc />
    public DateTimeOffset UpdatedDate { get; }
}