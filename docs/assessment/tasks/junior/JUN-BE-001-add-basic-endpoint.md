---
id: JUN-BE-001
type: practical
target: junior
profile: backend
timebox: 30-45m
requires: [dotnet]
optional: []
---

# Add A Basic Orders Endpoint

## Scenario

The Orders API needs to return a single order by id so support users can inspect one order without loading the full list.

## Starting Point

Use `code/backend/Orders.Api`, especially the orders controller, service, contracts, and domain model.

## Evaluates

- C# fundamentals
- API fundamentals
- Basic HTTP behavior
- Reading and extending existing code
- Technical communication about a small change

## Acceptance Criteria

- Add an endpoint to get one order by id.
- Return a clear response when the order exists.
- Return an appropriate API response when the order does not exist.
- Existing order behavior is preserved.
- Relevant tests are added or updated where backend test coverage exists.
- `dotnet build code/backend/AssessmentMicroservices.slnx` passes.

## Discussion Extensions

Use only if useful during the session.

- What HTTP status code should be returned when the order does not exist?
- Where should mapping between domain objects and API responses live?
- What validation, if any, belongs on a `GET` endpoint?

## Homework Deliverable

If completed after the session, include:

- what changed
- how to run it
- what tradeoffs were made
- any unfinished items
