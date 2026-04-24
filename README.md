# Unosquare CoE .NET Technical Assessment — Microservices Edition

This repository contains a technical assessment designed to cover most of the skills expected of any member — regardless of seniority — of the **.NET Center of Excellence**.

---

## ⏱ Timebox

**1 hour**

* Backend: **.NET (ASP.NET Core)**
* Frontend: **React or Angular (your choice)**

You are free to use AI tools. You will be asked to **explain and defend your implementation decisions**.

---

## 🎯 Objective

Build a simple **Order System split into two services**:

* **Orders API**
* **Inventory API**

This assessment is designed to evaluate a combination of skills, including:

* API design and correctness
* Business rule implementation
* Code organization and clarity
* Problem-solving approach
* Frontend-backend integration
* Inter-service communication
* Handling of failure scenarios
* Ability to make and justify trade-offs

The depth of evaluation may vary depending on the candidate’s seniority.

---

## 🧱 Architecture Overview

You will work with two independent services:

### Service A — Orders API

Manages orders and their lifecycle.

### Service B — Inventory API

Manages product stock.

### Integration Requirement

When an order is **confirmed**, the Orders API must:

* call the Inventory API
* reduce the product stock

You must handle the case where the Inventory API is unavailable.

---

## 📦 Data Models

### Order

```csharp
Order {
  Id,
  CustomerId,
  ProductId,
  Quantity,
  Status (Pending | Confirmed | Cancelled),
  CreatedAt
}
```

### Product

```csharp
Product {
  Id,
  Name,
  Stock
}
```

---

## 🔧 Backend Requirements

### Service A — Orders API

#### Endpoints

* `POST /api/orders`

  * Create a new order
  * **Rule:** Quantity must be greater than 0

* `GET /api/orders`

  * List orders
  * Optional filters:

    * `?customerId=`
    * `?status=`

* `PATCH /api/orders/{id}`

  * Update order status
  * **Allowed transitions only:**

    * Pending → Confirmed
    * Pending → Cancelled

* `GET /api/orders/summary`

  * Return count of orders per status

---

### Service B — Inventory API

#### Endpoints

* `GET /api/products/{id}`

  * Get product with current stock

* `PATCH /api/products/{id}/stock`

  * Adjust product stock
  * **Rule:** Stock cannot go below zero

---

## 🔗 Integration Requirements

When confirming an order:

* Orders API must call Inventory API using **HttpClient**
* Stock must be reduced accordingly
* You must handle failures when Inventory API is:

  * down
  * unreachable
  * returning errors

---

## 💻 Frontend Requirements

Build a simple UI that shows the full workflow:

* Order list with **status badge**
* Create order form
* Confirm / Cancel buttons
* Product stock indicator that updates after confirmation

You may use **React or Angular**.

---

## ⚙️ Technical Guidelines

* Use **in-memory storage** (no database required)
* Keep services **independent**
* Each service should run separately
* Keep the solution simple and focused on requirements
* Avoid over-engineering unless it clearly adds value

---

## 🚀 How to Run

### Backend

Run each service independently:

```bash
cd code/backend/Orders.Api
dotnet run

cd code/backend/Inventory.Api
dotnet run
```

---

### Frontend (React)

```bash
cd code/frontend/react
npm install
npm start
```

---

### Frontend (Angular)

```bash
cd code/frontend/angular
npm install
npm start
```

---

## ✅ Evaluation Criteria

Priority is given to:

* Completing all required functionality
* Correct implementation of business rules
* Clear and maintainable code
* Proper inter-service communication
* Awareness and handling of failure scenarios
* Ability to explain decisions and trade-offs

---

## ⚠️ Important

Focus on **delivering a working solution first**.

Additional architectural improvements are welcome **only if core requirements are complete**.

