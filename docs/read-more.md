# GeoKinematics

  it is a C# library that i designed using . Net 9.0. it performs calculations for (Earth center) models from Al-biruni Al-buzjani, Ibn-bajja and Newton (etc).
---

### Documentation

I tried to design the library in a simpler and clearer way:

### Geodesy & Earth Models
- [Earth Mathematical Models](geodesy/earth-math.md)
- [Haversine Distance Formula](geodesy/haversine-formula.md)
- [Earth Radius Calculations](geodesy/radius-earth-center.md)

---

###  Islamic Golden Age Scholars

- [Al-Biruni: Earth Radius mountain method](islamic-golden-age/al-biruni.md)

- [Al-Buzjani: Spherical Trigonometry](islamic-golden-age/al-buzjani.md)

- [Ibn-Bajja: Early Dynamics & Velocity](islamic-golden-age/Ibn-bajja.md)

---

###  Kinematics & Motion

- [Current Speed (Real-time)](kinematics/speed-right-now.md)

- [Speed Limits & Rules](kinematics/speed-limits.md)

- [Acceleration & Deceleration Engine](kinematics/acceleration.md)

- [Power House (Energy Storage)](kinematics/power-house.md)

- [Work Done & Potential Energy](kinematics/work-done.md)

- [Collision Dynamics (Elastic/Inelastic)](kinematics/collision.md)

- [Time Modules (Seconds)](kinematics/second.md)

---

###  Newtonian Physics
The fundamental laws of motion implemented for .NET.
- [Physics Constants](newton-law/constatns.md)

- [Newton's First Law (Inertia)](newton-law/newton-1.md)

- [Newton's Second Law (Force)](newton-law/newton-2.md)

- [Newton's Third Law (Action/Reaction)](newton-law/newton-3.md)

### Transfers 
- [transfers](transfers/transfers.md)

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
**[Read My Story here](history.md)**

>[LINK DOWNLOAD]
**[Donwload on Nuget](https://www.nuget.org/packages/GeoKinematics)**

> [GITHUB LINK]
**[Read more on GitHub](https://github.com/Mohamed1234mmb/GeoKinematics)**









