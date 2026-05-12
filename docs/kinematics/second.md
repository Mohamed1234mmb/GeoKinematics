### Second 
 This class helps you find out "How long" a trip will take.


### CalculateTime
Calculates the total travel time in seconds.


```csharp

// a car travels 100 meters in 10 seconds
double distance = 100.0;
double speed = 10.0;

float time = Second.CalculateTime(distance, speed);
Console.WriteLine(time);
```

>[!TIP]
> **Logic**
> if you want converts raw secnonds into a readable clock format (00:00:00) , use the `Seconds.FormatTime` method

```csharp
double totalSeconds = 3600.0;
string formattedTime = Seconds.FormatTime(totalSeconds);
Console.WriteLine(formattedTime);
```

