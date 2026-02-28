using System;
using System.Collections.Generic;
using System.Reflection;

namespace ReflectionLab.Exercises;

public class TypeInspection
{
    /// <summary>
    /// Given any object, return a dictionary of all its properties and values
    /// </summary>
    public static Dictionary<string, object?> GetPropertyValues(object obj)
    {
        var result = new Dictionary<string, object?>();

        if (obj == null)
        {
            return result;
        }

        var type = obj.GetType();
        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var prop in properties)
        {
            var value = prop.GetValue(obj);
            result.Add(prop.Name, value);
        }
        
        return result;
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
