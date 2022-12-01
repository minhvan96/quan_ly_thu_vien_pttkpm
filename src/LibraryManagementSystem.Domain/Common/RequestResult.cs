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
        Message = message;
    }

    public bool Success { get; set; }
    public string Message{ get; set; }
}