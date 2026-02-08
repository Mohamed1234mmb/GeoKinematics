using System;

namespace Geodesy.Physics;

public static class Newton3law
{
    private const float threshold = 0.1f;

    public static float oppositeForce(float force)
    {
        return -force;
    }

    public static float netForce(float force1, float force2)
    {
        float totalForce = force1 + force2;
        return (Math.Abs(totalForce) > threshold) ? totalForce : 0.0f;
    }
}