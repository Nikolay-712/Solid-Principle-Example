using DependencyInversionPrinciple.Models;
using DependencyInversionPrinciple.Services;

internal class Program
{
    //The Dependency Inversion Principle advocates that high-level modules should not depend on low-level modules.
    //Both should depend on abstractions. This promotes decoupling and flexibility in your code.

    private static void Main(string[] args)
    {
        // Using LightBulb with the switch
        IDevice lightBulb = new LightBulb();
        Switch lightSwitch = new Switch(lightBulb);
        lightSwitch.Operate(true);  // LightBulb is turned on.
        lightSwitch.Operate(false); // LightBulb is turned off.

        // Using Fan with the switch
        IDevice fan = new Fan();
        Switch fanSwitch = new Switch(fan);
        fanSwitch.Operate(true);  // Fan is turned on.
        fanSwitch.Operate(false); // Fan is turned off.
    }
}