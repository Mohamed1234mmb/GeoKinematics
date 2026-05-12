namespace Geodesy.Physics;

/// <summary>
/// > Constants for Newton's First Laws (Static and Moving) states
/// </summary>
public struct Newton1Constants
{
    /// <summary>
    /// > This object at rest (static state)
    /// </summary>
    public const bool StaticState = false;

    /// <summary>
    /// > This object at moving
    /// </summary>
    public const bool MovingState = true;
}

/// <summary>
/// > Constants for Newton's Second Laws (Earth and Gravity)
/// </summary>
public readonly struct Newton2Constants
{
    /// <summary>
    /// The Universal Gravitational Constant (G) that we use in all space calculations
    /// </summary>
    public const double GravitationalConstant = 6.67430e-11f;

    /// <summary>
    /// Weight of palnet Earth in kilograms, used in gravity calculations
    /// </summary>
    public const double EarthMass = 5.972e24f;
}

/// <summary>
/// > Constants for Newton's Third Laws (Action and Reaction)
/// </summary>
public struct Newton3Constants
{
    /// <summary>
    /// The minimum value for a force to be considered active
    /// </summary>
    public const float Minimum = 0.01f;
}
