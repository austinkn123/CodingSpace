# CodingSpace

A **deliberate practice environment** for mastering software architecture and engineering discipline. Learn by doing — master IDesign methodology, TDD, and architectural patterns through hands-on implementation.

## Mission

Move beyond "making it work" to **"designing it right"**. Every exercise focuses on the *why* behind architectural decisions, building intuition for real-world engineering challenges.

## Current Focus

- **IDesign Method** — Volatility-based decomposition (Juval Löwy)
- **TDD** — Progressive from Classic (Inside-Out) to London-school (Outside-In)
- **Architecture Patterns** — Service boundaries, dependency rules, testable design

## AI Mentorship Ecosystem

Specialized AI mentors in [.github/agents/](.github/agents/) provide targeted guidance:

| Agent | Role |
|-------|------|
| **Tony-Architect** | System design, IDesign, architectural patterns |
| **Christopher-Product-Manager** | Learning roadmap, skill-building objectives |
| **Paulie-Senior-Developer** | Technical execution, clean code, .NET/React |
| **Silvio-QA** | Testing strategies, TDD, quality engineering |
| **Bobby-documentation-specialist** | README files and project documentation |

## Tech Stack

- **Backend**: .NET 9 / ASP.NET Core Web API
- **Architecture**: IDesign (Managers / Engines / Accessors / Utilities)
- **Database**: Microsoft SQL Server, PostgreSQL
- **ORM**: Dapper, Entity Framework Core, Raw SQL
- **Testing**: xUnit, Moq (Backend) | Jest, React Testing Library (Frontend)

## Repository Structure

```
CodingSpace/
├── docs/
│   ├── concepts/                          # Deep-dives (IDesign, TDD)
│   └── decisions/                         # Architecture Decision Records
│
├── src/
│   ├── CodingSpace.Lab/                   # C# fundamentals playground
│   │   ├── Fundamentals/                  #   Generics, Reflection
│   │   └── Patterns/                      #   Result Pattern
│   │
│   └── BudgetTracker/                     # IDesign architecture project
│       ├── BudgetTracker.Contracts/       #   Interfaces + DTOs
│       ├── BudgetTracker.Engines/         #   Pure business logic
│       ├── BudgetTracker.Accessors/       #   Data access
│       ├── BudgetTracker.Managers/        #   Workflow orchestration
│       ├── BudgetTracker.Utilities/       #   Cross-cutting concerns
│       └── BudgetTracker.Client.API/      #   ASP.NET Core entry point
│
├── tests/
│   ├── CodingSpace.Lab.Tests/             # Fundamentals tests
│   ├── BudgetTracker.Engines.Tests/       # TDD Phase 1 (Classic)
│   ├── BudgetTracker.Managers.Tests/      # TDD Phase 2 (London-school)
│   └── CodingSpace.Katas/                # TDD practice exercises
│
├── projects/                              # Future capstone projects
└── client/                                # React frontend (future)
```

## Getting Started

### Learning Path

1. **Read the concepts**: [IDesign Method](docs/concepts/idesign-method.md) | [TDD Fundamentals](docs/concepts/tdd-fundamentals.md)
2. **Warm up with TDD Katas**: Start with [String Calculator](tests/CodingSpace.Katas/README.md)
3. **Build BudgetTracker via TDD**:
   - Phase 1: Implement Engines using Classic TDD → [Engine Tests](tests/BudgetTracker.Engines.Tests/)
   - Phase 2: Implement Managers using London-school TDD → [Manager Tests](tests/BudgetTracker.Managers.Tests/)
   - Phase 3: Implement Accessors with integration tests

### Run Tests
```bash
dotnet test
```

### Run the Budget Tracker API (after implementation)
```bash
cd src/BudgetTracker/BudgetTracker.Client.API
dotnet run
```

### Fundamentals Lab (preserved)
```bash
cd src/CodingSpace.Lab
dotnet run
```
