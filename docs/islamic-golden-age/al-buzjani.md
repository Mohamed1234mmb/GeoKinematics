### Al-buzjani : (Law of Sines and Law of Cosines) 

// These are Abu al-Wafa al-Buzjani's equation for calculating missing sides and angles


## 1. CalculateSide

This funtion to calculate missing side of the triangle


```csharp

// example : finding the length of road back home

double knownRoad = 10.0;
double knownHouseAngle = 15.0;
double targetAngle = 45.0;

double homeRoad = AlBuzjani.CalculateSide(knownRoad, knownHouseAngle, targetAngle);
Console.WriteLine("the shotetst road to home is: " + homeRoad);

```
## 2. CalculateAngle
// This function is used to calculate missing angle of the triangle. Think of it as :
"How much do i need to turn to face the road back home?"

```csharp

// example : funding your way back home;

double roadIAmOn = 10.0;
double roadToHome = 15.0;
double angleToHome = 45.0;

double myTurnHome  = AlBuzjani.CalculateAngle(roadIAmOn, roadToHome, angleToHome);
Console.WriteLine("the road to home is: " + angleToHomeInDegrees);

``` 

> [!TIP]
> **Logic:** 
> *   if you wnat to calculate the angle in degrees
> like (45) but you want need to use it in radians
> you can use `Transfers.DegreesToRadians(45);

```csharp
double radians = EarthMath.DegreesToRadians(45);
Console.WriteLine(radians);
```
---
*For more information API visit [AlBuzjani Reference](xref:Geodesy.Physics.AlBuzjani)* 
---



