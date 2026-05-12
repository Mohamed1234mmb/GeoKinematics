using System;
namespace Geodesy.Physics;


/// <summary>
/// Logic for calculating energy: how it's stored, how it moves, and how it's burned.
/// </summary>
public class PowerHouse
{
    private const float KineticConstant = 0.5f;

    /// <summary>
    /// Calculates the energy stored in an object because of its height.
    /// </summary>
    /// <param name="gravity">Gravity force.</param>
    /// <param name="height">How high the object is.</param>
    /// <returns>Total stored energy.</returns>
    public static float CalculateStoredEnergy(float gravity, float height) => (float)(gravity * height);

    /// <summary>
    /// Calculates the energy an object has while it's moving.
    /// </summary>
    /// <param name="mass">Object weight.</param>
    /// <param name="speed">How fast it's going.</param>
    /// <returns>Total movement energy.</returns>
    public static float CalculateMovementEnergy(float mass, double speed) => (float)(KineticConstant * mass * speed * speed);

    /// <summary>
    /// Estimates how much fuel you need to get a specific amount of energy.
    /// </summary>
    /// <param name="energyNeeded">Total energy required.</param>
    /// <param name="fuelPower">How much energy 1 liter/unit of fuel gives.</param>
    /// <returns>Amount of fuel to be used.</returns>
    public static double EstimateFuelUsed(double energyNeeded, double fuelPower) => energyNeeded / fuelPower;
}
