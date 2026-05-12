# SpeedLimits
 The maximum speed that the body can reach and cannot exceed.


## CalculateMaxSpeed

Calculates the Max Speed an object can reach based on its power and the environment.

```csharp
example : A racing car moved quickly unit it reached in maximum speed of 200 km/h

double push = 200.0;
double airWeight = 1.225; // standard air weight
double smoothness = 0.5; // standard air smoothness
double bodySize = 0.5; // standard body size

double maxSpeed = SpeedLimits.CalculateMaxSpeed(push, airWeight, smoothness, bodySize);
Console.WriteLine(maxSpeed);
```
