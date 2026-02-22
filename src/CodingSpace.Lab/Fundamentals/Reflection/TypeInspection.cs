using System;
using System.Reflection;

namespace ReflectionLab.Exercises;

public class TypeInspection
{
    /// <summary>
    /// Given any object, print all its properties and values
    /// </summary>
    public static void DumpObject(object obj)
    {
        if (obj == null)
        {
            Console.WriteLine("Object is null");
            return;
        }

        // TODO: Implement reflection logic here
        // 1. Get the type of the object
        // 2. Get all properties of that type
        // 3. Loop through properties and print their Name and Value
        
        Console.WriteLine($"--- Dumping {obj.GetType().Name} ---");
        
        // Your code here...
    }
}

// Sample class to test with
public class Person
{
    public string FirstName { get; set; } = "John";
    public string LastName { get; set; } = "Doe";
    public int Age { get; set; } = 30;
    private string Secret { get; set; } = "Hidden";
}
