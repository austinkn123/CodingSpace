using System;
using Xunit;

namespace CodingSpace.Lab.Tests.Fundamentals.Reflection;

public class DynamicInstantiationTests
{
    [Fact]
    public void CreateInstance_WithValidTypeName_ShouldReturnInstance()
    {
        // Arrange
        
        // Act
        
        // Assert
        // TODO: Write tests for dynamic instantiation
        // 1. Given a type name as a string, create an instance of that type
        // 2. What happens if the type doesn't exist? Has no parameterless constructor?

        var simpleInstance = ReflectionLab.Exercises.DynamicInstantiation.CreateInstance("ReflectionLab.Exercises.SimpleClass");
        Assert.NotNull(simpleInstance);
        var paramInstance = ReflectionLab.Exercises.DynamicInstantiation.CreateInstance("ReflectionLab.Exercises.ClassWithParameters", "TestName");
        Assert.NotNull(paramInstance);
        var privateInstance = ReflectionLab.Exercises.DynamicInstantiation.CreateInstance("ReflectionLab.Exercises.PrivateConstructorClass");
        Assert.NotNull(privateInstance);
        var nonExistentInstance = ReflectionLab.Exercises.DynamicInstantiation.CreateInstance("ReflectionLab.Exercises.NonExistentClass");
        Assert.Null(nonExistentInstance);
        
    }
}
