using System;

namespace Test
{
    public class Calculations
    {
        public static double CalculateArea(double Radius)
        {
            return 2 * Radius * Math.PI;
        }
        public static double CalculateArea(double a, double b, double c)
        {
            double p;
            p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public static bool IsTriangleRight(double a, double b, double c)
        {
            if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == b * b + a * a))
                return true;
            else
                return false;
        }
    }
}
