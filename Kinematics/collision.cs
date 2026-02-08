namespace Geodesy.Physics;
public static class Collision
{
    public static double CalculateInelasticCollision(float m1, float m2, float v1, float v2)
    {
        double finalVelocity = (m1 * v1 + m2 * v2) / (m1 + m2);
        return finalVelocity;
    }

    public static (double v1Final, double v2Final) CalculateElasticCollision(float m1, float m2, float v1, float v2)
    {

        double v1Final = ((m1 - m2) * v1 + (2 * m2 * v2)) / (m1 + m2);
        double v2Final = ((m2 - m1) * v2 + (2 * m1 * v1)) / (m1 + m2);

        return (v1Final, v2Final);
    }
}