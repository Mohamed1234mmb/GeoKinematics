# Newton3Law: Action and Reaction

This class handles the interaction between two opposing pushes (forces), based on the principle of action and reaction.

## Overview
According to Newton's Third Law, for every action, there is an equal and opposite reaction. This class calculates the difference between the push you exerted and the push that will move against you.

---

## 1. Reverse Push
Here we ensure the value is inverted to get the reverse push (force).

**Example: Tennis Ball Hit**
When you hit a ball, it exerts a "back push" on the racket.

```csharp
// You hit the ball with 10.0 Newtons
float reverse = Newton3Law.ReversePush(10.0f);

// The output shows the reversed push
Console.WriteLine(reverse); 
// Result: -10.0f
```

---

## 2. Total Push
Here we calculate the total pushes (forces) of two opposing movements.

**Example: Combined Car Push**
Imagine two cars pushing an object. This method calculates the net result while checking if it's active.

```csharp
// car1: your push | car2: push against you
float car1 = 10.0f;
float car2 = 5.0f;

float total = Newton3Law.TotalPush(car1, car2);

Console.WriteLine(total); 
// Result: 15.0f
```

---

###  Quick Tips

> [!IMPORTANT]
> **Minimum Threshold:**
> This value was set so that we ignore very small values and avoid calculation errors. The library ensures the total push is high enough to be considered active.

> [!TIP]
> **Logic:**
> In `ReversePush`, if the input is zero, it returns zero; otherwise, it flips the sign to provide the perfect reaction force.


