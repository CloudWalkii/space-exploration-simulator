# 🚀 Space Exploration Simulator

A modular C# console application that simulates celestial tracking and spacecraft mission management. This project was built to showcase core Object-Oriented Programming (OOP) concepts, strong data encapsulation, and clean software architecture.

---

## 🛠️ Key Architectural Features

This simulator uses real-world domain modeling to demonstrate the **4 Pillars of OOP**:

* **Composition:** The `Coordinates` class handles 3D positioning ($X, Y, Z$) and is composed inside `SpaceObject`.
* **Inheritance:** Hierarchical branching from base abstractions (`SpaceObject` and `SpaceCraft`) into specialized domain classes (`Planet`, `Moon`, `Star`, `Rover`, `Satellite`).
* **Encapsulation:** Backing fields protected by property validation rules (e.g., fuel limits, positive mass checks, coordinate safety).
* **Polymorphism & Abstraction:** Abstract contracts like `PerformMission()` and `DisplayDetails()` execute dynamic runtime behaviors across collections managed by `MissionManager`.

---

## 📂 Project Structure

```text
SpaceExplorationSimulator/
├── Coordinates.cs       # 3D spatial coordinate positioning
├── SpaceObject.cs       # Abstract base class for celestial objects
│   ├── Planet.cs        # Tracks atmosphere and population
│   ├── Moon.cs          # Tracks host planet association
│   └── Star.cs          # Tracks surface temperature
├── SpaceCraft.cs        # Abstract base class for space vehicles
│   ├── Rover.cs         # Land-based rover using Terrain flags
│   └── Satellite.cs     # Orbital satellite with scan ranges
├── MissionManager.cs    # Orchestrates collection operations and fleet execution
└── Program.cs           # Console application entry point
