namespace BudgetTracker.Contracts.Models;

/// <summary>
/// Aggregated monthly summary of income, expenses, and budget health.
/// </summary>
public record MonthlySummary(
    DateTime Month,
    decimal TotalIncome,
    decimal TotalExpenses,
    decimal NetBalance,
    IReadOnlyDictionary<string, decimal> SpendingByCategory,
    IReadOnlyList<BudgetHealthReport> BudgetHealth
);
