# BudgetTracker.Managers

## IDesign Layer: Managers

**Responsibility**: Workflow orchestration. Coordinate calls to Engines and Accessors. Never contain business logic.

## Your Challenge (TDD Phase 2 — London-School TDD)

Implement this class using **Outside-In TDD with mocks**:

### `BudgetManager : IBudgetManager`

#### `RecordTransactionAsync(Transaction transaction)`
Orchestration sequence:
1. Call `ITransactionEngine.ValidateTransaction()` → if invalid, return `Result.Failure(errors)`
2. Call `ITransactionAccessor.AddAsync()` → get the new transaction ID
3. Return `Result.Success(transactionId)`

#### `GetMonthlySummaryAsync(DateTime month)`
Orchestration sequence:
1. Call `ITransactionAccessor.GetByDateRangeAsync()` for the month
2. Call `ITransactionEngine.CalculateBalance()` with the transactions
3. Call `ITransactionEngine.CategorizeSpending()` with the transactions
4. Call `IBudgetAccessor.GetByMonthAsync()` for budget limits
5. Call `IBudgetEngine.EvaluateBudgetHealth()` for each budget
6. Assemble and return a `MonthlySummary`

## London-School TDD Approach

```csharp
// You'll inject mocked contracts:
var mockTransactionEngine = new Mock<ITransactionEngine>();
var mockTransactionAccessor = new Mock<ITransactionAccessor>();
var manager = new BudgetManager(mockTransactionEngine.Object, mockTransactionAccessor.Object, ...);

// Then verify the orchestration sequence
mockTransactionEngine.Verify(e => e.ValidateTransaction(transaction), Times.Once);
```

## Rules
- NO business logic (calculations, validations) — that belongs in Engines
- NO direct data access — that belongs in Accessors
- Dependencies injected via constructor as interfaces
