namespace Geodesy.Physics;

/// <summary>
///The class calculates when two things collide (whether they stick together or move away from each other).
/// </summary>
public static class Collision
{
    /// <summary>
    /// Calculates the final speed for an Inelastic Collision (where objects stick together).
    /// </summary>
    /// <param name="m1">Mass of the first object.</param>
    /// <param name="m2">Mass of the second object.</param>
    /// <param name="v1">Initial velocity of the first object.</param>
    /// <param name="v2">Initial velocity of the second object.</param>
    /// <example>
    /// <code>
    /// // Example: A 2kg object hitting a stationary 3kg object and sticking to it.
    /// double velocity = Collision.CalculateAndCrash(2f, 3f, 10f, 0f);
    /// </code>
    /// </example>
    /// <returns>The combined final velocity of both objects.</returns>
    public static double CalculateAndCrash(double m1, double m2, double v1, double v2)
    {
        // Formula: (m1*v1 + m2*v2) / (m1 + m2)
        double finalVelocity = (m1 * v1 + m2 * v2) / (m1 + m2);
        return finalVelocity;
    }

    /// <summary>
    /// Calculates the final velocity for an Elastic Collision (where objects bounce off each other).
    /// </summary>
    /// <param name="m1">Mass of the first object.</param>
    /// <param name="m2">Mass of the second object.</param>
    /// <param name="v1">Initial velocity of the first object.</param>
    /// <param name="v2">Initial velocity of the second object.</param>
    /// <example>
    /// <code>
    /// // Example: Two billiard balls hitting each other and bouncing away.
    /// var (v1Final, v2Final) = Collision.CalculateAndBounce(1f, 1f, 5f, -5f);
    /// </code>
    /// </example>
    /// <returns>A tuple containing the final velocity of object 1 and object 2.</returns>
    public static (double v1Final, double v2Final) CalculateAndBounce(double m1, double m2, double v1, double v2)
    {
        // Calculation for object 1 final speed
        double v1Final = ((m1 - m2) * v1 + (2 * m2 * v2)) / (m1 + m2);

        // Calculation for object 2 final speed
        double v2Final = ((m2 - m1) * v2 + (2 * m1 * v1)) / (m1 + m2);

        return (v1Final, v2Final);
    }
}
