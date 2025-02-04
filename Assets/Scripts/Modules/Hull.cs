using System.Linq;

public class Hull : Module
{
    public static int Capacity = 4;
    
    private int _modulesLimit;
    private Module[] _modules;

    public Hull(string name, int price, int durability, int level, int modulesLimit)
        : base(name, price, durability, level)
    {
        _modulesLimit = modulesLimit;
        _modules = new Module[_modulesLimit];
    }

    public Hull(HullData data)
        : base(data)
    {
        _modulesLimit = data.ModulesLimit;
        _modules = new Module[_modulesLimit];
    }

    public void AddModule(Module module, int index)
    {
        _modules.SetValue(module, index);
    }
    
    public Module this[int index]
    {
        get => _modules[index];
        //set => _modules[index] = value;
    }

    public override int GetDurability()
    {
        var strength = _modules.Sum(module => module.GetDurability());
        return strength + base.GetDurability();
    }
}