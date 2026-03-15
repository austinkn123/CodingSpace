using System;
using System.IO;
using Xunit;
using ReflectionLab.Exercises;

namespace CodingSpace.Lab.Tests.Fundamentals.Reflection;

public class PluginSystemTests
{
    [Fact]
    public void PluginLoader_ShouldDiscoverAllPlugins()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        PluginSystem.RunAllPlugins();

        // Assert
        var result = output.ToString();
        Assert.Contains("--- Running Plugins ---", result);
        Assert.Contains("LoggerPlugin executing...", result);
        Assert.Contains("MetricsPlugin executing...", result);
        Assert.Contains("SecurityPlugin executing...", result);
    }
}
