# ADR 001: Restructure Repository for Architecture Patterns and TDD

## Status
**Accepted** — March 2026

## Context

CodingSpace began as a fundamentals-focused playground with isolated exercises (Generics, Reflection, Result Pattern). While these C# foundations are valuable, the learning goals have evolved toward:

1. **IDesign Method** — Juval Löwy's volatility-based decomposition methodology
2. **Test-Driven Development** — Progressive from Classic (Inside-Out) to London-school (Outside-In)
3. **Architecture patterns** — Understanding service boundaries, dependency rules, and design trade-offs

The existing `CodingSpace.Lab` project is a flat sandbox. Architecture learning requires **real project structure** with enforced boundaries, separate assemblies, and proper dependency management.

## Decision

### 1. Preserve Existing Work
Keep `CodingSpace.Lab` and its tests intact as the fundamentals reference. Do not archive or delete — these remain useful for C# language features and patterns.

### 2. Add IDesign-Structured Project: Budget Tracker
Create a new multi-project domain application decomposed using IDesign principles:

```
src/BudgetTracker/
├── BudgetTracker.Contracts/       # Interfaces + DTOs (referenced by all)
├── BudgetTracker.Engines/         # Pure business logic (stateless)
├── BudgetTracker.Accessors/       # Data access (one per resource)
├── BudgetTracker.Managers/        # Workflow orchestration
├── BudgetTracker.Utilities/       # Cross-cutting concerns
└── BudgetTracker.Client.API/      # ASP.NET Core entry point
```

**Dependency Rule**: Every layer references only `BudgetTracker.Contracts`. No direct references between Engines, Accessors, or Managers. The Client.API wires everything via DI.

### 3. Progressive TDD Learning
- **Phase 1 (Classic TDD)**: Start with Engines — pure functions, no dependencies, no mocks needed. Learn Red-Green-Refactor cleanly.
- **Phase 2 (London-school TDD)**: Move to Managers — mock Engines and Accessors through contracts. Learn interaction-based testing.
- **Phase 3 (Integration)**: Test Accessors with real databases. Learn test infrastructure.

## Consequences

### Benefits
- Assembly-level boundaries enforce IDesign dependency rules (compiler prevents violations)
- Contracts-first design creates natural test seams
- Progressive TDD matches the increasing complexity of each IDesign layer
- Budget Tracker domain is simple enough to focus on architecture, not business complexity

### Trade-offs
- More projects = more solution complexity (6 src + 3 test projects added)
- Must maintain discipline with dependency rules (no "shortcut" references)
- IDesign is opinionated — it's one architectural style, not the only one

### Risks
- Over-engineering a simple domain to fit the pattern (mitigated: this is for learning)
- Getting lost in structure before building anything (mitigated: TDD forces incremental delivery)

## References
- Juval Löwy, "Righting Software" (Addison-Wesley, 2019)
- Kent Beck, "Test-Driven Development By Example" (2002)
- Steve Freeman & Nat Pryce, "Growing Object-Oriented Software, Guided by Tests" (2009)
