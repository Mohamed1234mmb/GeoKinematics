using System;
using static Geodesy.Physics.Validation;
namespace Geodesy.Physics;
public class Acceleration
{
    public static double CalculateAcceleration(double deltav, double totalTime)

    {
        double acceleration = deltav / totalTime;
        return isValidInput(acceleration) ? acceleration : 0.0;

    }
}