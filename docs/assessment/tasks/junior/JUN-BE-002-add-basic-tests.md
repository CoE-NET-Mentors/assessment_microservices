---
id: JUN-BE-002
type: practical
target: junior
profile: backend
timebox: 30-45m
requires: [dotnet]
optional: []
---

# Add Basic Service Tests

## Scenario

The order creation flow needs basic automated coverage so future changes do not break simple expected behavior.

## Starting Point

Use `code/backend/Orders.Api` and add a test project only if one does not already exist.

## Evaluates

- C# fundamentals
- Basic service behavior
- Unit testing fundamentals
- Clean and maintainable test setup
- Understanding expected versus invalid behavior

## Acceptance Criteria

- Add tests for creating an order with valid input.
- Add tests for rejecting invalid quantity.
- Keep the production implementation simple and readable.
- Implemented runtime behavior and the existing project structure are preserved.
- `dotnet build code/backend/AssessmentMicroservices.slnx` passes.
- `dotnet test` passes for the relevant test project or solution.

## Discussion Extensions

Use only if useful during the session.

- What is the difference between a unit test and an integration test here?
- Which behavior should be tested at service level versus API level?
- What test data setup keeps these tests easy to maintain?

## Homework Deliverable

If completed after the session, include:

- what changed
- how to run it
- what tradeoffs were made
- any unfinished items
