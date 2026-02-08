using System;
namespace Geodesy.Physics;

public static class IbnBajja
{
    public static double CalculateNetVelocity(double enginePower, double dragForce)
    {
        double velocity = enginePower - dragForce;
        return (velocity > 0) ? velocity : 0.0;
    }
}