using OpenClosedPrinciple.Models;
using OpenClosedPrinciple.Services;

internal class Program
{
    //The Open-Closed Principle emphasizes that a class should be open for extension but closed for modification.
    //This means that you should be able to add new functionality to a class without altering its existing code.

    private static void Main(string[] args)
    {
        IShape rectangle = new Rectangle { Width = 10, Height = 5 };
        IShape circle = new Circle { Radius = 7 };

        AreaCalculator calculator = new();

        Console.WriteLine("Rectangle Area: " + calculator.CalculateArea(rectangle));
        Console.WriteLine("Circle Area: " + calculator.CalculateArea(circle));
    }
}