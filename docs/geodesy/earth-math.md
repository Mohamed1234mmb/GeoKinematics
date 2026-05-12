### EarthMath Class

## NameSpace : Geodesy.Physics.EarthMath

 A set of fixed numbers used to calculate distance to Earth


> [!NOTE]
> **Logic** 
> * Constantsto use for calculating distance between places on Earth map

## 1.DegreeToRadians

```csharp

double degree = 180.0;

// we multiply by the constant to convert it to radians

double radians = degree * EarthMath;

Console.WriteLine(radians);
```
## 2.MiddleRadius

The distance between the center of the Earth and a specific point on its surface.

```csharp

double earthRadius = Earth.MiddleRadius;

Console.WriteLine(earthRadius);
```

## 3.PolarRadius

 distance between the center of the Earth and the two poles (the North pole and the South pole)

```csharp

double earthRadius = Earth.PolarRadius;

Console.WriteLine(earthRadius);

```
