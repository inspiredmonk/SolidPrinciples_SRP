# 📘 Single Responsibility Principle (SRP)

> **Definition:**  
> A class should have only one reason to change.

---

## 🔍 What Is SRP?

The Single Responsibility Principle (SRP) is the **first principle** in the SOLID design principles. It states that a class, module, or function should be responsible for **only one piece of functionality**.

In other words:

> “A class should have one, and only one, reason to change.” — Robert C. Martin

When a class has multiple responsibilities, changes in one responsibility can unexpectedly affect the other.

---

## 🎯 Why SRP Matters

- Keeps classes **focused** and **predictable**.
- Isolates changes to a single place.
- Simplifies testing, debugging, and maintenance.
- Improves team collaboration by reducing coupling.

---

## ❌ Bad Example (SRP Violation)

```csharp
public class InvoiceManager
{
    public void CreateInvoice() { /* Business logic */ }

    public void SaveToDatabase() { /* Persistence logic */ }

    public void EmailInvoice() { /* Emailing logic */ }
}

🔎 What’s Wrong?
CreateInvoice: business logic

SaveToDatabase: data access

EmailInvoice: communication

All in the same class. A change in one area (e.g., email format) might break unrelated logic (e.g., saving to DB).

public class InvoiceService
{
    private readonly IInvoiceRepository _repository;
    private readonly IEmailService _emailService;

    public InvoiceService(IInvoiceRepository repository, IEmailService emailService)
    {
        _repository = repository;
        _emailService = emailService;
    }

    public void CreateInvoice(Invoice invoice)
    {
        _repository.Save(invoice);
        _emailService.Send(invoice);
    }
}

Breakdown
InvoiceService: business logic coordination

IInvoiceRepository: handles persistence

IEmailService: handles communication

Each class has a single, clear responsibility. You can change email logic without touching business or DB logic.

✅ Benefits of SRP
High cohesion, low coupling

Easier to read, test, and maintain

Cleaner separation of concerns

Reduces regression bugs

⚠️ Common Pitfalls
❌ Over-splitting: creating too many small, trivial classes

❌ Speed-over-structure: lumping logic to deliver faster

❌ Poor naming: unclear class roles often hide SRP violations

🔧 Related Design Patterns
Strategy

Command

Decorator

These patterns encourage separation of concerns and can help reinforce SRP.

💬 How to Explain SRP in an Interview
“The Single Responsibility Principle means a class should have one reason to change. It helps isolate functionality, reduce bugs, and make code more maintainable. If a class has multiple responsibilities—like sending email and writing to a database—it violates SRP because changes to one area could impact the other.”