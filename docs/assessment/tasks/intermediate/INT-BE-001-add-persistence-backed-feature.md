---
id: INT-BE-001
type: practical
target: intermediate
profile: backend
timebox: 45-60m
requires: [dotnet]
optional: [sqlserver, docker]
---

# Add A Persistence-Backed Order Feature

## Scenario

The Orders API needs to store and retrieve orders through the existing data access layer instead of relying on temporary placeholders.

## Starting Point

Use `code/backend/Orders.Api`, especially `OrdersDbContext`, `OrdersService`, contracts, and the orders controller.

## Evaluates

- C# advanced fundamentals
- ASP.NET Core
- Entity Framework
- SQL/data modeling awareness
- Validation and error handling
- Unit or integration testing
- Clean code principles

## Acceptance Criteria

- Creating an order persists it through the configured `OrdersDbContext`.
- Listing orders returns persisted orders.
- Filtering by customer or status works when supplied.
- Invalid quantities are rejected with a clear API response.
- Existing behavior is preserved.
- Relevant tests are added or updated where backend test coverage exists.
- `dotnet build code/backend/AssessmentMicroservices.slnx` passes.

## Discussion Extensions

Use only if useful during the session.

- What would change if the in-memory database became SQL Server?
- Where should validation live?
- How should API errors be shaped so a frontend can display them cleanly?

## Homework Deliverable

If completed after the session, include:

- what changed
- how to run it
- what tradeoffs were made
- any unfinished items
