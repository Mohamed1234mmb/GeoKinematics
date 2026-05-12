using System;
using Geodesy.Physics;

namespace Geodesy.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = 385.8;
            double angle = 0.629;
            double lat1 = 30.0444;
            double lon1 = 31.2357;
            double lat2 = 55.7558;
            double lon2 = 37.6173;

            double Km = Transfers.MetersToKilometers(height);
            double radius = AlBiruni.CalculateEarthRadius(Km, angle);
            double distance = HaversineFormula.CalculateDistance(lat1, lon1, lat2, lon2, radius);
            Console.WriteLine($"The distance between the two points is {distance} kilometers.");


            float f = Newton2Law.CalculatePush(1000f, 2.5f);
            Console.WriteLine($"The force is {f} Newtons.");

            float reverse = Newton3Law.ReversePush(10f);
            Console.WriteLine($"The reverse push is {reverse} Newtons.");














        }
    }
}