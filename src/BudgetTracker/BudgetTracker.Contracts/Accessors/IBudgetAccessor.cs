using BudgetTracker.Contracts.Models;

namespace BudgetTracker.Contracts.Accessors;

/// <summary>
/// Accessor contract for Budget data access.
/// 
/// IDESIGN: One accessor per resource type. No business logic.
/// 
/// TDD PHASE 3: Integration tests with real database.
/// </summary>
public interface IBudgetAccessor
{
    Task<Budget?> GetByCategoryAndMonthAsync(string category, DateTime month);
    Task<IEnumerable<Budget>> GetByMonthAsync(DateTime month);
    Task<int> SaveAsync(Budget budget);
    Task<bool> DeleteAsync(int id);
}
