namespace Geodesy.Physics;
/// <summary>
/// This class handles unit conversion logic for distance and time.
/// </summary>
public static class Transfers
{
    /// <summary>
    /// Converts from Kilometers (km) to meters (m).
    /// </summary>
    /// <param name="kilometers">The value in kilometers (km).</param>
    /// <returns>The value in meters (m).</returns>
    public static double KilometersToMeters(double kilometers) => kilometers * 1000.0;

    /// <summary>
    /// Converts from meters (m) to Kilometers (km).
    /// </summary>
    /// <param name="meters">The value in meters (m).</param>
    /// <returns>The value in kilometers (km).</returns>
    public static double MetersToKilometers(double meters) => meters / 1000.0;

    /// <summary>
    /// Converts from hours (h) to seconds (s).
    /// </summary>
    /// <param name="hours">The value in hours (h).</param>
    /// <returns>The value in seconds (s).</returns>
    public static double HoursToSeconds(double hours) => hours * 3600.0;

    /// <summary>
    /// Converts from seconds (s) to hours (h).
    /// </summary>
    /// <param name="seconds">The value in seconds (s).</param>
    /// <returns>The value in hours (h).</returns>
    public static double SecondsToHours(double seconds) => seconds / 3600.0;
}
