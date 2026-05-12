using System;
using static Geodesy.Physics.Validation;

namespace Geodesy.Physics;

/// <summary>
/// This class helps you find out how much an object is speeding up over time.
/// </summary>
public class Acceleration
{
    /// <summary>
    /// It is what determines whether your speed is accelerating or decelerating.
    /// </summary>
    /// <param name="finalSpeed">The change in speed (Final speed minus).</param>
    /// <param name="initialSpeed">The change in speed (initial speed minus).</param>
    /// <param name="totalTime">The total time spent to reach that speed change.</param>
    /// <example>
    /// <code>
    /// // If a car speeds up by 30 m/s in 5 seconds:
    /// double acc = Acceleration.CalculateAcceleration(30.0, 5.0);
    /// Console.WriteLine($"The acceleration is: {acc} m/s²");
    /// </code>
    /// </example>
    /// <returns>The acceleration value. Returns 0.0 if the input is invalid or time is zero.</returns>
    public static double CalculateAcceleration(double finalSpeed, double initialSpeed, double totalTime)
    {
        // Simple math: Acceleration = Speed Change / Time
        
        double changeInSpeed = deltav(finalSpeed, initialSpeed);
        double acceleration = changeInSpeed / totalTime;
        // Safety check to make sure the result is a valid number
        return isValidInput(acceleration) ? acceleration : 0.0;
    }

    private static double deltav(double finalSpeed , double initialSpeed)
    {
        return finalSpeed - initialSpeed;
    }

}
