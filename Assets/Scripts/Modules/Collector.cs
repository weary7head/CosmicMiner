public class Collector : Module
{
    private readonly int _energyConsumptionPerCollection;
    private readonly int _mineralsCollectedPerFlight;

    public Collector(string name, int price, int strength, int level, int energyConsumptionPerCollection, int mineralsCollectedPerFlight)
        : base(name, price, strength, level)
    {
        _energyConsumptionPerCollection = energyConsumptionPerCollection;
        _mineralsCollectedPerFlight= mineralsCollectedPerFlight;
    }
    
    public Collector(CollectorData data)
        : base(data)
    {
        _energyConsumptionPerCollection = data.EnergyConsumptionPerCollection;
        _mineralsCollectedPerFlight= data.MineralsCollectedPerFlight;
    }
}