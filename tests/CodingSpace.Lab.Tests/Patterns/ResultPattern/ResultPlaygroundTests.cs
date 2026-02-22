using System;
using Xunit;
using CodingSpace.Lab.Patterns.ResultPattern;

namespace CodingSpace.Lab.Tests.Patterns.ResultPattern;

public class ResultPlaygroundTests
{
    [Fact]
    public void Result_Success_ContainsValueAndNoErrors()
    {
        // Arrange
        var user = new User("Bob");

        // Act
        var result = ResultPlayground.Result<User>.Success(user);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal("Bob", result.Value.Name);
        Assert.Null(result.Error);
    }

    [Fact]
    public void Result_Failure_ContainsErrorAndNoValue()
    {
        // Arrange
        var errorMessage = "User not found";

        // Act
        var result = ResultPlayground.Result<User>.Failure(errorMessage);

        // Assert
        Assert.False(result.IsSuccess);
        Assert.Equal(errorMessage, result.Error);
        Assert.Null(result.Value);
    }
}

// Simple User class for testing
public class User
{
    public string Name { get; }
    public User(string name) => Name = name;
}
