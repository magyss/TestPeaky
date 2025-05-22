Key Features
Modular & Extensible Design: Built on abstract base classes and interfaces to support any type of selectable object.
Data Lazy-Loading: Object data is loaded on demand, not stored in memory until the user accesses it.
Input-Agnostic Architecture: Input system is completely decoupled from the data and selection logic. Supports both desktop and mobile input without relying on Unity's Input System.
Dynamic UI Management: UI windows are loaded into memory only when needed. No preloaded UI elements on the Unity scene.
Cross-Platform Support: The template is designed to work seamlessly across multiple platforms (desktop, mobile, etc.).
No External Dependencies: Fully native Unity C# codebase. No use of third-party libraries such as Zenject, UniRx, or ECS.
No Singletons: Follows clean architecture practices, avoiding singleton usage and repeated MonoBehaviour searches.

Included Examples
1. Character Selection Example
Displays a list of characters with:
Name
Level
2D avatar image
Selection can be made via UI (Canvas) or keyboard input.

2. Location Selection Example
Users can browse and select from available game locations.
Each location includes:
Name
Description
2D preview image
Scene ID

Selecting a location triggers scene loading logic.
Code Style & Guidelines
All code follows the official C# Coding Conventions.
Architecture emphasizes:
Single Responsibility: Each class has one well-defined purpose.
Open/Closed Principle: New object types can be added without modifying existing logic.

Liskov Substitution: Abstract classes and interfaces are used for safe extension.

Interface Segregation: Interfaces are small and purpose-specific.

Dependency Inversion: High-level modules depend on abstractions, not concrete implementations.
