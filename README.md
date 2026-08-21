# 🎨 MidadStore

A demo e-commerce web app for selling art supplies (paints, brushes, sketchbooks & canvases), built with **ASP.NET Core MVC**.

> This project was built as a hands-on assignment for a **Tuwaiq Academy programming bootcamp**, applying the fundamentals of the MVC pattern in building web applications with C# and ASP.NET Core.

---

## 📖 Overview

The site lets users browse the store's different categories (Paints, Brushes, Sketchbooks), then view the products belonging to each category, with an "Add to Cart" action (simulated via an interactive alert).

## ✨ Features

- 🖼️ Home page displaying store categories as interactive circular cards.
- 🗂️ Product listing filtered by the selected category.
- 🛒 "Add to Cart" button with a confirmation popup powered by SweetAlert2.
- 🎨 Arabic (RTL) UI with a custom color scheme and visual identity.
- ⚙️ Project structure following the **MVC** pattern (Model - View - Controller).

## 🛠️ Tech Stack

| Technology | Purpose |
|---|---|
| ASP.NET Core MVC (.NET 10) | Core application framework |
| C# | Programming language |
| Razor Views (`.cshtml`) | Building the UI |
| Bootstrap | Layout and styling |
| Bootstrap Icons | Icons |
| SweetAlert2 | Interactive alerts/notifications |

## 📁 Project Structure

```
MidadStore/
├── Controllers/
│   └── HomeController.cs      # Logic for categories & products
├── Models/
│   └── ErrorViewModel.cs
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml       # Home page (categories)
│   │   ├── Products.cshtml    # Category products page
│   │   └── Privacy.cshtml
│   └── Shared/                # Shared layout
├── wwwroot/                    # Static assets (images, css, libraries)
└── Program.cs                  # Application entry point
```

## 🚀 Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (a version compatible with `net10.0`)

### Run locally

```bash
# 1. Clone the repository
git clone https://github.com/ili1iml/MidadStore-ASP.NET-Core.git

# 2. Navigate into the project folder
cd MidadStore-ASP.NET-Core

# 3. Restore dependencies
dotnet restore

# 4. Run the project
dotnet run
```

Once running, open the URL shown in the terminal (usually something like `https://localhost:xxxx`).

## 🔮 Possible Future Improvements

- Connect products to a real database (Entity Framework Core) instead of static in-memory data.
- Implement a functional shopping cart that actually persists added items.
- Add user authentication and an account page.
- Add a dedicated product details page.

## 👤 Author's Note

This project was built as an assignment for Tuwaiq Academy's programming bootcamp.

---
