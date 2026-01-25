# CodingSpace

CodingSpace is a deliberate practice environment designed to evolve software engineering skills from intermediate to senior and architect levels. This repository serves as a hands-on laboratory for mastering architectural principles, design patterns, and modern development workflows through the development of production-grade applications.

## Mission

The primary goal of CodingSpace is to teach architectural thinking and professional engineering standards through consistent, guided practice. It moves beyond "making it work" to "designing it right," focusing on the *why* behind every technical decision.

## AI Mentorship Ecosystem

This environment features a suite of specialized AI personas located in [.github/agents/](.github/agents/), each providing targeted guidance:

- **Tony-Architect**: Focuses on system design, architectural patterns, and high-level decision making.
- **Junior-Product-Manager**: Manages the learning roadmap, defines skill-building objectives, and structures Jira-style tasks.
- **Paulie-Senior-Developer**: Provides technical execution guidance, code style mentorship, and implementation best practices.
- **Silvio-QA**: Teaches testing strategies, TDD, and quality engineering.

## Tech Stack

The project utilizes a modern enterprise stack to simulate real-world development scenarios:

- **Backend**: .NET / ASP.NET Core Web API
- **Frontend**: React + TypeScript + Vite
- **Database**: Microsoft SQL Server & PostgreSQL
- **ORM**: Dapper, Entity Framework Core, and Raw SQL
- **Testing**: xUnit, Moq (Backend) | Jest, React Testing Library (Frontend)

## Architecture & Design

CodingSpace explores various architectural patterns and design principles to build robust, maintainable systems. Rather than adhering to a single strict methodology, the project focuses on:

- **Separation of Concerns**: Ensuring distinct project layers have clear responsibilities.
- **Maintainability**: Writing code that is easy to understand, test, and evolve.
- **Pattern Recognition**: Identifying and applying the right design patterns for the specific problem at hand (e.g., Repository, CQRS, Hexagonal, etc.).
- **Decision Logic**: Documenting the trade-offs involved in choosing one approach over another.

## Repository Structure

- **.github/agents/**: Definitions for AI mentor personas.
- **.github/agents/skills/**: Capability guides for agents (Code Review, Test Strategy, etc.).
- **src/**: Main source code for the platform.
  - **CodingSpace.Shared**: Cross-cutting concerns (Result<T>, Constants).
  - **CodingSpace.Core**: Business logic & Domain interfaces (EventBus).
  - **CodingSpace.Infrastructure**: Concrete implementations (SQL, External APIs).
  - **CodingSpace.API**: Entry point (ASP.NET Core).
- **tests/**: Automated test projects.
  - **CodingSpace.Shared.Tests**: Unit tests for shared components.
  - **CodingSpace.Core.Tests**: Unit tests for core business logic.

