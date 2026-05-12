using System;
namespace Geodesy.Physics;

/// <summary>
///  This class diffrence between two pushes (forces): 
/// the push (force) you exerted
/// and the push (force) that will move against you.
/// </summary>
public static class Newton3Law
{
    /// <summary>
    /// The minimum value for a push (force) to be considered active
    /// </summary>
    /// <remarks>
    /// <pra>
    /// This value was set so that we ignore very small values
    /// and avoid calculation  errors
    /// </pra>
    /// </remarks> 

    /// <summary>
    /// Here we ensure the value is inverted to get the reverse push (force).
    /// </summary>
    /// <example>
    /// <code>
    /// float reverse = Newton3law.ReversePush(10.0f); 
    /// Console.WriteLine(reverse); // -10.0f
    /// </code>
    /// </example>
    /// <param name="reverse_push">is the original push (force) that you want to reverse </param>
    /// <returns>returns the reversed push (force) </returns>
    public static float ReversePush(float reverse_push)
    {
        // logic : if zero return zero , else flip the sign
        return (reverse_push == 0) ? 0.0f : -reverse_push;
    }

    /// <summary>
    /// Here we Calculate the total pushes (forces)
    /// </summary>
    /// <example>
    /// <code>
    /// float total = Newton  3law.TotalPush(10.0f, 5.0f);
    /// Console.WriteLine(total); returns 15.0f;
    /// </code>
    /// </example>
    /// <param name="first_push">This is the push (force) that you exerted (Starting push)</param>
    /// <param name="second_push">This is the push (force) that will move against you</param>
    /// <returns>
    /// Returns the total push (force)
    /// </returns>
    public static float TotalPush(float first_push, float second_push)
    {
        float total = first_push + second_push;
        return (Math.Abs(total) > Newton3Constants.Minimum) ? total : 0.0f;
    }
}