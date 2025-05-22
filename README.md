# Unity Selectable Object Framework

## 📌 Overview

A reusable Unity template designed for selecting various types of objects (characters, inventory items, locations, etc.) across multiple projects. The architecture is built with **SOLID principles** and **object-oriented programming (OOP)**, ensuring high maintainability and reusability.

---

## ✅ Features

- 🔧 **Modular and Extensible** — Based on abstract classes and interfaces, easily extendable.
- 💾 **Lazy Data Loading** — Object data is not loaded into memory until explicitly requested.
- 🎮 **Input-Agnostic** — Works with both desktop and mobile platforms without relying on Unity’s Input System.
- 🪄 **Dynamic UI Loading** — UI elements are instantiated only when needed. No preloaded UI objects in the scene.
- 📱 **Cross-Platform Ready** — Designed to work on mobile, desktop, and other Unity-supported platforms.
- 📦 **Zero Dependencies** — No Zenject, UniRx, ECS, or similar frameworks.
- 🚫 **No Singletons or FindObjectOfType** — Clean dependency management without global access or performance-costly operations.

---

## 🧩 Included Examples

### 🧍 Character Selection
- Displays:
  - Name
  - Level
  - 2D Avatar
- Selection via:
  - UI (Canvas)
  - Keyboard input

### 🌍 Location Selection
- Displays:
  - Location Name
  - Description
  - 2D Preview Image
  - Scene ID
- Loads the selected scene upon user selection

---

## 🧠 Architecture Principles

- **Single Responsibility Principle** – Each class has one clear purpose.
- **Open/Closed Principle** – Easy to extend, no need to modify core logic.
- **Liskov Substitution Principle** – Safe interface and class replacements.
- **Interface Segregation Principle** – Small, focused interfaces.
- **Dependency Inversion Principle** – High-level modules depend on abstractions.
