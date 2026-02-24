using System;
namespace Geodesy.Physics;
using static Geodesy.Physics.Haversine_Formula;
using static Geodesy.Physics.Validation;

public static class InstantaneousSpeed
{
    public static double CalculateInstantaneousSpeed(double distanceInKm, double fullTimeInSeconds)
    {
        double distanceInMeters = distanceInKm * 1000.0;
        double speed = distanceInMeters / fullTimeInSeconds;
        return isValidInput(speed) ? Tokmh(speed) : 0;
    }

    public static double Tokmh(double speedInMs)
    {
        return Math.Round((speedInMs * 3.6), 3);
    }
}