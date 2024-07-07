namespace OpenClosedPrinciple.Models;

public class Circle : IShape
{
    // Circle class implementing IShape interface

    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
