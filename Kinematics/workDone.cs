using System;
using static Geodesy.Physics.Newton2law;
namespace Geodesy.Physics;
public class WorkDone

{
    public static float CalculateWorkDone(float calculateForce, float distance)
    {
        return calculateForce * distance;
    }

    public static float CalculatePotentialEnergy(float weight, float height)
    {
        return weight * height;
    }
}