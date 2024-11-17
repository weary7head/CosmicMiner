public class Storage : Module
{
    private readonly int _mineralsLimit;

    public Storage(string name, int price, int strength, int level, int mineralsLimit)
        : base(name, price, strength, level)
    {
        _mineralsLimit = mineralsLimit;
    }

    public Storage(StorageData data)
        : base(data)
    {
        _mineralsLimit = data.MineralsLimit;
    }
}