# Roadmap Task Mapping

This document maps the current starter task catalog to the CoE roadmap at a capability level. It is intentionally not a shadow copy of the roadmap workbook.

The roadmap workbook remains the source of truth. Use this file only to understand what the current task catalog is meant to exercise and where future tasks can be added.

## Seniority Mapping

| Repo task folder | Roadmap seniority band |
| --- | --- |
| `junior` | Lower roadmap fundamentals, with tasks written for Junior and above |
| `intermediate` | Intermediate 1-3 |
| `senior` | Intermediate 4 - S1 |
| `lead` | S2 - Principal, focused on delivery leadership and system-level execution |
| `principal` | S2 - Principal, focused on architecture, migration, standards, and enablement |

## Current Coverage

| Task | Roadmap capabilities exercised |
| --- | --- |
| `JUN-BE-001` | C# fundamentals, API fundamentals, Git-friendly small change, communication about HTTP behavior |
| `JUN-BE-002` | C# fundamentals, API/service behavior, unit testing basics, maintainable test setup |
| `INT-BE-001` | C# advanced, ASP.NET Core, Entity Framework, SQL/data modeling awareness, validation, unit/integration testing, clean code |
| `INT-FE-001-REACT` | TypeScript fundamentals, REST API consumption, SPA lifecycle basics, loading/error states, React component work |
| `INT-FE-001-ANGULAR` | TypeScript fundamentals, REST API consumption, SPA lifecycle basics, loading/error states, Angular standalone component work |
| `SEN-BE-001` | Advanced application workflow, business rule modeling, Docker/local dependency discussion when useful, resiliency tradeoffs, integration failure handling |
| `SEN-BE-002` | Advanced architecture, design patterns, clean code, testability, refactoring judgment, AI-assisted development ownership |
| `LEAD-BE-001` | Logging strategies, observability, production support thinking, cross-service correlation, operational communication |
| `LEAD-HYB-001` | Advanced architecture, distributed systems boundaries, migration sequencing, requirements clarification, consultancy mindset |
| `PRI-HYB-001` | Architecting solutions, migration strategies, resiliency, cost/noise tradeoffs, team enablement, standards |
| `PRI-HYB-002` | Architecture decisions, requirements proposal, tradeoff communication, coaching through standards, governance without ceremony |

## Intentional Gaps For Future Tasks

The first task set does not try to evaluate every roadmap topic. Add tasks over time when mentors need more coverage.

Good next additions:

- SQL Server-focused backend task with real provider configuration and query tuning discussion.
- Docker Compose local dependency task for SQL Server, RabbitMQ, or local cloud emulators.
- Resilient HTTP integration task using timeouts, retries, and fallback behavior.
- Frontend form validation task duplicated for React and Angular.
- Frontend state management task duplicated for React and Angular.
- Accessibility-focused frontend task.
- Authentication or authorization flow discussion/task using local-only scaffolding.
- Performance investigation task for backend or frontend.
- AI-assisted refactoring task where the DP must explain generated code and reject bad suggestions.

## Maintenance Rule

When the roadmap changes, update this mapping and the task catalog by capability. Do not paste roadmap tables or resource lists into the repo.
