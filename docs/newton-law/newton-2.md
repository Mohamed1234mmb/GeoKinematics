# Newton2law: Movement Physics

This class handles the core movement physics including **Push**, **Air Resistance**, and **Gravity**. It is designed for high-performance calculations with built-in safety.

---

## 1. Calculate Push
Calculate the force needed to move an object based on its mass and acceleration (\(F = m \cdot a\)).

```csharp
// How much force for a 1000kg car at 2.5 acceleration?
float force = Newton2Law.CalculatePush(1000f, 2.5f); 
```

## 2. Calculate Air Resistance
Calculate how much the air "fights" against the object (Aerodynamic Drag).

```csharp
// Air drag for a car moving at 30 m/s
float drag = Newton2Law.CalculateAirResistance(1.225f, 0.3f, 2.2f, 30.0);
```

## 3. Gravity Push
Calculate Earth's pull on a specific mass based on its distance from the center.

```csharp
// Gravity pull on 1200kg at Earth's surface (6371km)
float pull = Newton2Law.CalculateGravityPush(1200f, 6371.0);
```

## 4. Gravity Constant
Get the gravity acceleration value (\(g\)) for a specific distance.

```csharp
// Returns ~9.81 at 6371km
double g = Newton2Law.CalculateGravity(6371.0);
```

---

### Quick Tips

> [!IMPORTANT]
> **Safety:** To prevent application crashes, all invalid inputs (like negative distance or mass) return **0.0**.

> [!TIP]
> **Units:** All distances should be provided in **Kilometers (KM)**. The library handles the conversion to meters internally.






