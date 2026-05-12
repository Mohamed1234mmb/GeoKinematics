using System;
using static Geodesy.Physics.EarthMath;
namespace Geodesy.Physics;

/// <summary>Is the calculation of the distance between 2 points on the Earth's surface , given the lines of longitude and latitude</summary> 

public static class HaversineFormula
{
    /// <summary>Calculate the Haversine distance between 2 points on the Earth's surface</summary>
    /// <param name="Lat1">Latitude of the first point in degrees</param>
    /// <param name="Lon1">Longitude of the first point in degrees</param>
    /// <param name="Lat2">Latitude of the second point in degrees</param>
    /// <param name="Lon2">Longitude of the second point in degrees</param>
    /// <param name="EarthRadiusKM">the radius of the Earth in kilometers</param>
    /// <example>
    /// <code>
    /// double Lat1 = 30.0444;
    /// double Lon1 = 31.2357;
    /// double Lat2 = 55.7558;
    /// double Lon2 = 37.6173;
    /// double EarthRadiusKM = 6371;
    /// double distance = HaversineFormula.CalculateDistance(Lat1 , Lon1 , Lat2 , Lon2 , EarthRadiusKM);
    /// </code>
    /// </example>
    /// <returns>The distance between the two points in kilometers</returns>
    public static double CalculateDistance(double Lat1, double Lon1, double Lat2, double Lon2, double EarthRadiusKM)
    {
        double dlon = (Lon2 - Lon1) * DegreeToRadians;
        double dlat = (Lat2 - Lat1) * DegreeToRadians;

        double sindlat = Math.Sin(dlat * 0.5);
        double sindlon = Math.Sin(dlon * 0.5);

        double coslat1 = Math.Cos(Lat1 * DegreeToRadians);
        double coslat2 = Math.Cos(Lat2 * DegreeToRadians);

        double a = (sindlat * sindlat) + (coslat1 * coslat2 * (sindlon * sindlon));


        a = Math.Min(1.0, Math.Max(0.0, a));

        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        return Math.Round(EarthRadiusKM * c, 3);
    }
};