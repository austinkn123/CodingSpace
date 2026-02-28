using System;
using Xunit;
using ReflectionLab.Exercises;

namespace CodingSpace.Lab.Tests.Fundamentals.Reflection;

public class TypeInspectionTests
{
    [Fact]
    public void GetPropertyValues_WithValidObject_ShouldReturnDictionary()
    {
        // Arrange
        var person = new Person();
        
        // Act
        var result = TypeInspection.GetPropertyValues(person);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(4, result.Count); // FirstName, LastName, Age, Secret (Secret is private)
        Assert.Equal("John", result["FirstName"]);
        Assert.Equal("Doe", result["LastName"]);
        Assert.Equal(30, result["Age"]);
        Assert.Equal("Hidden", result["Secret"]);
    }
    
    [Fact]
    public void GetPropertyValues_WithNull_ShouldReturnEmptyDictionary()
    {
        // Act
        var result = TypeInspection.GetPropertyValues(null);

        // Assert
        Assert.NotNull(result);
        Assert.Empty(result);
    }
}
