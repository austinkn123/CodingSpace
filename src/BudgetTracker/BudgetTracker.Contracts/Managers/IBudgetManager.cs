using BudgetTracker.Contracts.Models;

namespace BudgetTracker.Contracts.Managers;

/// <summary>
/// Manager contract for budget workflow orchestration.
/// 
/// IDESIGN: Managers coordinate workflows by calling Engines and Accessors.
/// They never contain business logic — they sequence operations.
/// 
/// TDD PHASE 2: London-school TDD — mock Engines and Accessors via their contracts.
/// </summary>
public interface IBudgetManager
{
    /// <summary>
    /// Records a new transaction: validate → save → update budget spent amount.
    /// </summary>
    Task<Result<int>> RecordTransactionAsync(Transaction transaction);

    /// <summary>
    /// Retrieves a monthly summary: fetch transactions → calculate totals → evaluate budgets.
    /// </summary>
    Task<MonthlySummary> GetMonthlySummaryAsync(DateTime month);
}
