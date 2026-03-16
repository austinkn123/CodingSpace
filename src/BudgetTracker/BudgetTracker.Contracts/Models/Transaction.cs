namespace BudgetTracker.Contracts.Models;

/// <summary>
/// Represents a financial transaction (income or expense).
/// </summary>
public record Transaction(
    int Id,
    decimal Amount,
    string Description,
    string Category,
    DateTime Date,
    TransactionType Type
);

/// <summary>
/// Classifies a transaction as income or expense.
/// </summary>
public enum TransactionType
{
    Income,
    Expense
}
