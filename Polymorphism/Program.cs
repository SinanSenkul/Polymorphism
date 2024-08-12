using System;

namespace Polymorphism
{
    class Program
    {
        static void Main()
        {
            BaseGeometricShape square = new Square(4, 2);
            BaseGeometricShape rectangle = new Rectangle(5, 3);
            BaseGeometricShape triangle = new RightTriangle(6, 4);

            square.calcArea();
            rectangle.calcArea();
            triangle.calcArea();
        }
    }
}