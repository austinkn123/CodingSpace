using BudgetTracker.Contracts.Models;

namespace BudgetTracker.Contracts.Engines;

/// <summary>
/// Engine contract for budget calculation logic.
/// 
/// IDESIGN: Pure business rules — no data access, no side effects.
/// 
/// TDD PHASE 1: Pure functions. Test with real data, no mocks needed.
/// </summary>
public interface IBudgetEngine
{
    /// <summary>
    /// Determines if spending has exceeded the budget limit.
    /// </summary>
    bool IsOverBudget(Budget budget);

    /// <summary>
    /// Calculates the remaining budget (limit - spent). Can be negative.
    /// </summary>
    decimal GetRemainingBudget(Budget budget);

    /// <summary>
    /// Evaluates the overall health of a budget and returns a detailed report.
    /// </summary>
    BudgetHealthReport EvaluateBudgetHealth(Budget budget);
}
