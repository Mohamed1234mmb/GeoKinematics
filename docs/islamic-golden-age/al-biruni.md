# Al-biruni : (Radius of the Earth on the mounain)

Al-Biruni's method for calculating the Earth's radius based on the observer's height and the angle to the horizon.

## CalculateEarthRadius

This funtion to calculate radius of the Earth to height and horizon angle


```csharp
// example : meashuring earth from the iconic tower (in Egypt's New Administrative Capital)

     double IconicTowerHeight = 385.8; 
     double HorizonAngle = 0.629; 

     double EarthRadius = AlBiruni.CalculateEarthRadius(IconicTowerHeight, HorizonAngle);
     Console.WriteLine($"The radius of the Earth {EarthRadius} meters");
```
---

> [!TIP]
> **Logic:** 
> *   if you wnat to calculate the height in meters
> like (385.8m) but you want need to use it in km
> you can use `Transfers.MetersToKilometers(385.8);

---

```csharp

double kmHight = Transfers.MetersToKilometers(385.8);

```
