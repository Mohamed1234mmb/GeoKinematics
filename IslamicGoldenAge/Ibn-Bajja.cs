using System;

namespace Geodesy.Physics;

/// <summary>
/// This class calculate how fast something moves by subtracting the (drag) from the push
/// </summary>
public static class IbnBajja
{
    /// <summary> 
    /// Computes the final speed by subtracting the overhead (resistance) from the input power.
    /// </summary>
    /// <param name="push">The push applied to the object.</param>
    /// <param name="resistance">The environmental drag or friction.</param>
    /// <returns>Final speed (Always non-negative).</returns>
    public static double CalculateVelocity(double push, double resistance)
    {
        double netResult = push - resistance;
        return netResult > 0 ? netResult : 0.0;

    }
}
