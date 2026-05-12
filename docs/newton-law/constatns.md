# Physics Constants

This module contains the physical constants used across Newton's laws calculations, ensuring consistency and accuracy in the physics engine.

---

## 1. Newton1 Constants (States)
Defines the numerical representation of an object's movement state.

*   **StaticState**: `0.0f` (Represents an object at rest).
*   **MovingState**: `1.0f` (Represents an object in motion).

---

## 2. Newton2 Constants (Earth & Space)
Core values used for universal gravitation and mass-based calculations.

*   **Gravitational_Constant (G)**: `6.67430e-11` (Universal gravitational constant).
*   **Earth_Mass**: `5.972e24 kg` (The mass of planet Earth).

---

## 3. Newton3 Constants (Thresholds)
Threshold values for force interactions.

*   **minimum**: `0.01f`  
    > [!IMPORTANT]
    > This is the minimum value for a force to be considered **active**. Any calculation result below this threshold is treated as negligible (zero) to prevent noise.

---

### Quick Tip
These constants are used internally by the `Newton` law classes. For example, `Newton2law` uses the `Earth_Mass` to calculate the gravity pull at different altitudes.

---
*For technical API details, visit the [Constants Reference](xref:Geodesy.Physics).*
