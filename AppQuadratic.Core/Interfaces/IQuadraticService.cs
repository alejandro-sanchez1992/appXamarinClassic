using System;
namespace AppQuadratic.Core.Interfaces
{
    public interface IQuadraticService
    {
        double QuadraticFunction(double a, double b, double c);
        double ValueX1(double a, double b, double c);
        double ValueX2(double a, double b, double c);
    }
}
