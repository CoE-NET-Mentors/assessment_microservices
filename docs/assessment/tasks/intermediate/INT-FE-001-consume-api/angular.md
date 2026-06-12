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

Consider how the complete order workflow uses the pages, components, models, services, and backend applications already present in the repository.

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
- The complete order workflow remains consistent with the existing application architecture.
- Material structural changes do not leave unexplained duplicate or abandoned implementations.
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
