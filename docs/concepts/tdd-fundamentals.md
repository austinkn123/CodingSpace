# Test-Driven Development — Learning Path

## What Is TDD?

TDD is a development practice where you write a **failing test first**, then write the **minimum code** to make it pass, then **refactor**. It's not just about testing — it's about using tests as **design feedback**.

## The Cycle: Red → Green → Refactor

```
1. RED    — Write a test that fails (defines what you want)
2. GREEN  — Write the simplest code to make it pass
3. REFACTOR — Clean up without changing behavior
4. REPEAT
```

### Why This Order?

- **Red first** proves your test actually tests something (a test that never fails is useless)
- **Green with minimal code** prevents over-engineering
- **Refactor** is where design emerges — you've earned the right to clean up

## Two Schools of TDD

### Classic TDD (Inside-Out) — Kent Beck
- Build from the inside out: start with domain objects and pure logic
- Use **real objects** as much as possible
- Mock only at system boundaries (database, HTTP, file system)
- **State verification**: assert on the returned value or object state
- **Best for**: Engines, value objects, pure calculations

```csharp
// Classic TDD — testing state
[Fact]
public void CalculateBalance_WithIncomeAndExpenses_ReturnsNetBalance()
{
    var engine = new TransactionEngine();
    var transactions = new[]
    {
        new Transaction(1, 1000m, "Salary", "Income", DateTime.Today, TransactionType.Income),
        new Transaction(2, -200m, "Groceries", "Food", DateTime.Today, TransactionType.Expense)
    };

    var balance = engine.CalculateBalance(transactions);

    Assert.Equal(800m, balance);
}
```

### London-School TDD (Outside-In) — Freeman & Pryce
- Build from the outside in: start with the API/Manager and mock dependencies
- Use **test doubles** (mocks) for all collaborators
- **Interaction verification**: assert that the right methods were called
- **Best for**: Managers, Controllers, orchestration logic

```csharp
// London-school TDD — testing interactions
[Fact]
public async Task RecordTransaction_ValidTransaction_SavesAndChecksbudget()
{
    var mockEngine = new Mock<ITransactionEngine>();
    var mockAccessor = new Mock<ITransactionAccessor>();
    mockEngine.Setup(e => e.ValidateTransaction(It.IsAny<Transaction>()))
              .Returns(ValidationResult.Success);
    mockAccessor.Setup(a => a.AddAsync(It.IsAny<Transaction>()))
                .ReturnsAsync(1);
    
    var manager = new BudgetManager(mockEngine.Object, mockAccessor.Object);
    
    var result = await manager.RecordTransactionAsync(someTransaction);
    
    mockEngine.Verify(e => e.ValidateTransaction(someTransaction), Times.Once);
    mockAccessor.Verify(a => a.AddAsync(someTransaction), Times.Once);
}
```

## Your Learning Progression

### Phase 1: Classic TDD on Engines (Start Here)

**Why start here?** Engines are pure logic with no dependencies. You can focus entirely on the Red-Green-Refactor cycle without dealing with mocks, DI, or async.

**Exercises:**
1. `TransactionEngine.ValidateTransaction()` — validate amount, description, category
2. `TransactionEngine.CalculateBalance()` — sum incomes minus expenses
3. `BudgetEngine.IsOverBudget()` — compare spent vs limit
4. `BudgetEngine.GetRemainingBudget()` — simple subtraction with edge cases

**Focus on:**
- Writing the test FIRST (resist the urge to write implementation)
- Making it FAIL first (red)
- Writing MINIMAL code to pass (green)
- Cleaning up (refactor)
- Small steps — one behavior per test

### Phase 2: London-School TDD on Managers

**Why next?** Managers depend on Engines and Accessors through contracts. This forces you to learn mocking (Moq), dependency injection, and interaction testing.

**Exercises:**
1. `BudgetManager.RecordTransactionAsync()` — orchestrate validate → save → check budget
2. `BudgetManager.GetMonthlySummaryAsync()` — fetch data → calculate → assemble

**Focus on:**
- Setting up mocks with `Mock<ITransactionEngine>()`
- Verifying interactions with `Verify()`
- Understanding when to use state vs interaction verification
- Noticing how contracts make mocking trivial

### Phase 3: Integration Tests on Accessors

**Why last?** Accessors touch real infrastructure (database). Integration tests are slower, need setup/teardown, and test infrastructure more than logic.

**Focus on:**
- Test database setup (in-memory SQLite or Docker SQL Server)
- Transaction rollback patterns
- Testing actual SQL/EF behavior

## TDD Katas (Warm-Up Exercises)

Before diving into the Budget Tracker, practice the cycle on small standalone problems:

| Kata | Concept | Difficulty |
|------|---------|-----------|
| String Calculator | Parse and sum — basic Red-Green-Refactor | ⭐ |
| FizzBuzz | Conditional logic with incremental tests | ⭐ |
| Roman Numerals | Transformation logic, emergent design | ⭐⭐ |
| Bowling Game | State tracking, complex rules | ⭐⭐⭐ |
| Bank Account | Outside-in with mocks | ⭐⭐⭐ |

## Key Principles

1. **Tests are specifications** — read them as documentation of behavior
2. **If it's hard to test, the design is wrong** — this is the real value of TDD
3. **Don't test implementation details** — test behavior and outcomes
4. **One assertion per test** (guideline, not law) — each test proves one thing
5. **Arrange-Act-Assert** — structure every test this way

## Resources

- **Kent Beck** — *Test-Driven Development By Example* (2002) — the classic
- **Steve Freeman & Nat Pryce** — *Growing Object-Oriented Software, Guided by Tests* (2009) — London-school bible
- **Mark Seemann** — *Dependency Injection in .NET* — connects DI to testability
- **Roy Osherove** — *The Art of Unit Testing* — practical .NET testing guide
