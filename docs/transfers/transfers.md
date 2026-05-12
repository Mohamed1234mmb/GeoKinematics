# Transfers: Unit Conversions

This class handles unit conversion logic for distance and time, ensuring your calculations use the correct SI units.

---

## 1. Distance Conversions
Convert between Kilometers (km) and Meters (m) easily.

> [!TIP]
> **Logic:** 
> *   **Km to M**: Multiplies by 1,000.
> *   **M to Km**: Divides by 1,000.

### Examples:
```csharp
// Convert 5 kilometers to meters
double meters = Transfers.KilometersToMeters(5.0); 
Console.WriteLine(meters);
// Result: 5000.0

// Convert 2500 meters to kilometers
double km = Transfers.MetersToKilometers(2500.0);
Console.WriteLine(km);
// Result: 2.5
```

---

## 2. Time Conversions
Convert between Hours (h) and Seconds (s) for velocity and acceleration timing.

> [!TIP]
> **Logic:** 
> *   **Hours to Seconds:** Multiplies by 3,600.
> *   **Seconds to Hours:** Divides by 3,600.

### Examples:
```csharp
// Convert 2 hours to seconds
double seconds = Transfers.HoursToSeconds(2.0); 
Console.WriteLine(seconds);
// Result: 7200.0

// Convert 1800 seconds to hours
double hours = Transfers.SecondsToHours(1800.0); 
Console.WriteLine(hours);
// Result: 0.5
```
