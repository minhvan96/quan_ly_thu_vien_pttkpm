namespace LibraryManagementSystem.Domain.Common;

public record RequestResult
{
    public bool Success { get; }

    public RequestResult(bool success)
    {
        Success = success;
    }
}