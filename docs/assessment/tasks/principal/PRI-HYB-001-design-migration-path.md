---
id: PRI-HYB-001
type: hybrid
target: principal
profile: shared
timebox: 45-60m
requires: [dotnet]
optional: [docker]
---

# Design A Migration Path

## Scenario

The assessment system needs to evolve while staying useful for ongoing technical assessments. Design a migration path from the current small system toward a more production-shaped architecture without stopping delivery.

## Starting Point

Use the full repository, including backend services, frontend apps, and assessment docs.

## Evaluates

- Architecting solutions
- Migration strategies
- Application resiliency strategies
- Standards and team enablement
- Cost/noise tradeoffs
- Result-driven technical planning

## Acceptance Criteria

- Identify the current architectural constraints.
- Propose a sequence of changes that keeps the repo working between steps.
- Include at least one small code, docs, or test change that supports the first step.
- Avoid adding cloud or orchestration noise unless it directly supports the migration.
- Relevant build commands pass if code changes are made.
- The DP can explain risks, tradeoffs, and rollback options.

## Discussion Extensions

Use only if useful during the session.

- Which change would you make first and why?
- What standards would you introduce for teams working in this repo?
- What would you explicitly avoid doing?

## Homework Deliverable

If completed after the session, include:

- what changed
- how to run it
- what tradeoffs were made
- any unfinished items
