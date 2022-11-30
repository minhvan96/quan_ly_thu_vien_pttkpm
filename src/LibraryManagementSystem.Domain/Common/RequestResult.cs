namespace LibraryManagementSystem.Domain.Common;

public record RequestResult
{
    public RequestResult(bool success)
    {
        Success = success;
    }

    public RequestResult(bool success, string message)
    {
        Success = success;
        message = message;
    }

    public bool Success { get; }
    public string message{ get; }
}