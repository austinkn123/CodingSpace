using System;

namespace CodingSpace.Shared.Primitives;

/// <summary>
/// Represents the outcome of an operation that doesn't return a value.
/// </summary>
public class Result
{
    public bool IsSuccess { get; }
    public string Error { get; }
    public bool IsFailure => !IsSuccess;

    // Protected constructor to force the use of static factory methods.
    // This encapsulates the logic of how a Result is created.
    protected Result(bool isSuccess, string error)
    {
        if (isSuccess && !string.IsNullOrEmpty(error))
        {
            throw new InvalidOperationException("A successful result cannot have an error message.");
        }

        if (!isSuccess && string.IsNullOrEmpty(error))
        {
            throw new InvalidOperationException("A failure result must have an error message.");
        }

        IsSuccess = isSuccess;
        Error = error;
    }

    /// <summary>
    /// Returns a success result.
    /// </summary>
    public static Result Success() => new(true, string.Empty);

    /// <summary>
    /// Returns a failure result with the specified error message.
    /// </summary>
    public static Result Failure(string error) => new(false, error);
}
