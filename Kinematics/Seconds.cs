using System;
using static Geodesy.Physics.Validation;
namespace Geodesy.Physics;

public static class Seconds
{

    public static double durationSeconds(double distance, double speed)
    {
        return isValidInput(distance, speed) ? Math.Round((distance / speed) * 3600, 2) : 0.0;
    }

    public static string FormateTime(double totalSeconds)
    {
        int h = (int)Math.Floor(totalSeconds / 3600);
        int m = (int)Math.Floor(totalSeconds % 3600 / 60);
        int s = (int)Math.Round(totalSeconds % 60, 2);
        return $"{h:D2}:{m:D2}:{s:D2}";
    }
}