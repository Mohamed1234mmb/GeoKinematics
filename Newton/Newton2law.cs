using System;
using static Geodesy.Physics.Validation;
namespace Geodesy.Physics;

public static class Newton2law
{
    private static readonly double G = 6.67430e-11f;
    private static readonly double Earth_Mass = 5.972e24f;
    public static float CalculateEngineForce(float mass, float acceleration)
    {
        return isValidInput(mass, acceleration) ? mass * acceleration : 0.0f;
    }

    public static float CalculateAirResistance(float airDensity, float dragCoefficient, float frontalArea, double speed)
    {
        return isValidInput((float)speed, airDensity) ? (float)(0.5 * airDensity * dragCoefficient * frontalArea * speed * speed) : 0.0f;
    }

    public static float CaculteNetForce(float engineForce, float airResistance)
    {
        return engineForce - airResistance;
    }

    public static float CalculateGravitationalForce(float carMass, double r_kilometers)
    {
        double r_meters = r_kilometers * 1000.0;
        double force = (G * Earth_Mass * carMass) / (r_meters * r_meters);
        return isValidInput(carMass, (float)r_kilometers) ? (float)force : 0.0f;
    }

    public static double CalculateGravity(double r_kilometers)
    {
        double r_meters = r_kilometers * 1000.0;
        return (G * Earth_Mass) / (r_meters * r_meters);
    }
}