public class Engine : Module
{
    private readonly int _energyConsumptionPerBattle;
    private readonly int _energyConsumptionPer100Km;
    
    public Engine(string name, int price, int strength, int level, int energyConsumptionPerBattle, int energyConsumptionPer100Km)
        : base(name, price, strength, level)
    {
        _energyConsumptionPerBattle = energyConsumptionPerBattle;
        _energyConsumptionPer100Km = energyConsumptionPer100Km;
    }
    
    public Engine(EngineData data)
        : base(data)
    {
        _energyConsumptionPerBattle = data.EnergyConsumptionPerBattle;
        _energyConsumptionPer100Km = data.EnergyConsumptionPer100Km;
    }
}