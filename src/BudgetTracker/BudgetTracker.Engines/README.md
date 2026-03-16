# BudgetTracker.Engines

## IDesign Layer: Engines

**Responsibility**: Pure business logic. Stateless. No data access. No side effects.

## Your Challenge (TDD Phase 1 — Classic TDD)

Implement these classes using **Red-Green-Refactor**:

### 1. `TransactionEngine : ITransactionEngine`
Write tests FIRST for each method:

- **`ValidateTransaction()`** — Business rules to enforce:
  - Amount must not be zero
  - Description must not be empty or whitespace
  - Category must not be empty
  - Date must not be in the future
  - Return `ValidationResult.Success()` or `ValidationResult.Failure(errors)`

- **`CalculateBalance()`** — Sum all transactions:
  - Income adds to balance
  - Expenses subtract from balance
  - Empty list returns 0

- **`CategorizeSpending()`** — Group expenses by category:
  - Only include Expense transactions
  - Sum amounts per category
  - Return as dictionary

### 2. `BudgetEngine : IBudgetEngine`

- **`IsOverBudget()`** — `Spent > Limit`
- **`GetRemainingBudget()`** — `Limit - Spent` (can be negative)
- **`EvaluateBudgetHealth()`** — Return a `BudgetHealthReport`:
  - < 75% used → Healthy
  - 75-100% → Warning
  - > 100% → OverBudget

## TDD Workflow

```
1. Write a failing test (RED)
2. Write minimal code to pass (GREEN)
3. Refactor for clarity (REFACTOR)
4. Repeat for the next behavior
```

## Rules
- NO `using` for Accessors, Managers, or Utilities
- NO constructor dependencies (Engines are stateless)
- NO async methods (pure logic doesn't need async)
