---
id: INT-FE-001-REACT
type: practical
target: intermediate
profile: fullstack
frontend: react
timebox: 45-60m
requires: [dotnet, react]
optional: []
---

# Consume The Orders API In React

## Scenario

The React app needs to show live order data from the Orders API instead of placeholder content.

## Starting Point

Use `code/frontend/react`, especially the orders page, order components, models, and API services.

## Evaluates

- TypeScript fundamentals
- REST API consumption
- SPA lifecycle basics
- React component work
- Loading, empty, and error states
- Frontend-backend integration

## Acceptance Criteria

- The React app loads orders from the backend API.
- Loading, empty, and error states are visible.
- The order list renders useful order information.
- Existing React behavior is preserved.
- `npm run build` passes in `code/frontend/react`.
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
