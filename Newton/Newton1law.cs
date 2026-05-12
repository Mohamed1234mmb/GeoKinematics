namespace Geodesy.Physics;

using static Geodesy.Physics.Newton1Constants;

/// <summary>
/// it tells of the state of object which does not move from its place 
/// </summary>
public static class Newton1Law
{
    ///<summary
    /// > Use this if you want to know whether the object is still or not
    ///</summary>
    ///<example>
    /// This example to use the function
    ///<code>
    /// bool isStatic = ZeroCheck(true , true)
    /// </code>
    ///</example>
    /// <param name="val1">The state of the first object</param>
    /// <param name="val2">The state of the second object</param>
    /// <returns>
    /// false if the object is still , and true if the object is moving
    /// </returns>

    internal static bool ZeroCheck(bool val1, bool val2) => (val1 ^ val2);

    ///<summary>
    /// it represent of force when it is in a static state
    ///</summary>
    ///<example>
    /// A book description on desk
    ///<code>
    /// float book = IsStatic()
    ///</code>
    ///</example>
    ///<returns>0.0f it is mean the push (force) is in a static state</returns>

    public static bool IsStatic() => ZeroCheck(true, true) ? MovingState : StaticState;

};