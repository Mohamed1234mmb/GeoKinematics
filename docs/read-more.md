# GeoKinematics

  it is a C# library that i designed using . Net 9.0. it performs calculations for (Earth center) models from Al-biruni Al-buzjani, Ibn-bajja and Newton (etc).
---

### Documentation

I tried to design the library in a simpler and clearer way:

* **Geodesy & Earth Models:** Earth Mathematical Models, Haversine Distance Formula, Earth Radius Calculations.

* **Islamic Golden Age Scholars:** Al-Biruni (Earth Radius mountain method), Al-Buzjani (Spherical Trigonometry), Ibn-Bajja (Early Dynamics & Velocity).

* **Kinematics & Motion:** Current Speed, Speed Limits, Acceleration Engine, Power House, Work Done, Collision Dynamics.

* **Newtonian Physics:** Fundamental laws of motion implemented for .NET (Inertia, Force, Action/Reaction).
---

 ### Some Examples

1. Calculate the earth radius by (Al-biruni Method)

```csharp
// example : meashuring earth from the iconic tower (in Egypt's New Administrative Capital)

double IconicTowerHeight = 385.8; 
double HorizonAngle = 0.629;

double radius = AlBiruni.CalculateEarthRadius(IconicTowerHeight, HorizonAngle);

Console.WriteLine(radius);
```

2. Newton's Second Law (Force)

```csharp
// example : calculate the total force needed to move an object

float carWeight = 1000f;
float acceleration = 2.5f;

float force = Newton.CalculatePush(carWeight, acceleration);
Console.WriteLine(force);
```
3. Haversine Distance (Geodesy)

```csharp
// example : calculate the distance between two points

double lat1 = 30.0444;
double lon1 = 31.2357;
double lat2 = 55.7558;
double lon2 = 37.6173;

double radius = RadiusEarthCenter.AverageRadius();

double distance = HaversineFormula.CalculateDistance(lat1 , lon1 , lat2 , lon2 , radius);
Console.WriteLine(distance);
```








