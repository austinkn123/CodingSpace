using System;
using System.Reflection;

namespace ReflectionLab.Exercises;

public class DynamicInstantiation
{
    /// <summary>
    /// Given a type name as a string, create an instance of that type
    /// </summary>
    public static object? CreateInstance(string typeName)
    {
        Console.WriteLine($"--- Creating instance of {typeName} ---");
        
        // TODO: Implement reflection logic here
        // 1. Get the type by name: Type.GetType(typeName)
        // 2. If type is null, handle it (throw or return null)
        // 3. Use Activator.CreateInstance to create the object
        // 4. Return the object
        
        // Your code here...
        return null;
    }
}

// Sample classes to test with
public class SimpleClass
{
    public SimpleClass()
    {
        Console.WriteLine("SimpleClass created!");
    }
}

public class ClassWithParameters
{
    public ClassWithParameters(string name)
    {
        Console.WriteLine($"ClassWithParameters created with name: {name}");
    }
}

public class PrivateConstructorClass
{
    private PrivateConstructorClass()
    {
        Console.WriteLine("PrivateConstructorClass created!");
    }
}
