// Calculates the Haversine distance between two points on the Earth's surface.
using System;
using static Geodesy.Physics.GeodeticConstants;
namespace Geodesy.Physics;
public static class Haversine_Formula
{
    public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2, double Earth_Radius_KM)
    {
        double d_lon = (lon2 - lon1) * Degree_To_Radian;
        double d_lat = (lat2 - lat1) * Degree_To_Radian;

        double sin_dlat = Math.Sin(d_lat * 0.5);
        double sin_dlon = Math.Sin(d_lon * 0.5);

        double cos_lat1 = Math.Cos(lat1 * Degree_To_Radian);
        double cos_lat2 = Math.Cos(lat2 * Degree_To_Radian);

        double a = (sin_dlat * sin_dlat) + (cos_lat1 * cos_lat2 * (sin_dlon * sin_dlon));

        a = Math.Min(1.0 , Math.Max(0.0 , a));
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));


        return Math.Round(Earth_Radius_KM * c, 3);
    }
};