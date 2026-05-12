# WorkDone
This class calculates the effort (Work) and the stored energy when you move or lift things.

### CalculateWorkDone
Finds out how much "Work" was done by pushing something over a distance.

```csharp
// example: Pushing a box with 10 units of force for 5 meters

float work = WorkDone.CalculateWorkDone(10.0f, 5.0f);
Console.WriteLine($"You did {work} Joules of work!");
```

