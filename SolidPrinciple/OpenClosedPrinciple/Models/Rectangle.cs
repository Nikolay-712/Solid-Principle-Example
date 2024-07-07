namespace OpenClosedPrinciple.Models;

public class Rectangle : IShape
{ 
    // Rectangle class implementing IShape interface

    public double Width { get; set; }

    public double Height { get; set; }

    public  double Area()
    {
        return Width * Height;
    }
}
