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
            double lat2 = 31.2001;
            double lon2 = 29.9187;

            double myRadius = EarthGeocentricRadius.GetRadius(lat1);
            double distance = Haversine_Formula.CalculateDistance(lat1, lon1, lat2, lon2, myRadius);

            double speed = InstantaneousSpeed.CalculateInstantaneousSpeed(distance, 10800);
            double tokmh = InstantaneousSpeed.Tokmh(speed);

            double travelSeconds = Seconds.durationSeconds(distance, tokmh);
            string formattedTime = Seconds.FormateTime(travelSeconds);

            double horizon = AlBiruni.CalculateEarthRadius(0.5, 0.2);
            float force = Newton2law.CalculateEngineForce(1200f, 2.5f);

            float airRes = Newton2law.CalculateAirResistance(1.225f, 0.3f, 2.2f, speed / 3.6);
            float netForce = Newton2law.CaculteNetForce(force, airRes);

            double terminalV = TerminalVelocity.Calculate(300000, 1.225, 0.3, 2.2);
            double impactV = Collision.CalculateInelasticCollision(1200f, 1500f, 80f, 40f);

            Console.WriteLine($"Distance: {distance} km");
            Console.WriteLine($"Travel Time: {formattedTime} h");
            Console.WriteLine($"Time : {travelSeconds} s");
            Console.WriteLine($"Speed: {speed} m/s");
            Console.WriteLine($"Tokmh: {tokmh} km/h");
            Console.WriteLine($"Horizon: {horizon} km");
            Console.WriteLine($"Net Force: {netForce} N");
            Console.WriteLine($"Terminal Velocity: {terminalV} m/s");
            Console.WriteLine($"Collision Impact: {impactV} km/h");
        }
    }
}