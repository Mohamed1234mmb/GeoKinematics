using System;
using static Geodesy.Physics.Validation;
namespace Geodesy.Physics;

/// <summary>
/// This class helps you find out "How long" a trip will take.
/// </summary>
public static class Seconds
{
    /// <summary>
    /// Calculates the total travel time in seconds.
    /// </summary>
    /// <param name="distance">The distance of the trip.</param>
    /// <param name="speed">How fast you are going.</param>
    /// <returns>Total time in seconds.</returns>
    public static double CalculateDuration(double distance, double speed)
    {
        double time = distance / speed;

        return isValidInput(time) ? Math.Round(time, 2) : 0.0;
    }

    /// <summary>
    /// Converts raw seconds into a readable clock format (00:00:00).
    /// </summary>
    /// <param name="totalSeconds">The amount of seconds to format.</param>
    /// <returns>A string like "Hours:Minutes:Seconds".</returns>
    public static string FormatTime(double totalSeconds)
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(totalSeconds);
        return timeSpan.ToString(@"hh\:mm\:ss");
    }
}
