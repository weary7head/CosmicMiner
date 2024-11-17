public class Gun : Module
{
    private readonly int _damage;
    private readonly int _energyConsumptionPerShot;

    public Gun(string name, int price, int strength, int level, int damage, int energyConsumptionPerShot)
        : base(name, price, strength, level)
    {
        _damage = damage;
        _energyConsumptionPerShot = energyConsumptionPerShot;
    }

    public Gun(GunData data)
        : base(data)
    {
        _damage = data.Damage;
        _energyConsumptionPerShot = data.EnergyConsumptionPerShot;
    }
}