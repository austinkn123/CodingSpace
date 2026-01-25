using CodingSpace.Shared.Primitives;
using Xunit;

namespace CodingSpace.Shared.Tests.Primitives;

public class ResultTests
{
    [Fact]
    public void Success_ShouldSetIsSuccessToTrue()
    {
        // Act
        var result = Result.Success();

        // Assert
        Assert.True(result.IsSuccess);
        Assert.False(result.IsFailure);
        Assert.Equal(string.Empty, result.Error);
    }

    [Fact]
    public void Failure_ShouldSetIsSuccessToFalseAndSetError()
    {
        // Arrange
        const string errorMessage = "Something went wrong";

        // Act
        var result = Result.Failure(errorMessage);

        // Assert
        Assert.False(result.IsSuccess);
        Assert.True(result.IsFailure);
        Assert.Equal(errorMessage, result.Error);
    }

    [Fact]
    public void SuccessGeneric_ShouldContainValue()
    {
        // Arrange
        var value = 42;

        // Act
        var result = Result.Success(value);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal(value, result.Value);
    }

    [Fact]
    public void FailureGeneric_ShouldThrowException_WhenAccessingValue()
    {
        // Arrange
        var result = Result.Failure<int>("Error");

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => result.Value);
    }

    [Fact]
    public void ImplicitOperator_ShouldCreateSuccessResult()
    {
        // Act
        Result<string> result = "Hello World";

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal("Hello World", result.Value);
    }
}
