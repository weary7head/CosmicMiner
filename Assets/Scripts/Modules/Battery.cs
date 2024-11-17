public class Battery : Module
{
    private readonly int _energyLimit;
    private int _currentEnergyAmount;

    public Battery(string name, int price, int strength, int level, int energyLimit)
        : base(name, price, strength, level)
    {
        _energyLimit = energyLimit;
        _currentEnergyAmount = _energyLimit;
    }
    
    public Battery(BatteryData data)
        : base(data)
    {
        _energyLimit = data.EnergyLimit;
        _currentEnergyAmount = _energyLimit;
    }
}