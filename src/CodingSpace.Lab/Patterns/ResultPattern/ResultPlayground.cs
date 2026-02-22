using System;

namespace CodingSpace.Lab.Patterns.ResultPattern;

public static class ResultPlayground
{
    public static void Run()
    {
        Console.WriteLine("--- Exercise 1: The Problem (Returning Object) ---");
        // Goal: See why returning 'object' is bad.
        // 1. Uncomment the GetUser method below.
        // 2. Try to call it: var user = GetUser(1);
        // 3. Try access properties like user.Name (you can't without casting!)
        
        RunExercise1();

        Console.WriteLine("\n--- Exercise 2: Basic Result<T> ---");
        // Goal: Create a wrapper that tells us if it worked.
        // 1. Create a class public class Result<T> { ... }
        // 2. Add IsSuccess (bool), Value (T), and Error (string).
        
        RunExercise2();

        Console.WriteLine("\n--- Exercise 3: Factory Methods ---");
        // Goal: Make it impossible to create an invalid state.
        // 1. Make the constructor private.
        // 2. Add static methods: Success(T value) and Failure(string error).

        RunExercise3();

        Console.WriteLine("\n--- Exercise 4: Non-Generic Result ---");
        // Goal: Handle void operations (e.g., "DeleteUser").

        RunExercise4();
        
        Console.WriteLine("\n--- Exercise 5: Break It Intentionally ---");
        // Goal: Try to create a Result that is Success BUT has an Error.
        // If your Factory methods are good, you shouldn't be able to!

        RunExercise5();
    }

    // --- Exercise 1 ---
    public static object GetUser(int id)
    {
        if (id < 0) return "Invalid ID";
        return new { Name = "Austin", Id = id };
    }

    static void RunExercise1()
    {
        var result = GetUser(1);// <--- Compiler stops looking here
        Console.WriteLine($"Result type: {result.GetType()}");
        Console.WriteLine($"Result value: {result}");
        
        // Problem: How do I know if it failed?
        // if (result is string error) ... ?
        if (result != "Invalid ID")
        {
            // will not work as anonymous "object" in c# will not contain the properties
            // compiler will only read anonymous "object" not the result object being returned
            // almost every type in c# derives from "object"

            // people don't really use "object" anymore, got overtaken by generics
            // Still used in special cases:
            //     Reflection, serialization, or APIs that must truly accept any type.
            //     Some .NET APIs (e.g., object.Equals, object.ToString) are still fundamental.
            //     When interoperating with legacy code or frameworks that predate generics.

            // var name = result.Name;
            // var id = result.Id;


            // Need to cast to access properties
            var user = (dynamic)result;
            Console.WriteLine($"User Name: {user.Name}, User ID: {user.Id}");
        }
        else
        {
            Console.WriteLine("Error occurred: " + result);
        }
        


    }

    // --- Exercise 2, 3 ---

    // This class is a generic class that can wrap any type T
    public class Result<T>
    {
        // Encapsulation: The private constructor prevents anyone from creating an invalid state.
        private Result() { }

        public bool IsSuccess { get; private set; }
        public T Value { get; private set; }
        public string Error { get; private set; }

        // exercise 3: Factory methods
        public static Result<T> Success(T value) =>
            new Result<T> { IsSuccess = true, Value = value };

        public static Result<T> Failure(string error) =>
            new Result<T> { IsSuccess = false, Error = error };
    }
    
    // A simple User class for demonstration
    // This user class will map to Value in Result<T> if we use User as T
    public class User(string name)
    {
        public string Name { get; } = name;
        public string Id { get; } = Guid.NewGuid().ToString();
    }

    // A method that returns Result<User>
    static Result<User> TryGetUser(int id)
    {
        if (id < 0){
            return Result<User>.Failure("Invalid ID");
        }
        else {
            return Result<User>.Success(new User("Austin"));
        }
    }



    // A simple generic method that returns whatever is passed in
    static T Echo<T>(T input) => input;


    static void RunExercise2()
    {
        var result = TryGetUser(1);

        int x = Echo(42);           // T is int, returns 42
        string s = Echo("hello");   // T is string, returns "hello"
        var user = Echo(new User("Austin")); // T is User, returns the User object
        if (result.IsSuccess)
        {
            Console.WriteLine($"User Name: {result.Value.Name}");
            Console.WriteLine($"User ID: {result.Value.Id}");
        }
        else
        {
            Console.WriteLine("Error occurred: " + result.Error);
        }
    }

    static void RunExercise3()
    {
        // Implement here...
        // if the private constructor and factory methods are done correctly,
        // the following lines should cause compile-time errors:
        // var invalidResult1 = new Result<User> { IsSuccess = true, Error = "Some error" };
        // var invalidResult2 = new Result<User> { IsSuccess = false, Value = new User("Bob") };

    }

    // --- Exercise 4: Non-Generic Result for void operations ---
    public class OperationResult
    {
        private OperationResult() { }
        public bool IsSuccess { get; private set; }
        public string Error { get; private set; }

        public static OperationResult Success() => new OperationResult { IsSuccess = true };
        public static OperationResult Failure(string error) => new OperationResult { IsSuccess = false, Error = error };
    }

    static OperationResult DeleteUser(int id)
    {
        if (id < 0)
            return OperationResult.Failure("Invalid ID");
        // Simulate delete logic...
        return OperationResult.Success();
    }

    static void RunExercise4()
    {
        var result = DeleteUser(1);
        if (result.IsSuccess)
            Console.WriteLine("User deleted successfully!");
        else
            Console.WriteLine("Delete failed: " + result.Error);
    }

    static void RunExercise5()
    {
        // Try to create invalid Result instances and see if the compiler stops you.
        // The following line will NOT compile, proving the pattern is safe:
        // var invalidResult = Result<User>.Success(new User("Bob"), "Some error");
        // Only the allowed factory methods can be used:
        var validSuccess = Result<User>.Success(new User("Bob"));
        var validFailure = Result<User>.Failure("Some error");
        Console.WriteLine($"Valid Success: {validSuccess.IsSuccess}, Name: {validSuccess.Value.Name}");
        Console.WriteLine($"Valid Failure: {validFailure.IsSuccess}, Error: {validFailure.Error}");
    }
}