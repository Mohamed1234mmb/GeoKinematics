using System;
namespace Geodesy.Physics;
public class TerminalVelocity
{
    public static double Calculate(double netMotivePower, double airDensity, double dragCoefficient, double frontalArea)
    {
        double denominator = airDensity * dragCoefficient * frontalArea;
        return Math.Sqrt((2 * netMotivePower) / denominator);
    }
}