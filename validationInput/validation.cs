using static Geodesy.Physics.Validation;
namespace Geodesy.Physics;
public static class Validation
{
    internal static bool isValidInput(double val1, double val2)
    {
        return !(val1 == 0 || val2 == 0);
    }
}