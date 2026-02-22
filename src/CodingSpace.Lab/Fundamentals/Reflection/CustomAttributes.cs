using System;
using System.Reflection;

namespace ReflectionLab.Exercises;

// TODO: Create [TaskMetadata(Name, Priority)] attribute here
// 1. Inherit from Attribute
// 2. Add properties for Name and Priority
// 3. Add a constructor to set them
// 4. (Optional) Restrict where this attribute can be applied using [AttributeUsage]

public class CustomAttributes
{
    public static void FindTasksInAssembly()
    {
        Console.WriteLine("--- Finding Tasks ---");
        
        // TODO: Implement reflection logic here
        // 1. Get the current assembly: Assembly.GetExecutingAssembly()
        // 2. Get all types in the assembly
        // 3. Filter types that have the TaskMetadata attribute
        // 4. Print the class name and the attribute values
        
        // Your code here...
    }
}

// Sample classes to test with
// TODO: Apply your attribute to these classes

public class DatabaseCleanupTask
{
    public void Execute() => Console.WriteLine("Cleaning database...");
}

public class SendEmailsTask
{
    public void Execute() => Console.WriteLine("Sending emails...");
}

public class IgnoreMeClass
{
    // This shouldn't be found
}
