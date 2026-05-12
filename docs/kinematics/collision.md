# Collision class
The class calculates when two things collide (whether they stick together or move away from each other).


## CalculateAndCrash
Calculates the final speed for an Inelastic Collision (where objects crash together).

```csharp
// example: A 3 tons car hitting a stationary 2 tons car and sticking to it.

double car1Weight = 3.0;
double car2Weight = 2.0;
double car1Speed = 20.0; // he was going 20 m/s
double car2Speed = 0.0; // he was parking 0 m/s

double finalVelocity = Collision.CalculateAndCrash(car1Weight, car2Weight, car1Speed, car2Speed);
// result : 12 m/s


```
## CalculateAndBounce
Calculates the final velocity for an Elastic Collision (where objects bounce off each other).

```csharp

// example: Two billiard balls of the same mass hitting each other.
// Ball 1 is moving, and Ball 2 is stationary.
double ball1Mass = 0.17; // 170 grams
double ball2Mass = 0.17; 
double ball1Velocity = 5.0; // Moving at 5 m/s
double ball2Velocity = 0.0; // Stationary

// In this case, Ball 1 will stop (0) and Ball 2 will take all the speed (5).
var (v1Final, v2Final) = Collision.CalculateAndBounce(ball1Mass, ball2Mass, ball1Velocity, ball2Velocity);
```
