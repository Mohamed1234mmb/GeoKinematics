using System;
using static Geodesy.Physics.Validation;
using static Geodesy.Physics.EarthMath;
namespace Geodesy.Physics;

/// <summary>
/// These are Abu al-Wafa al-Buzjani's equation for calculating sides and angles
/// </summary>
public static class AlBuzjani
{
    ///<summary>
    /// This function calculates the length of a side in a triangle given two angles and one side using the Law of Sines.
    ///</summary>
    /// <param name="angleA">The angles of the first side are known in degrees.</param>
    /// <param name="angleB">The angles of the second side are known in degrees.</param>
    /// <param name="sideB">The length of the second side is known.</param>
    /// <example>
    /// <code>
    /// double angleA = 30.0; //degrees
    /// double angleB = 45.0; //degrees
    /// double sideB = 10.0; //side length
    /// double sideA = AlBuzjani.CalculateSide(angleA , angleB , sideB);
    /// Console.WriteLine($"The length of side A is: {sideA}");
    /// </code>
    /// </example>
    /// <returns>The Length of side</returns>

    public static double CalculateSide(double angleA, double angleB, double sideB)
    {
        double angleAInRadians = angleA * DegreeToRadians;
        double angleBInRadians = angleB * DegreeToRadians;

        double sideA = (sideB * Math.Sin(angleAInRadians)) / Math.Sin(angleBInRadians);

        return Math.Round(sideA, 3);
    }

    /// <summary>
    /// This function calculates the angle of a side in a triangle given two side and one angle using the Law of Sines.
    /// </summary>
    /// <param name="sideA">The length of the first side</param>
    /// <param name="SideB">The length of the second side</param>
    /// <param name="AngleB">The angle of the second side are known in degrees</param>
    /// <example>
    /// <code>
    /// double sideA = 10.0; //side length
    /// double SideB = 15.0; //side length
    /// double AngleB = 45.0; //degrees
    /// double AngleA = AlBuzjani.CalculateAngle(sideA, SideB, AngleB);
    /// Console.WriteLine($"The angle of side A is: {AngleA}");
    /// </code>
    /// </example>
    /// <returns>The angle of the first side in degrees</returns> 
    public static double CalculateAngle(double sideA, double SideB, double AngleB)
    {
        double angleBInRadians = AngleB * DegreeToRadians;
        double sinA = (sideA * Math.Sin(angleBInRadians)) / SideB;
        double angleAInRadians = Math.Asin(sinA) / DegreeToRadians;
        return Math.Round(angleAInRadians , 3);
    }
}