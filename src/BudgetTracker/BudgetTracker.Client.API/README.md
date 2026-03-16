# BudgetTracker.Client.API

## IDesign Layer: Client

**Responsibility**: Thin entry point. Parse input → call Manager → return result.

## Your Challenge (After Engines + Managers are done)

### `TransactionsController`
- `POST /api/transactions` → `IBudgetManager.RecordTransactionAsync()`
- `GET /api/summary/{year}/{month}` → `IBudgetManager.GetMonthlySummaryAsync()`

### `Program.cs` — DI Wiring
This is the **only place** that references all implementation assemblies.
```csharp
builder.Services.AddScoped<IBudgetManager, BudgetManager>();
builder.Services.AddScoped<ITransactionEngine, TransactionEngine>();
builder.Services.AddScoped<IBudgetEngine, BudgetEngine>();
builder.Services.AddScoped<ITransactionAccessor, TransactionAccessor>();
builder.Services.AddScoped<IBudgetAccessor, BudgetAccessor>();
```

## Rules
- Controllers should be 3-5 lines per action
- NO business logic
- NO direct data access
- This is the composition root — DI wiring happens here
