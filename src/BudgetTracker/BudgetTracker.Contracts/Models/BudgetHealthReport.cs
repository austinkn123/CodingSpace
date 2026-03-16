namespace BudgetTracker.Contracts.Models;

/// <summary>
/// Indicates the health status of a budget category.
/// </summary>
public enum BudgetStatus
{
    /// <summary>Under 75% of budget limit.</summary>
    Healthy,

    /// <summary>Between 75% and 100% of budget limit.</summary>
    Warning,

    /// <summary>At or over 100% of budget limit.</summary>
    OverBudget
}

/// <summary>
/// Summary of budget health for a category.
/// </summary>
public record BudgetHealthReport(
    string Category,
    decimal Limit,
    decimal Spent,
    decimal Remaining,
    double PercentUsed,
    BudgetStatus Status
);
