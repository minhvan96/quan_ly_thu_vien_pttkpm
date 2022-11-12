namespace LibraryManagementSystem.Domain.Common;

public record RequestResult
{
    public RequestResult(bool success)
    {
        Success = success;
    }

    public bool Success { get; }
}