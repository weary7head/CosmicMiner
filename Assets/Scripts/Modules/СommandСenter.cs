using System.Linq;

public class СommandСenter : Module
{
    private Hull[] _hulls;
    private int _hullLimit;

    public СommandСenter(string name, int price, int strength, int level, int hullLimit)
        : base(name, price, strength, level)
    {
        _hullLimit = hullLimit;
        _hulls = new Hull[_hullLimit];
    }
    
    public СommandСenter(СommandСenterData data) 
        : base(data)
    {
        _hullLimit = data.HullLimit;
        _hulls = new Hull[_hullLimit];
    }

    public void AddBody(Hull hull, int index)
    {
        _hulls.SetValue(hull, index);
    }

    public void AddModule(Module module, int bodyIndex, int moduleIndex)
    {
        _hulls[bodyIndex].AddModule(module, moduleIndex);
    }

    public override int GetStrength()
    {
        var strength = _hulls.Sum(body => body.GetStrength());
        return strength + base.GetStrength();
    }
}