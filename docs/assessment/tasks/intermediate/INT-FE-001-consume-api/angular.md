---
id: INT-FE-001-ANGULAR
type: practical
target: intermediate
profile: fullstack
frontend: angular
timebox: 45-60m
requires: [dotnet, angular]
optional: []
---

# Consume The Orders API In Angular

## Scenario

The Angular app needs to show live order data from the Orders API instead of placeholder content.

## Starting Point

Use `code/frontend/angular`, especially the orders page, order components, models, and API services.

## Evaluates

- TypeScript fundamentals
- REST API consumption
- SPA lifecycle basics
- Angular standalone component work
- Loading, empty, and error states
- Frontend-backend integration

## Acceptance Criteria

- The Angular app loads orders from the backend API.
- Loading, empty, and error states are visible.
- The order list renders useful order information.
- Existing Angular behavior is preserved.
- `npm run build` passes in `code/frontend/angular`.
- Relevant Angular tests pass when changed.
- Backend build passes if backend changes are made.

## Discussion Extensions

Use only if useful during the session.

- How should the UI behave when the API is down?
- Where should API URL configuration live?
- What would you change if this page needed pagination?

## Homework Deliverable

If completed after the session, include:

- what changed
- how to run it
- what tradeoffs were made
- any unfinished items
