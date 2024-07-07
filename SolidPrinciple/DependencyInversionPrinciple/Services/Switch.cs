using DependencyInversionPrinciple.Models;

namespace DependencyInversionPrinciple.Services;

public class Switch
{
    private readonly IDevice _device;

    public Switch(IDevice device)
    {
        _device = device;
    }

    public void Operate(bool on)
    {
        if (on)
        {
            _device.TurnOn();
        }
        else
        {
            _device.TurnOff();
        }
    }
}
