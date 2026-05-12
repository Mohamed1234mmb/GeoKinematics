### Geodesy (RadiusEarthCenter)

 This class helps you find the distance from the Earth's center to its surface.


## At
Use this if you want calculate the raidus while "stand in place " at a specific location

```csharp

double latitude = 30.0444; // Cairo

double radius = RadiusEarthCenter.At(latitude);

Console.WriteLine(radius);

```

## BetweenLatitude
Use this if you want calculate the raidus while "stand in place " at a specific location

```csharp

double latitude1 = 30.0444; // Cairo 
double latitude2 = 55.7558; // Moscow

double radius = RadiusEarthCenter.BetweenLatitude(latitude1, latitude2);
 
Console.WriteLine(radius);
```

## AverageRadius
Gets the standard average radius of the entire Earth (almost: 6371 km).

```csharp
double radius = RadiusEarthCenter.AverageRadius();
Console.WriteLine(radius);
```
---
*For more details , see [RadiusEarthCenter](xref:Geodesy.RadiusEarthCenter)*
---