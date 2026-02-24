using static Geodesy.Physics.Validation;
namespace Geodesy.Physics;

public static class Validation
{
    internal static bool isValidInput(double value)
    {
        return !(value < 0 || double.IsNaN(value));
    }
}