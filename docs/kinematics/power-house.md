# PowerHouse
This class helps you understand energy: how it’s stored, how it moves, and how much fuel you need to create it.

### CalculateStoredEnergy
Calculates the energy stored in an object because of its height.

```csharp
// example: A car at a high place with gravity pulling it
float gravity = 9.8f;
float height = 10f;

float stored = PowerHouse.CalculateStoredEnergy(gravity, height);
Console.WriteLine($"Stored Energy: {stored} Joules");
```

### CalculateMovementEnergy
Calculates the energy an object has while it's moving.

```csharp
// example : A car moving at a certain speed
float mass = 1000f;
float speed = 30f;

float movement = PowerHouse.CalculateMovementEnergy(mass, speed);
Console.WriteLine($"Movement Energy: {movement} Joules");
```
### Estimate Fuel Used

### EstimateFuelUsed
Estimates how much fuel you need to get a specific amount of energy.
 
```csharp
// example : Suppsed the car has 100,000 liters of fuel

double energyNeeded = 100000; // Joules
double fuelPower = 34.2e6 // Energy per liter
double fuelUsed = PowerHouse.EstimateFuelUsed(energyNeeded , fuelPower);
```
