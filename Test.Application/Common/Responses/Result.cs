namespace StudentManagement.Application.Common.Responses;

public class Result<T>
{
    public bool IsSuccess { get; private set; }

    public T? Response { get; private set; }

    public List<string> Messages { get; private set; } = new();

    public static Result<T> Success(T response, string message = "Operation successful")
    {
        return new Result<T>
        {
            IsSuccess = true,
            Response = response,
            Messages = new List<string> { message }
        };
    }

    public static Result<T> Failure(string message)
    {
        return new Result<T>
        {
            IsSuccess = false,
            Messages = new List<string> { message }
        };
    }
}