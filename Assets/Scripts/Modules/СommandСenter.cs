using System;
using System.Collections.Generic;
using System.Linq;

public class СommandСenter : Module
{
    private static readonly Dictionary<Type, Func<Hull, int, bool>> _validationRules = new()
    {
        { typeof(Battery), (hull, index) => hull[index] is not Storage },
        { typeof(Collector), (hull, index) => hull[index] is not Engine and not Gun },
        { typeof(Converter), (hull, index) => hull[index] is not Engine and not Gun },
        { typeof(EnergyGenerator), (hull, index) => hull[index] is not Gun },
        { typeof(Engine), (hull, index) => hull[index] is not Converter and not Gun }
    };
    
    private Hull[] _hulls;
    private int _hullLimit;

    public СommandСenter(string name, int price, int durability, int level, int hullLimit)
        : base(name, price, durability, level)
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

    public void AddModule(Module module, int hullIndex, int moduleIndex)
    {
        var hull = _hulls[hullIndex];
        var leftModuleIndex = moduleIndex - 1;
        var rightModuleIndex = moduleIndex + 1;

        var isValid = !_validationRules.TryGetValue(module.GetType(), out var rule) ||
                      IsValidPlacement(hull, leftModuleIndex, rightModuleIndex, rule);

        if (isValid) hull.AddModule(module, moduleIndex);
    }

    private bool IsValidPlacement(Hull hull, int leftIndex, int rightIndex, Func<Hull, int, bool> rule)
    {
        var isValidLeft = leftIndex > -1 && leftIndex < Hull.Capacity && rule(hull, leftIndex);
        var isValidRight = rightIndex < Hull.Capacity && rightIndex > -1 && rule(hull, rightIndex);
        return isValidLeft && isValidRight;
    }
    
    public override int GetDurability()
    {
        var strength = _hulls.Sum(body => body.GetDurability());
        return strength + base.GetDurability();
    }
}