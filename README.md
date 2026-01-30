# CodingSpace

A **deliberate practice environment** for developing software engineering skills from intermediate to senior and architect levels. Learn by doing—master patterns, principles, and architectural thinking through hands-on implementation.

## Mission

Move beyond "making it work" to **"designing it right"**. Every exercise focuses on the *why* behind technical decisions, building intuition for real-world engineering challenges.

## AI Mentorship Ecosystem

Specialized AI mentors in [.github/agents/](.github/agents/) provide targeted guidance:

| Agent | Role |
|-------|------|
| **Tony-Architect** | System design, architectural patterns, decision-making |
| **Christopher-Product-Manager** | Learning roadmap, skill-building objectives, Jira tickets |
| **Paulie-Senior-Developer** | Technical execution, clean code, .NET/React best practices |
| **Silvio-QA** | Testing strategies, TDD, quality engineering |
| **Bobby-documentation-specialist** | README files and project documentation |

## Tech Stack

- **Backend**: Latest .NET / ASP.NET Core Web API
- **Frontend**: React + TypeScript + Vite
- **Database**: Microsoft SQL Server, PostgreSQL
- **ORM**: Dapper, Entity Framework Core, Raw SQL
- **Testing**: xUnit, Moq (Backend) | Jest, React Testing Library (Frontend)

## Repository Structure

```
CodingSpace/
├── docs/                          # Learning documentation
│   ├── roadmap.md                 # Skill progression map
│   ├── decisions/                 # Architecture Decision Records
│   └── concepts/                  # Concept deep-dives
│
├── labs/                          # Isolated learning exercises
│   ├── 01-fundamentals/           # Generics, Async, LINQ
│   ├── 02-patterns/               # Result, Repository, Factory
│   ├── 03-architecture/           # DI, CQRS, Clean Architecture
│   └── 04-advanced/               # Event-Driven, Distributed Systems
│
├── projects/                      # Capstone mini-projects
│
├── src/                           # Application code
│   ├── CodingSpace.API/           # ASP.NET Core Web API
│   └── CodingSpace.Lab/           # CLI playground for exercises
│
├── tests/                         # Automated tests
```

## Getting Started

### Run the API
```bash
cd src/CodingSpace.API
dotnet run
```

### Run the Lab CLI
```bash
cd src/CodingSpace.Lab
dotnet run
```

### Start Learning
1. Open [docs/roadmap.md](docs/roadmap.md)
2. Navigate to your current topic in `labs/`
3. Read the README, then implement the exercises
4. Ask an AI mentor for review when done
