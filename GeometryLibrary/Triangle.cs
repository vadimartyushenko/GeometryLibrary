using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        private const double Tolerance = 1e-3;

        private readonly double _a, _b, _c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("The sides of triangle must have a positive length");

            if (!IsValid(a, b, c))
                throw new ArgumentException("A triangle exists only if the sum of any two of its sides is greater than the third");

            _a = a; _b = b; _c = c;
        }

        public bool IsRight() => Math.Abs(_a * _a + _b * _b - _c * _c) < Tolerance ||
                                 Math.Abs(_a * _a + _c * _c - _b * _b) < Tolerance ||
                                 Math.Abs(_c * _c + _b * _b - _a * _a) < Tolerance;

        public double Area()
        {
            throw new NotImplementedException();
        }

        public string ShapeName()
        {
            throw new NotImplementedException();
        }

        private static bool IsValid(double a, double b, double c) => (a + b >= c) && (a + c >= b) && (c + b >= a);
    }
}
