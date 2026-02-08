using System;
using static Geodesy.Physics.Validation;
namespace Geodesy.Physics;
public class Acceleration
{


    public static double CalculateAcceleration(double deltav, double totalTime)
    {
        return isValidInput(deltav, totalTime) ? Math.Round(deltav / totalTime, 3) : 0.0;
    }

    public static double TurboAcceleration(double calculatedAcc, double t, double turboFactor, double value)
    {
        return Math.Min(calculatedAcc * Math.Exp(t / turboFactor), value);
    }

    public static double EmergencyDeceleration(double acceleration, double t)
    {
        return isValidInput(acceleration, t) ? (acceleration / Math.Log(t + Math.E)) : 0.0;
    }
}