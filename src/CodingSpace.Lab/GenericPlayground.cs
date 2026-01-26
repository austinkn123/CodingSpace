using System;
using System.Collections.Generic;

namespace CodingSpace.Lab;

public static class GenericPlayground
{
    public static void Run()
    {
        Console.WriteLine("--- 1. The Problem: Duplication without Generics ---");
        PrintInt(42);
        PrintString("Hello");
        // What if we want to print a Date? We'd need another method PrintDate(DateTime d)...

        Console.WriteLine("\n--- 2. The Solution: Generics (T) ---");
        // 'T' stands for Type. It's a placeholder.
        Print<int>(42);
        Print<string>("Hello");
        Print<DateTime>(DateTime.Now);

        Console.WriteLine("\n--- 3. Generic Classes ---");
        // We can create a container that holds ANY type
        var numberBox = new Box<int>(200);
        var stringBox = new Box<string>("Fragile");

        Console.WriteLine($"Number Box: {numberBox.Content}");
        Console.WriteLine($"String Box: {stringBox.Content}");

        Console.WriteLine("\n--- 4. Architectural Safety: Constraints (where T : ...) ---");
        // We can limit what 'T' can be to prevent runtime errors.
        var dataStore = new DataStore<User>(new User("Tony"));
        // var invalidStore = new DataStore<int>(42); // This would cause a COMPILE error!
        Console.WriteLine($"Stored: {dataStore.Item.Name}");
    }

    // --- The "Bad" Way (Specific Types) ---
    public static void PrintInt(int value)
    {
        Console.WriteLine($"Value: {value} (Type: {value.GetType()})");
    }

    public static void PrintString(string value)
    {
        Console.WriteLine($"Value: {value} (Type: {value.GetType()})");
    }

    // --- The "Good" Way (Generics) ---
    // <T> defines a placeholder. We can use T as a parameter type.
    public static void Print<T>(T value)
    {
        Console.WriteLine($"Value: {value} (Type: {typeof(T)})");
    }
}

// A class that can hold anything
public class Box<T>
{
    public T Content { get; }

    public Box(T content)
    {
        Content = content;
    }
}

public class User
{
    public string Name { get; }
    public User(string name) => Name = name;
}

// Architectural Constraint: Only classes allowed!
// This stops us from putting types like 'int' or 'bool' into this store.
public class DataStore<T> where T : class
{
    public T Item { get; }
    public DataStore(T item) => Item = item;
}
