namespace InterfaceSegregationPrinciple.Models;

public class Human : IWorkable, IFeedable
{
    public void Eat()
    {
        Console.WriteLine("Human is eating.");
    }

    public void Work()
    {
        Console.WriteLine("Human is working.");
    }
}
