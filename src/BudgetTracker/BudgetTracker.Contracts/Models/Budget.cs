namespace BudgetTracker.Contracts.Models;

/// <summary>
/// Represents a budget limit for a category in a specific month.
/// </summary>
public record Budget(
    int Id,
    string Category,
    decimal Limit,
    decimal Spent,
    DateTime Month
);
