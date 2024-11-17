public class Repairer : Module
{
    private readonly int _energyConsumptionPerRecovery;
    private readonly int _durationInSeconds;
    private readonly int _strengthRecoveryAmount;

    public Repairer(string name, int price, int strength, int level, int energyConsumptionPerRecovery, int durationInSeconds, int strengthRecoveryAmount)
        : base(name, price, strength, level)
    {
        _energyConsumptionPerRecovery = energyConsumptionPerRecovery;
        _durationInSeconds = durationInSeconds;
        _strengthRecoveryAmount = strengthRecoveryAmount;
    }

    public Repairer(RepairerData data)
        : base(data)
    {
        _energyConsumptionPerRecovery = data.EnergyConsumptionPerRecovery;
        _durationInSeconds = data.DurationInSeconds;
        _strengthRecoveryAmount = data.StrengthRecoveryAmount;
    }
}