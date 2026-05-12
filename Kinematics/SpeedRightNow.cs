using System;
namespace Geodesy.Physics;
using static Geodesy.Physics.Validation;
using static Geodesy.Physics.Transfers;

/// <summary>
/// This class tells you your Current Speed (Instant Speed) right now.
/// </summary>
public static class SpeedRightNow
{
    /// <summary>
    /// Calculates how fast you are going at this exact moment.
    /// </summary>
    /// <param name="distanceInKm">The tiny distance you just moved (in Kilometers).</param>
    /// <param name="fullTimeInSeconds">The very small time it took to move that distance.</param>
    /// <example>
    /// <code>
    /// // If you moved 0.01 km in 0.5 seconds:
    /// double currentKmH = SpeedRightNow.GetSpeedRightNow(0.01, 0.5);
    /// </code>
    /// </example>
    /// <returns>Your speed in Kilometers per Hour (km/h).</returns>
    public static double GetSpeedRightNow(double distanceInKm, double fullTimeInSeconds)
    {
        double distanceInMeters = distanceInKm * Transfers.KilometersToMeters(1.0); // Assuming KilometersToMeters is 1000

        double speed = distanceInMeters / fullTimeInSeconds;

        return isValidInput(speed) ? Transfers.MetersToKilometers(speed) : 0;
    }
}
