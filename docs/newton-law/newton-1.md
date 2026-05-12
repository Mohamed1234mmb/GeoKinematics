# Newton1Law: Law of Inertia

This class is all about telling the state of an object which does not move from its place (Static State).

---

## 1. ZeroCheck
This is used to check the state of an object which does not move from its place. 

> [!TIP]
> **Logic:**
> *   If they have the **(Same)** state, the result is **False** (No movement).
> *   If they have **(Different)** states, the result is **True** (Movement detected).

### Examples:
```csharp
/// example (1) When the book and pencil the condition is the (same):
bool book = Newton1.Constants.MovingState; // 1.0f
bool pencil = Newton1.Constants.MovingState; // 1.0f

// Check if there is a diffrenece in their condition or not ?
bool IsMoving = Newton1Law.ZeroCheck(book , pencil);
Console.WriteLine(\$" {IsMoving} ");
// Result : False (No moving because both objects are still);


/// example (2) Object Even if they are both "Off" or "False", as long as they match, there is no change.: 
bool book2 = Newton1.Constants.StaticState; // 0.0f
bool pencil2 = Newton1.Constants.StaticState; // 0.0f

bool IsMoving2 = Newton1Law.ZeroCheck(book2 , pencil2);
Console.WriteLine(\$" {IsMoving2} ");
// Result : False (No moving because both objects are still);


/// example (3) When the book and pencil the condition is the (different):
bool book3 = Newton1.Constants.StaticState; // 0.0f
bool pencil3 = Newton1.Constants.MovingState; // 1.0f

bool IsMoving3 = Newton1Law.ZeroCheck(book3 , pencil3);
Console.WriteLine(\$" {IsMoving3} ");
// Result : True (Moving because both objects are not still);
```

---

## 2. IsStatic
This is used to know the representation of force when it is in a static state.

> [!IMPORTANT]
> **Returns:** 0.0f (This means the push (force) is in a static state).

### Example:
```csharp
// The wall when it is in a static state
float wall = Newton1Law.IsStatic();
Console.WriteLine(\$" {wall} ");
// Result : 0.0f (No moving because the wall is still);
```

---
*For technical API details, visit the [Newton1Law Reference](xref:Geodesy.Physics.Newton1Law).*
---
