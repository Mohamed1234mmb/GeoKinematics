using System;
namespace Geodesy.Physics;

/// <summary>
/// The maximum speed that the body can reach and cannot exceed.
/// </summary>
public static class SpeedLimits
{
    /// <summary>
    /// Calculates the Max Speed an object can reach based on its power and the environment.
    /// </summary>
    /// <param name="push">How strong the push or the engine is.</param>
    /// <param name="airWeight">How "heavy" or "thick" the air is (Standard is 1.225).</param>
    /// <param name="smoothness">How easily the object "slides" through air (Slick vs. Blocky).</param>
    /// <param name="bodySize">The size of the front of the object hitting the air.</param>
    /// <returns>The Maximum Speed possible.</returns>
    public static double CalculateMaxSpeed(double push, double airWeight, double smoothness, double bodySize)
    {
        // Total resistance from the environment and the body shape
        double resistanceFactor = airWeight * smoothness * bodySize;
        
        // Final calculation for the speed ceiling
        return Math.Sqrt((2 * push) / resistanceFactor);
    }
}
