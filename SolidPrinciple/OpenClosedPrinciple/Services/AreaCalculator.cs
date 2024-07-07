using OpenClosedPrinciple.Models;

namespace OpenClosedPrinciple.Services;

public class AreaCalculator
{
    public double CalculateArea(IShape shape)
    {
        return shape.Area();
    }
}
