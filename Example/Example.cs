using System;
using Geodesy.Physics;

namespace Geodesy.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double lat1 = 30.0444;
            double lon1 = 31.2357;
            double lat2 = 55.7558;
            double lon2 = 37.6173;

            double radius = EarthGeocentricRadius.GetRadius(lat1);
            double distance = Haversine_Formula.CalculateDistance(lat1, lon1, lat2, lon2, radius);
            double speed = InstantaneousSpeed.CalculateInstantaneousSpeed(distance, 100);
            double time = Seconds.durationSeconds(distance, speed);

            Console.WriteLine($"The radius of the earth is: {radius} km");
            Console.WriteLine($"The distance between the two points is: {distance} km");
            Console.WriteLine($"The time it takes to travel the distance is: {Seconds.FormateTime(time)}");
        }
    }
}