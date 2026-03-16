using BudgetTracker.Contracts.Models;

namespace BudgetTracker.Contracts.Accessors;

/// <summary>
/// Accessor contract for Transaction data access.
/// 
/// IDESIGN: One accessor per resource type. No business logic.
/// Just CRUD operations that abstract the storage mechanism.
/// 
/// TDD PHASE 3: Integration tests with real database.
/// </summary>
public interface ITransactionAccessor
{
    Task<Transaction?> GetByIdAsync(int id);
    Task<IEnumerable<Transaction>> GetByDateRangeAsync(DateTime start, DateTime end);
    Task<IEnumerable<Transaction>> GetByCategoryAsync(string category);
    Task<int> AddAsync(Transaction transaction);
    Task<bool> UpdateAsync(Transaction transaction);
    Task<bool> DeleteAsync(int id);
}
