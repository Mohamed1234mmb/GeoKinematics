using System;

namespace Geodesy.Physics;

/// <summary>
/// This class calculates the "Work Done" and the energy spent to move things.
/// </summary>
public class WorkDone
{
    /// <summary>
    /// Calculates how much work (effort) was done to move an object over a distance.
    /// </summary>
    /// <param name="calculateForce">The push or pull force applied.</param>
    /// <param name="distance">How far the object moved.</param>
    /// <returns>Total Work Done in Joules.</returns>
    public static float CalculateWorkDone(float calculateForce, float distance) => calculateForce * distance;


}
