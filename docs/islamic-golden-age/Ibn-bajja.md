### Ibn-Bajja (Muhammed Ibn Bajja al-Aswad)

This class calculate how fast something moves by subtracting the (drag) from the push


## CalculateVelocity
Computes the final speed by subtracting the overhead (resistance) from the input power.

```csharp

// example : calculate the velocity of a car at 30 m/s
float CarPush  = 30.0f;
float Air = 1.225f;     
float velocity = IbnBajja.CalculateVelocity(CarPush, Air);
Console.WriteLine("the speed of the car is: " + velocity);
```
