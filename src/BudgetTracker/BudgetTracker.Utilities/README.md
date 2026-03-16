# BudgetTracker.Utilities

## IDesign Layer: Utilities

**Responsibility**: Cross-cutting concerns available to all layers.

## Potential Utilities for Budget Tracker

- **`IDateTimeProvider`** — Abstraction over `DateTime.Now` for testability
- **`ICurrencyFormatter`** — Consistent currency display
- **Logging abstractions** — If not using built-in `ILogger<T>`

## Rules
- Stateless or singleton-scoped
- No business logic
- No awareness of specific domain workflows
