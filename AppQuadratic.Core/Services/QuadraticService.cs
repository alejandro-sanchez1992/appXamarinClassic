using System;
using AppQuadratic.Core.Interfaces;

namespace AppQuadratic.Core.Services
{
    public class QuadraticService : IQuadraticService
    {
        public double QuadraticFunction(double a, double b, double c)
        {
            double quadratic = Math.Sqrt(b * b - 4 * a * c);

            return quadratic;
        }

        public double ValueX1(double a, double b, double c)
        {
            double value = QuadraticFunction(1, 2, 3);
            double x1 = 0;

            if (value >= 0 )
            {
                x1 = (-b + value) / 2 * a;
            }

            return x1;
        }

        public double ValueX2(double a, double b, double c)
        {
            double value = QuadraticFunction(1, 2, 3);
            double x2 = 0;

            if (value >= 0)
            {
                x2 = (-b - value) / 2 * a;
            }

            return x2;
        }
    }
}
