ContactManager is a Windows Forms application for managing phone contacts, designed to demonstrate the use of classic **Object-Oriented Design Patterns** such as **Factory**, **Builder**, **Singleton**, and **Prototype**.  
The project is implemented in **C#** using .NET Framework.

---

##  Project Goals

- Create a simple and intuitive contact management interface
- Practice real-world application of design patterns in C#
- Showcase software architecture skills and clean code practices

---

##  Key Features

- Add / edit / delete contacts
- Store contact information: name, phone number, email, category
- Contacts are managed in-memory (for demo purposes)
- Extensible architecture using design patterns
- Simple and clean Windows Forms GUI

---

##  Design Patterns Used

| Pattern     | Purpose                                                                 |
|-------------|-------------------------------------------------------------------------|
| **Factory** | For dynamic creation of different contact types                         |
| **Builder** | To assemble complex Contact objects step by step                        |
| **Singleton** | Ensures one shared instance of the contact manager logic              |
| **Prototype** | Enables cloning of contact objects for reuse or templating            |

---

##  Project Structure

ContactManager/
│
├── Forms/ # UI Windows Forms (Main screen, Add/Edit Contact)
├── Models/ # Core data models (Contact, Categories, etc.)
├── Patterns/ # Implementation of Factory, Builder, etc.
├── Program.cs # Entry point of the application
├── ContactManager.sln # Visual Studio solution file

yaml
Copy
Edit

---

## 🖥 How to Run

> Requirements:
- Visual Studio (2022 or newer)
- .NET Framework (e.g., 4.8)

> Steps:
1. Clone this repo:
```bash
git clone https://github.com/MiryamMann/ContactManager.git
Open ContactManager.sln in Visual Studio

Click ▶ Run (or press F5)

 TODO: Tests
Unit tests for business logic are planned for a future version.
Suggestions and PRs are welcome!

