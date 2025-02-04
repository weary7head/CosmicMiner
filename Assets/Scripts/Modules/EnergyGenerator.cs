public class EnergyGenerator : Module
{
    private readonly int _energyProductionPer100Km;

    public EnergyGenerator(string name, int price, int durability, int level, int energyProductionPer100Km)
        : base(name, price, durability, level)
    {
        _energyProductionPer100Km = energyProductionPer100Km;
    }

    public EnergyGenerator(EnergyGeneratorData data)
        : base(data)
    {
        _energyProductionPer100Km = data.EnergyProductionPer100Km;
    }
}