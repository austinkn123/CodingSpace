using BudgetTracker.Contracts.Models;

namespace BudgetTracker.Engines.Tests;

/// <summary>
/// TDD Phase 1: Classic TDD — TransactionEngine
/// 
/// YOUR CHALLENGE: These tests are RED (they won't compile yet).
/// Create TransactionEngine in BudgetTracker.Engines to make them GREEN.
/// Then refactor for clarity.
/// 
/// Workflow:
///   1. Run tests → see them FAIL (RED)
///   2. Create TransactionEngine with minimal code to pass ONE test
///   3. Run tests → see that test PASS (GREEN)
///   4. Refactor if needed
///   5. Move to the next test
/// </summary>
public class TransactionEngineTests
{
    // ═══════════════════════════════════════════════════════════
    // ValidateTransaction Tests
    // ═══════════════════════════════════════════════════════════

    [Fact]
    public void ValidateTransaction_ValidTransaction_ReturnsSuccess()
    {
        // TODO: Create a TransactionEngine instance
        // TODO: Create a valid Transaction
        // TODO: Call ValidateTransaction
        // TODO: Assert IsValid is true
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void ValidateTransaction_ZeroAmount_ReturnsFailure()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void ValidateTransaction_EmptyDescription_ReturnsFailure()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void ValidateTransaction_EmptyCategory_ReturnsFailure()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void ValidateTransaction_FutureDate_ReturnsFailure()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void ValidateTransaction_MultipleErrors_ReturnsAllErrors()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    // ═══════════════════════════════════════════════════════════
    // CalculateBalance Tests
    // ═══════════════════════════════════════════════════════════

    [Fact]
    public void CalculateBalance_EmptyList_ReturnsZero()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void CalculateBalance_OnlyIncome_ReturnsTotalIncome()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void CalculateBalance_IncomeAndExpenses_ReturnsNetBalance()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    // ═══════════════════════════════════════════════════════════
    // CategorizeSpending Tests
    // ═══════════════════════════════════════════════════════════

    [Fact]
    public void CategorizeSpending_GroupsExpensesByCategory()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void CategorizeSpending_IgnoresIncomeTransactions()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void CategorizeSpending_EmptyList_ReturnsEmptyDictionary()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }
}
