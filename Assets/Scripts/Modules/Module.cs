public abstract class Module
{
    protected readonly string _name;
    protected readonly int _price;
    protected readonly int _durability;
    protected readonly int _level;

    protected Module(string name, int price, int durability, int level)
    {
        _name = name;
        _price = price;
        _durability = durability;
        _level = level;
    }
    
    protected Module(ModuleData data)
    {
        _name = data.Name;
        _price = data.Price;
        _durability = data.Durability;
        _level = data.Level;
    }

    public virtual int GetDurability() => _durability;
}