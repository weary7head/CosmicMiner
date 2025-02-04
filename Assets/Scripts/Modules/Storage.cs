public class Storage : Module
{
    private readonly int _mineralsLimit;

    public Storage(string name, int price, int durability, int level, int mineralsLimit)
        : base(name, price, durability, level)
    {
        _mineralsLimit = mineralsLimit;
    }

    public Storage(StorageData data)
        : base(data)
    {
        _mineralsLimit = data.MineralsLimit;
    }
}