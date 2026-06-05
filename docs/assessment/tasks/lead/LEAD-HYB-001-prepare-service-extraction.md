---
id: LEAD-HYB-001
type: hybrid
target: lead
profile: backend
timebox: 45-60m
requires: [dotnet]
optional: [docker]
---

# Prepare A Capability For Service Extraction

## Scenario

The order workflow may need to evolve into a separately deployable capability later. Prepare the code enough to make that future change easier without actually extracting a new service.

## Starting Point

Use `code/backend/Orders.Api` and any integration points with `Inventory.Api`.

## Evaluates

- Advanced architecture
- Distributed systems boundaries
- Migration sequencing
- Requirements clarification
- Consultancy mindset
- Restraint around unnecessary infrastructure

## Acceptance Criteria

- Identify one capability boundary that would be reasonable to extract later.
- Make a small code or documentation change that clarifies the boundary.
- Preserve existing behavior.
- Avoid creating unnecessary infrastructure.
- `dotnet build code/backend/AssessmentMicroservices.slnx` passes if code changes are made.
- The DP can explain the migration path and risks.

## Discussion Extensions

Use only if useful during the session.

- What data would the extracted capability own?
- What communication style would you choose first and why?
- How would you migrate without breaking existing consumers?

## Homework Deliverable

If completed after the session, include:

- what changed
- how to run it
- what tradeoffs were made
- any unfinished items
