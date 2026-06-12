# Custom Challenge

The custom challenge is a one-hour technical working session built around a small feature agreed at the start of the session.

It is separate from the Orders/Inventory roadmap task catalog. Use the starter applications under `code/custom-challenge`.

## Format

- Approximately 45 minutes for implementation.
- Approximately 15 minutes for demonstration and code defense.
- Backend uses .NET and ASP.NET Core.
- Fullstack assessments use either React or Angular, selected before the session.
- AI and normal reference materials are allowed under the repository assessment rules.

## Scope

Before coding, the mentor provides the scenario and the DP explains the implementation they intend to deliver. The agreed scope should be written into [challenge.md](challenge.md).

A typical challenge includes:

- one backend model with approximately 4-6 meaningful fields
- at least `GET` list, `POST` create, `PUT` update, and `DELETE`
- one business rule requiring validation
- a frontend that displays the list and supports creating or updating data
- a scope that can reasonably be completed and defended within one hour

These are format guidelines, not a fixed exercise. The agreed scenario and acceptance criteria are authoritative for the session.

## Starting Applications

```text
code/custom-challenge/
  backend/
    CustomChallenge.slnx
    CustomChallenge.Api/
  frontend/
    angular/
    react/
```

The starters intentionally provide only:

- a buildable ASP.NET Core API with `/health`
- a buildable React shell
- a buildable Angular shell with a basic test

The starter does not prescribe the model, persistence strategy, architecture, or UI.

## Completion Contract

- The agreed acceptance criteria are demonstrated.
- The selected applications build and run.
- The DP can explain and modify the submitted implementation.
- AI-generated code is reviewed and owned by the DP.
- Known blockers and incomplete work are disclosed before the demonstration.

The mentor question set and grading workbook are maintained outside this repository.
