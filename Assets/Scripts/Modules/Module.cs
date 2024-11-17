public abstract class Module
{
    protected readonly string _name;
    protected readonly int _price;
    protected readonly int _strength;
    protected readonly int _level;

    protected Module(string name, int price, int strength, int level)
    {
        _name = name;
        _price = price;
        _strength = strength;
        _level = level;
    }
    
    protected Module(ModuleData data)
    {
        _name = data.Name;
        _price = data.Price;
        _strength = data.Strength;
        _level = data.Level;
    }

    public virtual int GetStrength() => _strength;
}