using static Geodesy.Physics.Newton2law;
namespace Geodesy.Physics;
public class EnergyPhysics
{
    private const float KineticConstant = 0.5f;
    public static float CalculatePotentialEnergy(float gravity , float high  )
    {
        return (float)(gravity * high);
    }

    public static float CalculateKineticEnergy(float mass, double currentSpeed)
    {
        return (float)(KineticConstant * mass * currentSpeed * currentSpeed);
    }

    public static double EstimateFuelConsumption(double energyJoule, double fuelEnergyDensity)
    {
        return energyJoule / fuelEnergyDensity;
    }
}