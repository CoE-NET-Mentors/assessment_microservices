---
id: SEN-BE-001
type: practical
target: senior
profile: backend
timebox: 45-60m
requires: [dotnet]
optional: [sqlserver, docker]
---

# Add Order Status Workflow Rules

## Scenario

Orders need controlled status transitions so an order cannot move into an invalid lifecycle state.

## Starting Point

Use `code/backend/Orders.Api`, especially the orders controller, service, `OrderStatus`, and update-status request contract.

## Evaluates

- Advanced application workflow
- Business rule modeling
- ASP.NET Core error handling
- Inter-service integration tradeoffs
- Resiliency and failure scenario thinking
- Testable domain/service behavior

## Acceptance Criteria

- Pending orders can be confirmed.
- Pending orders can be cancelled.
- Invalid transitions are rejected with a clear API response.
- Confirming an order coordinates with inventory stock adjustment when that integration is in scope for the session.
- Existing behavior is preserved.
- Relevant tests are added or updated where backend test coverage exists.
- `dotnet build code/backend/AssessmentMicroservices.slnx` passes.

## Discussion Extensions

Use only if useful during the session.

- What should happen if inventory stock adjustment fails after the order update starts?
- What would change if two users tried to update the same order at the same time?
- Where should workflow rules live if more statuses are added?

## Homework Deliverable

If completed after the session, include:

- what changed
- how to run it
- what tradeoffs were made
- any unfinished items
