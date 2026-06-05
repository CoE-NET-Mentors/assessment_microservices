---
id: LEAD-BE-001
type: practical
target: lead
profile: backend
timebox: 45-60m
requires: [dotnet]
optional: [docker]
---

# Add Cross-Cutting Observability

## Scenario

Support needs enough observability to understand order workflow failures across the Orders API and Inventory API during local development.

## Starting Point

Use both backend services under `code/backend`.

## Evaluates

- Multiple logging strategies
- Observability
- Cross-service correlation
- Production support thinking
- Security awareness around sensitive data
- Communication of operational tradeoffs

## Acceptance Criteria

- Add consistent structured logging around key order and inventory operations.
- Include enough context to connect an order operation to inventory adjustment.
- Avoid logging secrets or sensitive customer data.
- Existing behavior is preserved.
- Relevant tests are added or updated where backend test coverage exists.
- `dotnet build code/backend/AssessmentMicroservices.slnx` passes.

## Discussion Extensions

Use only if useful during the session.

- What would you log, measure, and trace in production?
- How would you correlate requests across services?
- What would you alert on?

## Homework Deliverable

If completed after the session, include:

- what changed
- how to run it
- what tradeoffs were made
- any unfinished items
