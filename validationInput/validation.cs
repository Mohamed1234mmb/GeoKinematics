using static Geodesy.Physics.Validation;
namespace Geodesy.Physics;

/// <summary>
/// Provides validation methods for geodetic an d physics calculations.
/// </summary>
public static class Validation
{
    internal static bool isValidInput(double value) => !(value < 0 || double.IsNaN(value));
}