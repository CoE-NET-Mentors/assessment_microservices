---
id: PRI-HYB-002
type: hybrid
target: principal
profile: shared
timebox: 45-60m
requires: [dotnet]
optional: [docker]
---

# Write An Architecture Decision

## Scenario

The team needs a clear architecture decision for one meaningful change to the assessment system, such as introducing persistence, adding asynchronous integration, or changing how frontend apps consume backend APIs.

## Starting Point

Use the full repository and create or update a short ADR-style document if the selected decision benefits from one.

## Evaluates

- Architecture decision-making
- Understanding and proposing requirements
- Tradeoff communication
- Technical standards
- Coaching through written guidance
- Evidence-based decision revision

## Acceptance Criteria

- State the decision and context clearly.
- Explain the options considered.
- Explain the consequences and tradeoffs.
- Include a small repo change when useful to make the decision concrete.
- Identify any effect on existing project structure, service boundaries, and data ownership.
- Relevant build commands pass if code changes are made.
- The DP can defend the decision and identify what evidence would change it.

## Discussion Extensions

Use only if useful during the session.

- Who is affected by this decision?
- What would make this decision wrong later?
- How would you get adoption without adding process for its own sake?

## Homework Deliverable

If completed after the session, include:

- what changed
- how to run it
- what tradeoffs were made
- any unfinished items
