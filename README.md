# Unosquare CoE .NET Technical Assessment - Microservices Edition

This repository is a technical assessment sandbox for Unosquare .NET Center of Excellence Delivery Professionals. It is used during working sessions to evaluate practical engineering skills, communication, tradeoff decisions, and ownership of a solution.

The repo is intentionally small. It should build, run, and stay easy to extend during an assessment. Some code paths may be cardboard or throw `NotImplementedException` until a selected task asks the Delivery Professional to complete them.

## Assessment Model

This is not a closed-book exam. It is a realistic technical working session.

Delivery Professionals may use the same kinds of resources they would normally use while working with a customer, including documentation, search engines, AI assistants, books, notes, and reference repositories, as long as doing so does not violate customer rules, NDAs, confidentiality expectations, or company policy.

The Delivery Professional is expected to understand and own any solution they produce. The mentor may ask them to explain, modify, debug, or defend any part of the implementation, including code generated with AI assistance.

The Delivery Professional must not ask another person outside the assessment meeting for help during the session.

## Repository Scenario

The current scenario is a small order management system split into two independent services:

- `Orders.Api` manages orders and their lifecycle.
- `Inventory.Api` manages products and stock.
- React and Angular frontends are included so Fullstack assessments can use the framework selected before the session.

When an order is confirmed, the Orders API is expected to coordinate with the Inventory API and reduce product stock. Selected assessment tasks may ask the Delivery Professional to implement, extend, refactor, or discuss parts of this flow.

## Project Structure

```text
code/
  backend/
    AssessmentMicroservices.slnx
    Inventory.Api/
    Orders.Api/
  frontend/
    angular/
    react/
docs/
  assessment/
    README.md
    ExcelToRepoContextualizer.md
    task-template.md
    tasks/
```

## How To Run

### Backend

Run each service independently:

```bash
cd code/backend/Orders.Api
dotnet run

cd code/backend/Inventory.Api
dotnet run
```

Build the backend solution:

```bash
dotnet build code/backend/AssessmentMicroservices.slnx
```

Run backend tests when test projects exist:

```bash
dotnet test code/backend/AssessmentMicroservices.slnx
```

### React Frontend

```bash
cd code/frontend/react
npm install
npm start
```

Build:

```bash
npm run build
```

### Angular Frontend

```bash
cd code/frontend/angular
npm install
npm start
```

Build:

```bash
npm run build
```

Run tests:

```bash
npm test
```

## Assessment Tasks

Assessment tasks live under [docs/assessment/tasks](docs/assessment/tasks).

Task files describe practical work scenarios. They are not grading rubrics and do not determine promotion outcomes. Seniority assessment is based on the official assessment process, mentor judgment, completed work, discussion, and evidence captured in the assessment format.

Every task follows the same basic completion contract:

- the requested behavior works
- the app still builds
- relevant tests pass when test projects or frontend tests exist
- the Delivery Professional can explain the implementation and tradeoffs

For homework continuation, include:

- what changed
- how to run it
- what tradeoffs were made
- any unfinished items

## Roadmap Source Of Truth

The CoE roadmap is maintained outside this repository. Do not copy roadmap rows into this repo as a shadow source of truth.

Use [docs/assessment/ExcelToRepoContextualizer.md](docs/assessment/ExcelToRepoContextualizer.md) when the roadmap workbook needs to be used as context for updating repository docs, tasks, or code scaffolding.

## Technical Guidelines

- Keep the baseline working.
- Prefer small, understandable changes during the assessment.
- Use the latest supported .NET, ASP.NET Core, EF Core, React, and Angular versions maintained by this repo.
- Keep infrastructure local and lightweight.
- Use Docker only when it helps simulate a dependency without turning the assessment into cloud setup work.
- Do not add real customer secrets, customer code, or NDA-protected material.
