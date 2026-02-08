// Claculating the Earth's geocentric radius
using System;
using static Geodesy.Physics.GeodeticConstants;
namespace Geodesy.Physics;
public static class EarthGeocentricRadius
{
    public static double GetRadius(double Latitude_Radians)
    {
        double Radian = Latitude_Radians * Degree_To_Radian;

        double a_power_2 = Equatorial_Radius * Equatorial_Radius;
        double b_power_2 = Polar_Radius * Polar_Radius;

        double cos = Math.Cos(Radian);
        double sin = Math.Sin(Radian);

        double numerator = Math.Pow(a_power_2 * cos, 2) + Math.Pow(b_power_2 * sin, 2);
        double denominator = Math.Pow(Equatorial_Radius * cos, 2) + Math.Pow(Polar_Radius * sin, 2);
        return Math.Round(Math.Sqrt(numerator / denominator) , 3);
    }
}
