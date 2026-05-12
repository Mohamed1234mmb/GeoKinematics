using System;
using static Geodesy.Physics.EarthMath;

namespace Geodesy.Physics;
/// <summary>Al-Biruni's method for calculating the Earth's radius based on the observer's height and the angle to the horizon.</summary>
public static class AlBiruni
{

    /// <summary>This funtion to calculate radius of the Earth to height and horizon angle</summary>
    /// <param name="height">Summit height above sea level </param>
    /// <param name="horizonAngleDegrees">It is the angle at which your eye tilts from the horizontal line in order to see the farthest point on the horizon.</param>
    /// <example>
    /// <code>
    /// double IconicTowerHeight = 385.8; // height of the iconic tower in Egypt's New Administrative Capital in meters;
    /// double HorizonAngle = 0.629; // angle to the horizon in degrees;
    /// double EarthRadius = AlBiruni.CalculateEarthRadius(IconicTowerHeight, HorizonAngle);
    /// Console.WriteLine($"The radius of the Earth {EarthRadius} meters");
    /// </code>
    /// </example>
    /// <returns>returns the radius of the Earth Al-Biruni</returns>
    public static double CalculateEarthRadius(double height, double horizonAngleDegrees)
    {
        double theta = horizonAngleDegrees * DegreeToRadians;
        double cos = Math.Cos(theta);
        double radius = (height * cos) / (1 - cos);
        return Math.Round(radius, 3);
    }
}
