namespace Geodesy.Physics;

/// <summary>
/// A set of fixed numbers used to calculate distance to Earth
/// <remarks>
/// to use for calculating distance between places on Earth map
/// </remarks>
/// </summary>
public static class EarthMath

// ------------- Basic Constants --------------
{
    /// <summary>
    /// Calculates mathimatical (radian) like GPS this is number to used for 
    /// converting degrees to radian
    /// </summary>
    public const double DegreeToRadians = 0.0174532925199432952;

    /// <summary>
    /// The distance between the center of the Earth and a specific point on its surface.
    /// </summary>
    public const double MiddleRadius = 6378.1370;

    /// <summary>
    /// distance between the center of the Earth and the two poles (the North pole and the South pole)
    /// </summary>
    public const double PolarRadius = 6356.7523;

    
}