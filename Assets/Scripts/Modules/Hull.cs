using System.Linq;

public class Hull : Module
{
    private int _modulesLimit;
    private Module[] _modules;

    public Hull(string name, int price, int strength, int level, int modulesLimit)
        : base(name, price, strength, level)
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

    public override int GetStrength()
    {
        var strength = _modules.Sum(module => module.GetStrength());
        return strength + base.GetStrength();
    }
}