namespace BudgetTracker.Contracts;

/// <summary>
/// A generic result type for operations that can succeed or fail.
/// 
/// This is the same Result pattern from your Lab exercises,
/// now applied in a real architectural context.
/// </summary>
public class Result<T>
{
    public bool IsSuccess { get; }
    public T? Value { get; }
    public string? Error { get; }
    public IReadOnlyList<string> Errors { get; }

    private Result(bool isSuccess, T? value, string? error, IReadOnlyList<string>? errors = null)
    {
        IsSuccess = isSuccess;
        Value = value;
        Error = error;
        Errors = errors ?? [];
    }

    public static Result<T> Success(T value) => new(true, value, null);
    public static Result<T> Failure(string error) => new(false, default, error);
    public static Result<T> Failure(IReadOnlyList<string> errors) =>
        new(false, default, errors.FirstOrDefault(), errors);
}
