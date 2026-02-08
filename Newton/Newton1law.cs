namespace Geodesy.Physics;
public static class Newton1law
{
    internal static bool zero_check(bool val1, bool val2)
    {
        return (val1 ^ val2);
    }

    public static float isStatic()
    {
        return zero_check(true, true) ? 1.0f : 0.0f;
    }
};