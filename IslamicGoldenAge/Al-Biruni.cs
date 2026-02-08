/**
     Al-Biruni Model for calculating the distance to the horizon based on height and horizon angle.
     high : Height above sea level in kilometers.
     horizonAngleDegrees : Angle to the horizon in degrees.
    
**/
using System;
using static Geodesy.Physics.GeodeticConstants;

namespace Geodesy.Physics;

public static class AlBiruni
{
    public static double CalculateEarthRadius(double high, double horizonAngleDegrees)
    {
        double theta = horizonAngleDegrees * Degree_To_Radian;

        return Math.Round((high * Math.Cos(theta)) / (1 - Math.Cos(theta)), 3);
    }
}
