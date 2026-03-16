using BudgetTracker.Contracts.Models;

namespace BudgetTracker.Contracts.Engines;

/// <summary>
/// Engine contract for transaction business logic.
/// 
/// IDESIGN: Engines are stateless and contain pure business logic.
/// No data access. No workflow awareness. No side effects.
/// 
/// TDD PHASE 1: Start here — these are pure functions, perfect for Classic TDD.
/// </summary>
public interface ITransactionEngine
{
    /// <summary>
    /// Validates a transaction for required fields and business rules.
    /// </summary>
    ValidationResult ValidateTransaction(Transaction transaction);

    /// <summary>
    /// Calculates the net balance from a collection of transactions.
    /// Income is positive, expenses are subtracted.
    /// </summary>
    decimal CalculateBalance(IEnumerable<Transaction> transactions);

    /// <summary>
    /// Groups transactions by category and sums the amounts.
    /// </summary>
    IReadOnlyDictionary<string, decimal> CategorizeSpending(IEnumerable<Transaction> transactions);
}
