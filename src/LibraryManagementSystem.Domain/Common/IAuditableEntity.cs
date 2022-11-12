namespace LibraryManagementSystem.Domain.Common;

/// <summary>
///     Represent an auditable entity
/// </summary>
public interface IAuditableEntity
{
    /// <summary>
    ///     Entity created date
    /// </summary>
    DateTimeOffset CreatedDate { get; }

    /// <summary>
    ///     Entity updated date
    /// </summary>
    DateTimeOffset UpdatedDate { get; }
}