using System;
using System.Reflection;
using ReflectionLab.Exercises;
using Xunit;

namespace CodingSpace.Lab.Tests.Fundamentals.Reflection;

public class CustomAttributesTests
{
    [Fact]
    public void TaskMetadataAttribute_ShouldBeAppliedToClass()
    {
        // Arrange
        
        // Act
        
        // Assert
        // TODO: Write tests to verify your custom attribute logic
        // 1. Verify the attribute exists on a target class
        // 2. Verify its properties (Name, Priority) can be read at runtime
        var type = typeof(DatabaseCleanupTask);
        var attribute = type.GetCustomAttribute<TaskMetadataAttribute>();
        Assert.NotNull(attribute);
        Assert.Equal("Database Cleanup", attribute.Name);
        Assert.Equal(1, attribute.Priority);

        
        var sendEmailType = typeof(SendEmailsTask);
        var sendEmailAttribute = sendEmailType.GetCustomAttribute<TaskMetadataAttribute>();
        Assert.NotNull(sendEmailAttribute);
        Assert.Equal("Send Emails", sendEmailAttribute.Name);
        Assert.Equal(2, sendEmailAttribute.Priority);
    }
}
