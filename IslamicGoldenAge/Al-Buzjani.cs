using System;
using static Geodesy.Physics.Validation;
using static Geodesy.Physics.GeodeticConstants;
namespace Geodesy.Physics;


public static class AlBuzjani
{
    public static double CalculateSide(double angleA, double angleB, double sideB)
    {
        double angleA_Radians = angleA * Degree_To_Radian;
        double angleB_Radians = angleB * Degree_To_Radian;
        return (sideB * Math.Sin(angleA_Radians)) / Math.Sin(angleB_Radians);
    }

    public static double CalculateAngle(double sideA, double sideB, double angleB)
    {
        double angleB_Radians = angleB * Degree_To_Radian;
        double sinA = (sideA * Math.Sin(angleB_Radians)) / sideB;
        return Math.Asin(sinA) / Degree_To_Radian;
    }
}