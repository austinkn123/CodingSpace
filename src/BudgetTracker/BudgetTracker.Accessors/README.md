# BudgetTracker.Accessors

## IDesign Layer: Accessors

**Responsibility**: Data access for a single resource type. No business logic.

## Your Challenge (TDD Phase 3 — Integration Tests)

Implement these classes:

### 1. `TransactionAccessor : ITransactionAccessor`
- Start with an **in-memory implementation** (Dictionary or List)
- Later, swap to SQL Server or EF Core — the interface stays the same

### 2. `BudgetAccessor : IBudgetAccessor`
- Same approach: in-memory first, database later

## Why In-Memory First?

This demonstrates a core IDesign benefit: because the Manager calls the Accessor
through `ITransactionAccessor` (contract), it doesn't care if the data is in memory,
SQL Server, or a REST API. You can swap implementations without touching any other layer.

## Rules
- ONE accessor per resource type (Transaction, Budget)
- NO business logic — just CRUD
- NO references to Engines or Managers
