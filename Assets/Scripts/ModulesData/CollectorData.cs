using UnityEngine;

[CreateAssetMenu(fileName = "Collector", menuName = "Modules/Collector")]
public class CollectorData : ModuleData
{
    public int EnergyConsumptionPerCollection;
    public int MineralsCollectedPerFlight;
}