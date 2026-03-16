# IDesign Method — Concept Deep-Dive

## What Is It?

**IDesign** is a software architecture methodology created by **Juval Löwy** (detailed in his book *Righting Software*). It's a **volatility-based decomposition** approach — you structure your system based on *what changes independently*, not on features or business domains.

## The Core Insight

Most architectures decompose by **functionality**: OrderService, UserService, PaymentService. This creates *functional cohesion* but doesn't address the real problem — **change**. When requirements shift, functional services often need coordinated changes across multiple layers.

IDesign asks a different question:

> *"What is likely to change independently in this system, and how do I isolate that change?"*

## The Five Service Archetypes

Every class in an IDesign system falls into one of five categories:

### 1. Managers (Orchestration)
- **Responsibility**: Coordinate workflows. Sequence calls to Engines and Accessors.
- **Rules**: 
  - Never contain business logic
  - Never access data directly
  - Only call other services through contracts (interfaces)
- **Example**: `BudgetManager` orchestrates "record a transaction" by calling `TransactionEngine.Validate()`, then `TransactionAccessor.Save()`, then `BudgetEngine.CheckLimit()`.

### 2. Engines (Business Logic)
- **Responsibility**: Pure business rules, calculations, validations.
- **Rules**:
  - **Stateless** — no instance state between calls
  - **No data access** — never touch a database or file system
  - **No workflow awareness** — don't know what comes before or after
- **Example**: `BudgetEngine.IsOverBudget(budget)` — pure calculation, no side effects.
- **Testing**: Classic TDD paradise. Pure functions → easy to test, no mocks needed.

### 3. Accessors (Data Access)
- **Responsibility**: CRUD operations for a single resource type.
- **Rules**:
  - One accessor per resource/entity type
  - No business logic — just read/write data
  - Abstracts the storage mechanism (SQL, file, API)
- **Example**: `TransactionAccessor` handles all Transaction CRUD.

### 4. Utilities (Cross-Cutting)
- **Responsibility**: Shared infrastructure concerns.
- **Examples**: Logging, caching, date/time providers, configuration.
- **Rules**: Available to all layers. Should be stateless or singleton-scoped.

### 5. Clients (Entry Points)
- **Responsibility**: Accept external requests, delegate to Managers.
- **Examples**: API Controllers, CLI commands, message handlers.
- **Rules**: **Thin**. No logic. Just map input → Manager call → output.

## The Golden Rule: Contracts

```
Every service is defined by a contract (interface).
Services communicate ONLY through contracts.
No layer references another layer's implementation — only Contracts.
```

This is enforced at the **assembly level**: each layer is a separate .csproj that only references the Contracts project.

```
┌─────────────┐
│  Client.API  │──→ Contracts (+ DI wiring)
└─────────────┘
┌─────────────┐
│   Managers   │──→ Contracts ONLY
└─────────────┘
┌─────────────┐
│   Engines    │──→ Contracts ONLY
└─────────────┘
┌─────────────┐
│  Accessors   │──→ Contracts ONLY
└─────────────┘
┌─────────────┐
│  Utilities   │──→ Contracts ONLY (or nothing)
└─────────────┘
```

## Why It Matters for Your Career

1. **Testability**: Contracts = natural test seams. Every dependency is injectable.
2. **Team scalability**: Different teams own different layers. Merges rarely conflict.
3. **Change isolation**: Swapping a database only touches one Accessor. Business rule change only touches one Engine.
4. **Interview signal**: Understanding volatility-based design separates senior engineers from mid-level.

## Common Mistakes

| Mistake | Why It's Wrong |
|---------|---------------|
| Business logic in a Manager | Managers orchestrate; Engines calculate |
| Engine calling an Accessor | Engines are pure. If they need data, the Manager fetches it first and passes it in |
| Fat Controllers (Clients) | Controllers should be 3-5 lines: parse input, call Manager, return result |
| Skipping Contracts | Without interfaces, you can't substitute, test, or enforce boundaries |

## Resources

- **Juval Löwy** — *Righting Software* (Addison-Wesley, 2019) — the definitive IDesign book
- **IDesign.net** — Löwy's official site with method documentation
- **Pluralsight** — Search for "IDesign" or "Juval Löwy" for video courses
