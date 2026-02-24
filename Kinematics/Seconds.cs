using System;
using static Geodesy.Physics.Validation;
namespace Geodesy.Physics;

public static class Seconds
{

    public static double durationSeconds(double distance, double speed)
    {
        double seconds = distance / speed;
        return isValidInput(seconds) ? Math.Round((seconds) * 3600, 2) : 0.0;
    }

    public static string FormateTime(double totalSeconds)
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(totalSeconds);
        return timeSpan.ToString(@"hh\:mm\:ss");
    }
}