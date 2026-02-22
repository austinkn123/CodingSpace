using System;
using Xunit;
using CodingSpace.Lab.Fundamentals.Generics;

namespace CodingSpace.Lab.Tests.Fundamentals.Generics;

public class GenericPlaygroundTests
{
    [Fact]
    public void GenericBox_CanHoldAnyType()
    {
        // Arrange & Act
        var numberBox = new Box<int>(200);
        var stringBox = new Box<string>("Fragile");

        // Assert
        Assert.Equal(200, numberBox.Content);
        Assert.Equal("Fragile", stringBox.Content);
    }

    [Fact]
    public void DataStore_EnforcesClassConstraint()
    {
        // Arrange
        var user = new User("Tony");
        
        // Act
        var dataStore = new DataStore<User>(user);

        // Assert
        Assert.Equal("Tony", dataStore.Item.Name);
        
        // The following line would not compile because 'int' is a struct, not a class:
        // var invalidStore = new DataStore<int>(42);
    }
}
