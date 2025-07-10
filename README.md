# SolidPrinciples_SRP
SOLID Principles Deep Dive Single Responsibility Principle (SRP)


✅ **Short Definition:**  
> A class should have only one reason to change.

🧠 **Deep Explanation:**  
- Encapsulate one responsibility per class.  
- Avoid classes doing unrelated jobs.  
- Makes changes localized and reduces bugs.

🛠️ **.NET/C# Example:**

❌ *Bad:*

```csharp
public class InvoiceManager
{
    public void CreateInvoice() { /*...*/ }
    public void SaveToDatabase() { /*...*/ }
    public void EmailInvoice() { /*...*/ }
}

```
✅ Good (SRP applied):
```csharp
public class InvoiceService
{
    private readonly IInvoiceRepository _repo;
    private readonly IEmailService _email;

    public InvoiceService(IInvoiceRepository repo, IEmailService email)
    {
        _repo = repo;
        _email = email;
    }

    public void CreateInvoice(Invoice invoice)
    {
        _repo.Save(invoice);
        _email.Send(invoice);
    }
}
```
🎯 Motivation:

Isolate responsibilities for easier testing.

Change one part without affecting others.

🚀 Design Patterns Related:

Strategy

Command

Decorator

⚠️ Common Mistakes:

Over-splitting (too many tiny classes)

Ignoring responsibilities for "speed"

👍 Advantages:

High cohesion

Low coupling

Easier maintenance

⚠️ Trade-offs:

More classes to manage

 How I'd Explain in an Interview:

"SRP says a class should have one reason to change. It improves maintainability by ensuring each class has a single, clear responsibility."

🧪 Reflection Questions:

What’s the single responsibility here?

Would a change to one feature affect unrelated features?
