# GeoKinematics

it is a C# library that i designed using .Net 9.0. it performs calculations for (Earth center) models from Al-biruni Al-buzjani, Ibn-bajja and Newton (etc).
---

### Documentation

I tried to design the library in a simpler and clearer way:

### Geodesy & Earth Models
- [Earth Mathematical Models](https://github.com)

- [Haversine Distance Formula](https://github.com)
- [Earth Radius Calculations](https://github.com)

---

### Islamic Golden Age Scholars

- [Al-Biruni: Earth Radius mountain method](https://github.com)

- [Al-Buzjani: Spherical Trigonometry](https://github.com)

- [Ibn-Bajja: Early Dynamics & Velocity](https://github.com)

---

### Kinematics & Motion

- [Current Speed (Real-time)](https://github.com)

- [Speed Limits & Rules](https://github.com)

- [Acceleration & Deceleration Engine](https://github.com)

- [Power House (Energy Storage)](https://github.com)

- [Work Done & Potential Energy](https://github.com)

- [Collision Dynamics (Elastic/Inelastic)](https://github.com)

- [Time Modules (Seconds)](https://github.com)

---

### Newtonian Physics
The fundamental laws of motion implemented for .NET.
- [Physics Constants](https://github.com)

- [Newton's First Law (Inertia)](https://github.com)

- [Newton's Second Law (Force)](https://github.com)

- [Newton's Third Law (Action/Reaction)](https://github.com)

### Transfers 
- [transfers](https://github.com)

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

double force = Newton.CalculatePush(1000f, 2.5f);
Console.WriteLine(force);
```
3. Haversine Distance (Geodesy)

```csharp
// example : calculate the distance between two points

double radius = RadiusEarthCenter.AverageRadius();

double distance = Haversine.CalculateDistance(30.0444 , 31.2357 , 55.7558 , 37.6173 , radius);
Console.WriteLine(distance);
```
---

Target Stack:
.NET 6.0, 8.0, 9.0 (High Performance)
.NET Standard 2.0 (Maximum Compatibility)
Platforms: Windows, Linux, macOS, Android, iOS (Cross-Platform)
Language: C# 13.0

---
### Links

**geodesy** : 
> [MY HISTORY]
**[Read My Story here](https://github.com)**

>[LINK DOWNLOAD]
**[Donwload on Nuget](https://www.nuget.org/packages/GeoKinematics)**

> [GITHUB LINK]
**[Read more on GitHub](https://github.com/Mohamed1234mmb/GeoKinematics)**
