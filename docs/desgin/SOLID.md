# 🧭 SOLID Principles Overview

> The SOLID principles are a set of five object-oriented design guidelines that help create **maintainable**, **flexible**, and **understandable** software.

They encourage developers to write code that is:

✅ Easy to understand  
✅ Easy to maintain  
✅ Easy to extend  
✅ Easy to test

---

## 📜 The SOLID Acronym

- **S** — [Single Responsibility Principle (SRP)](SRP.md)  
- **O** — Open/Closed Principle (OCP)  
- **L** — Liskov Substitution Principle (LSP)  
- **I** — Interface Segregation Principle (ISP)  
- **D** — Dependency Inversion Principle (DIP)

---

## 🔎 1️⃣ Single Responsibility Principle (SRP)

> *A class should have only one reason to change.*

✅ Each class should have one clear responsibility.  
✅ Keeps logic focused and cohesive.  
✅ Reduces unintended side effects.

➡️ [Read the full SRP guide](SRP.md)

---

## 🔎 2️⃣ Open/Closed Principle (OCP)

> *Software entities should be open for extension, but closed for modification.*

✅ You can add new behavior without changing existing code.  
✅ Use abstractions (interfaces, inheritance, composition).  
✅ Reduces the risk of breaking existing features when adding new ones.

**Example:**  
- Adding new shapes to a graphics system by creating new classes that implement a common interface, without changing existing code.

---

## 🔎 3️⃣ Liskov Substitution Principle (LSP)

> *Subtypes must be substitutable for their base types.*

✅ Derived classes should extend the base class without changing its behavior.  
✅ Clients using the base type shouldn’t know or care about the subtype.  
✅ Violations often appear as overridden methods that throw or behave unexpectedly.

**Example:**  
- A Square subclass of Rectangle that breaks expectations when changing width/height separately.

---

## 🔎 4️⃣ Interface Segregation Principle (ISP)

> *Clients should not be forced to depend on interfaces they do not use.*

✅ Favor small, specific interfaces over large, general-purpose ones.  
✅ Reduces coupling and improves flexibility.  
✅ Keeps implementations clean and focused.

**Example:**  
- Splitting a fat `Machine` interface with `print()`, `scan()`, `fax()` into separate `Printer`, `Scanner`, `Fax` interfaces.

---

## 🔎 5️⃣ Dependency Inversion Principle (DIP)

> *High-level modules should not depend on low-level modules. Both should depend on abstractions.*

✅ Depend on interfaces, not concrete implementations.  
✅ Allows easier swapping of components (e.g., databases, services).  
✅ Improves testability via dependency injection.

**Example:**  
- Service classes depend on repositories via interfaces, allowing easy mocking in unit tests.

---

## ✅ Why Use SOLID?

By following SOLID principles, you can:

- Build flexible, adaptable systems.  
- Avoid monolithic, hard-to-maintain "God classes."  
- Make your code easier to test and understand.  
- Reduce the cost and risk of change.  

---

## ✅ Recommended Reading

- Robert C. Martin, *Clean Code*  
- Robert C. Martin, *Clean Architecture*  
- [Wikipedia: SOLID](https://en.wikipedia.org/wiki/SOLID)  

---

## ✅ Related Docs in This Repository

- [Single Responsibility Principle (SRP)](SRP.md)
- Coding Standards *(coming soon)*
- Architecture Overview *(coming soon)*

---
