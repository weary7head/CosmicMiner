public class Converter : Module
{
    private readonly int _energyCreationPerConversion;
    private readonly int _mineralsConsumptionPerConversion;
    
    public Converter(string name, int price, int strength, int level, int energyCreationPerConversion, int mineralsConsumptionPerConversion)
        : base(name, price, strength, level)
    {
        _energyCreationPerConversion = energyCreationPerConversion;
        _mineralsConsumptionPerConversion = mineralsConsumptionPerConversion;
    }

    public Converter(ConverterData data)
        : base(data)
    {
        _energyCreationPerConversion = data.EnergyCreationPerConversion;
        _mineralsConsumptionPerConversion = data.MineralsConsumptionPerConversion;
    }
}