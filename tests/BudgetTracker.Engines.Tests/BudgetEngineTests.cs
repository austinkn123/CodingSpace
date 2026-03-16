using BudgetTracker.Contracts.Models;

namespace BudgetTracker.Engines.Tests;

/// <summary>
/// TDD Phase 1: Classic TDD — BudgetEngine
/// 
/// Same approach: write tests first, then implement BudgetEngine.
/// These are pure calculations — no mocks, no async, no database.
/// </summary>
public class BudgetEngineTests
{
    // ═══════════════════════════════════════════════════════════
    // IsOverBudget Tests
    // ═══════════════════════════════════════════════════════════

    [Fact]
    public void IsOverBudget_SpentExceedsLimit_ReturnsTrue()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void IsOverBudget_SpentUnderLimit_ReturnsFalse()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void IsOverBudget_SpentEqualsLimit_ReturnsFalse()
    {
        // Design decision: exactly at limit is NOT over budget.
        // This is a boundary test — crucial for TDD.
        Assert.Fail("Implement this test — then make it pass!");
    }

    // ═══════════════════════════════════════════════════════════
    // GetRemainingBudget Tests
    // ═══════════════════════════════════════════════════════════

    [Fact]
    public void GetRemainingBudget_UnderBudget_ReturnsPositiveAmount()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void GetRemainingBudget_OverBudget_ReturnsNegativeAmount()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    // ═══════════════════════════════════════════════════════════
    // EvaluateBudgetHealth Tests
    // ═══════════════════════════════════════════════════════════

    [Fact]
    public void EvaluateBudgetHealth_Under75Percent_ReturnsHealthy()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void EvaluateBudgetHealth_Between75And100Percent_ReturnsWarning()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void EvaluateBudgetHealth_Over100Percent_ReturnsOverBudget()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }

    [Fact]
    public void EvaluateBudgetHealth_ReturnsCorrectRemainingAndPercentage()
    {
        Assert.Fail("Implement this test — then make it pass!");
    }
}
