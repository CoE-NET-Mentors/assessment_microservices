---
id: SEN-BE-002
type: practical
target: senior
profile: backend
timebox: 45-60m
requires: [dotnet]
optional: []
---

# Refactor A Service Boundary

## Scenario

The Orders API is expected to grow. Refactor the order workflow enough to keep business rules, API concerns, and persistence concerns easier to change independently.

## Starting Point

Use `code/backend/Orders.Api`, especially the controller, service, contracts, domain model, and data context.

## Evaluates

- Advanced architecture
- Design patterns
- Clean code principles
- Refactoring judgment
- Testability
- AI-assisted development ownership

## Acceptance Criteria

- The selected refactor preserves existing behavior.
- Business rules are easier to identify and test after the change.
- Controllers remain focused on HTTP concerns.
- Relevant tests are added or updated where backend test coverage exists.
- `dotnet build code/backend/AssessmentMicroservices.slnx` passes.
- The DP can explain what was intentionally not refactored.

## Discussion Extensions

Use only if useful during the session.

- How far would you take this refactor in a real customer codebase?
- What coupling remains after the change?
- What would make this refactor risky?

## Homework Deliverable

If completed after the session, include:

- what changed
- how to run it
- what tradeoffs were made
- any unfinished items
