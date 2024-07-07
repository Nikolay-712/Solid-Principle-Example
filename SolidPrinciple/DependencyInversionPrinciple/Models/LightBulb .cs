namespace DependencyInversionPrinciple.Models;

public class LightBulb : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("LightBulb is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("LightBulb is turned off.");
    }
}
