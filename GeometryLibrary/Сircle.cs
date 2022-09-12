﻿namespace GeometryLibrary
{
    public class Сircle : IShape
    {
        public Сircle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius must not be a negative number!");

            Radius = radius;
        }

        public double Radius { get; }

        public double Area() => Math.PI * Radius * Radius;

        public string ShapeName() => "Circle";
    }
}
