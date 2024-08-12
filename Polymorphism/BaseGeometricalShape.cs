using System;

public class BaseGeometricShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public virtual void calcArea()
    {
        int area = Width * Height;
        Console.WriteLine($"area is: {area}");
    }
}

public class Square : BaseGeometricShape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Square(int width, int height)
    {
        Width = width;
        Height = height;
    }
    public override void calcArea()
    {
        int area = Width * Height;
        Console.WriteLine($"area is: {area}");
    }
}

public class Rectangle : BaseGeometricShape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
    public override void calcArea()
    {
        int area = Width * Height;
        Console.WriteLine($"area is: {area}");
    }
}

public class RightTriangle : BaseGeometricShape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public RightTriangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
    public override void calcArea()
    {
        int area = (Width * Height) / 2;
        Console.WriteLine($"area is: {area}");
    }
}
