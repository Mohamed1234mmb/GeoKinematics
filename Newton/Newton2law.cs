using System;
namespace Geodesy.Physics;

using static Geodesy.Physics.Validation;
using static Geodesy.Physics.Transfers;
using static Geodesy.Physics.Newton2Constants;

/// <summary>
/// This class handles the mathematical calcukate for movement: How you push things, how air slows them down, and how gravity pulls them.
/// </summary>
public static class Newton2Law
{
    /// <summary>
    /// Calculates the total "Push" (Force) needed to move an object.
    /// </summary>
    /// <param name="mass">The weight or "heaviness" of the object.</param> 
    /// <param name="acceleration">How fast you want to increase the speed.</param>
    /// <example>
    /// <code>
    /// float force = Newton2law.CalculatePush(1000f, 2.5f);
    /// </code>
    /// </example>
    /// <returns>The total push in Newtons (N).</returns>
    public static float CalculatePush(float mass, float acceleration)
    {
        float Push = mass * acceleration;
        return isValidInput(Push) ? Push : 0.0f;
    }

    /// <summary>
    /// Calculates how much the air "fights" or resists the moving object.
    /// </summary>
    /// <param name="airDensity">How "thick" the air is (e.g., thin at high altitudes, thick at sea level).</param>
    /// <param name="dragCoefficient">How aerodynamic the shape is (slick vs. blocky).</param>
    /// <param name="frontalArea">The size of the "face" hitting the air.</param>
    /// <param name="speed">How fast the object is moving.</param>
    /// <example>
    /// <code>
    /// float resistance = Newton2law.CalculateAirResistance(1.225f, 0.3f, 2.0f, 30.0);
    /// </code>
    /// </example>
    /// <returns>The air resistance force in Newtons (N).</returns>
    public static float CalculateAirResistance(float airDensity, float dragCoefficient, float frontalArea, double speed)
    {
        float totalAirResistance = (float)(0.5 * airDensity * dragCoefficient * frontalArea * speed * speed);
        return isValidInput(totalAirResistance) ? totalAirResistance : 0.0f;
    }

    /// <summary>
    /// Calculates the Earth's downward pull on a specific mass (like a car).
    /// </summary>
    /// <param name="carMass">The mass of the object being pulled.</param>
    /// <param name="r_kilometers">Distance from the center of the Earth in Kilometers.</param>
    /// <returns>The gravity force in Newtons (N).</returns>
    public static float CalculateGravityPush(float carMass, double r_kilometers)
    {
        double r_meters = Transfers.KilometersToMeters(r_kilometers);
        double force = (Newton2Constants.GravitationalConstant * Newton2Constants.EarthMass * carMass) / (r_meters * r_meters);
        return (float)force;
    }

    /// <summary>
    /// Calculates the gravity acceleration constant at a specific distance.
    /// </summary>
    /// <param name="r_kilometers">Distance from the center of the Earth in Kilometers.</param>
    /// <returns>The gravity value (g).</returns>
    public static double CalculateGravity(double r_kilometers)
    {
        double r_meters = Transfers.KilometersToMeters(r_kilometers);
        return (Newton2Constants.GravitationalConstant * Newton2Constants.EarthMass) / (r_meters * r_meters);
    }
}
