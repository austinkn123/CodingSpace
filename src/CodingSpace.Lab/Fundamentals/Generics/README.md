# Generics in C#

## Learning Objective
Understand how generics enable type-safe, reusable code without duplication.

## Concept Overview

**What is it?**
Generics allow you to define classes, methods, and interfaces with a placeholder for the type they operate on. Instead of writing separate methods for `int`, `string`, `DateTime`, you write one method that works with any type.

**Why does it exist?**
- **Type Safety**: Catch type errors at compile time, not runtime
- **Code Reuse**: Write once, use with any type
- **Performance**: Avoid boxing/unboxing overhead with value types
- **Expressiveness**: Method signatures clearly communicate intent

**Key Principles:**
- `T` is just a convention—you can use any identifier (`TItem`, `TEntity`, etc.)
- Constraints (`where T : class`) limit what types can be used, enabling more operations
- Generic variance (`in`, `out`) controls inheritance relationships

## Real-World Usage

**In production codebases, you'll use generics for:**
- Repository patterns: `IRepository<TEntity>`
- Result types: `Result<T>` for operation outcomes
- Collections: `List<T>`, `Dictionary<TKey, TValue>`
- API responses: `ApiResponse<TData>`

**When NOT to use generics:**
- When you only ever need one type (over-engineering)
- When it makes the code harder to understand than the duplication it saves

## Exercises

1. Run the `GenericPlayground.cs` and observe the output
2. Add a new generic method `Swap<T>(ref T a, ref T b)` that swaps two values
3. Create a generic `Pair<T1, T2>` class that holds two values of different types
4. Add a constraint to a method that only accepts types implementing `IComparable<T>`

## Files
- [GenericPlayground.cs](GenericPlayground.cs) - Interactive playground demonstrating concepts
