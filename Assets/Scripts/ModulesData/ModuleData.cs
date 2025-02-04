using UnityEngine;
using UnityEngine.Serialization;

public abstract class ModuleData : ScriptableObject
{
    public string Name;
    public int Price;
    public int Durability;
    public int Level;   
}