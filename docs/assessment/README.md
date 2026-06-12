# Assessment Docs

These docs describe how this repository is used as a practical technical assessment sandbox for Unosquare .NET CoE Delivery Professionals.

The official roadmap and assessment evidence format live outside this repository. This repo provides working code, task scenarios, and enough structure for mentors to run consistent practical sessions without turning the repository into a grading system.

## Assessment Modes

- [Roadmap task catalog](tasks): extend the existing Orders/Inventory system.
- [Custom challenge](custom-challenge): build an agreed vertical feature from neutral starter applications.

The mentor should confirm the selected mode before implementation begins.

## Principles

- Start at Junior and go up to Principal.
- Use Delivery Professional or DP consistently.
- Treat the session as realistic pair programming/customer work.
- Allow documentation, search, AI tools, notes, books, and reference repos when they do not violate customer rules, NDAs, confidentiality, or company policy.
- Require the DP to understand and own the result.
- Do not ask another person outside the assessment meeting for help during the session.
- Keep task files DP-readable.
- Do not put hidden grading guidance in committed task files.
- Do not maintain a shadow copy of the roadmap.
- Duplicate frontend tasks per framework when framework-specific instructions matter.
- DP should be showing research, prompts, and investigations on the shared screen; occasional background windows on secondary monitors are acceptable but primary activity must remain visible.
- Treat each task's stated starting point as part of the assigned work.
- Distinguish placeholder runtime behavior from repository structure and service ownership.
- Discuss material architectural or tooling changes before investing significant time in them.

## Task Catalog

Tasks live under [tasks](tasks).

Use [roadmap-task-mapping.md](roadmap-task-mapping.md) to understand how the current starter tasks map to roadmap seniority bands and where future tasks can extend coverage.

Suggested seniority folders:

```text
tasks/
  junior/
  intermediate/
  senior/
  lead/
  principal/
```

Task IDs use this shape:

```text
JUN-BE-001
INT-FE-001-REACT
INT-FE-001-ANGULAR
SEN-BE-001
LEAD-HYB-001
PRI-HYB-001
```

Task types:

- `practical`: primarily implementation work
- `hybrid`: small implementation or repo inspection plus design/tradeoff explanation

Discussion extensions are optional prompts attached to practical work. They do not replace the official assessment questions.

## Completion Contract

Unless a task says otherwise, a task is complete when:

- the requested behavior works
- implemented runtime behavior outside the requested change remains working
- the stated starting point and existing code paths are considered before structural changes are made
- existing project structure, service boundaries, and data ownership are respected
- structural changes are intentional, discussed when material, and do not leave unexplained duplicate paths
- relevant tests are added or updated where the repo already has test coverage
- `dotnet build` passes for backend work
- `dotnet test` passes when backend test projects exist
- `npm run build` passes for the selected frontend
- frontend tests pass when the selected frontend has relevant tests
- the DP can explain the implementation, tradeoffs, and unfinished items

Placeholder methods and cardboard UI may have little runtime behavior to preserve. Their containing files, components, services, projects, and ownership boundaries are still intentional unless the task or mentor approves a change.

Alternative tools or designs may be proposed. Changes that materially affect scope, project structure, persistence, package management, or service ownership should be clarified with the mentor first. Choosing an alternative does not extend the timebox.

## Homework Continuation

If work continues after the live session, the DP should include:

- what changed
- how to run it
- what tradeoffs were made
- any unfinished items
