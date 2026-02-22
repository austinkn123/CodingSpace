using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ReflectionLab.Exercises;

// TODO: Define an IPlugin interface with an Execute() method
public interface IPlugin
{
    void Execute();
}

public class PluginSystem
{
    /// <summary>
    /// Discovers and runs all IPlugin implementations in the current assembly
    /// </summary>
    public static void RunAllPlugins()
    {
        Console.WriteLine("--- Running Plugins ---");
        
        // TODO: Implement reflection logic here
        // 1. Get the current assembly
        // 2. Find all types that implement IPlugin (and are not interfaces/abstract classes)
        // 3. Instantiate each plugin
        // 4. Call Execute() on each plugin
        
        // Your code here...
    }
}

// Sample plugins to test with
public class LoggerPlugin : IPlugin
{
    public void Execute() => Console.WriteLine("LoggerPlugin executing...");
}

public class MetricsPlugin : IPlugin
{
    public void Execute() => Console.WriteLine("MetricsPlugin executing...");
}

public class SecurityPlugin : IPlugin
{
    public void Execute() => Console.WriteLine("SecurityPlugin executing...");
}
