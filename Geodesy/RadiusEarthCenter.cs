using System;
using static Geodesy.Physics.EarthMath;

namespace Geodesy.Physics;

/// <summary>
/// This class helps you find the distance from the Earth's center to its surface.
/// </summary>
public static class RadiusEarthCenter
{
    /// <summary>
    /// Use this if you want calculate the raidus while "stand in place " at a specific location
    /// </summary>
    /// <param name="Latitude">The location's latitude in decimal degrees.</param>
    /// <example>
    /// <code>
    /// double lat = 30.0444; // Cairo
    /// double radius = RadiusEarthCenter.At(lat);
    /// Console.WriteLine(radius);
    /// </code>
    /// </example>
    /// <returns>The radius at this specific point in kilometers.</returns> 
    public static double At(double Latitude)
    {
        double Radian = Latitude * DegreeToRadians;

        double Apower2 = MiddleRadius * MiddleRadius * MiddleRadius * MiddleRadius;
        double Bpower2 = PolarRadius * PolarRadius * PolarRadius * PolarRadius;

        double cos = Math.Cos(Radian);
        double sin = Math.Sin(Radian);

        double numerator = (Apower2 * cos * cos) + (Bpower2 * sin * sin);
        double denominator = (MiddleRadius * MiddleRadius * cos * cos) + (PolarRadius * PolarRadius * sin * sin);

        return Math.Round(Math.Sqrt(numerator / denominator), 3);
    }

    /// <summary>
    /// Calculates the average radius between two different locations.
    /// </summary>
    /// <param name="lat1">The latitude of the first point.</param>
    /// <param name="lat2">The latitude of the second point.</param>
    /// <example>
    /// <code>
    /// double r = RadiusEarthCenter.BetweenLatitude(30.0, 55.0);
    /// </code>
    /// </example>
    /// <returns>The average radius between the two points in kilometers.</returns>
    public static double BetweenLatitude(double lat1, double lat2)
    {
        return Math.Round((At(lat1) + At(lat2)) * 0.5, 3);
    }

    /// <summary>
    /// Gets the standard average radius of the entire Earth (almost: 6371 km).
    /// </summary>
    /// <example>
    /// <code>
    /// double globalRadius = RadiusEarthCenter.AverageRadius();
    /// Console.WriteLine(globalRadius);
    /// </code>
    /// </example>
    /// <returns>The global mean radius in kilometers (approx. 6371 km).</returns>
    public static double AverageRadius()
    {
        return Math.Round((2 * MiddleRadius + PolarRadius) * 0.3333333333333333, 3);
    }
}
