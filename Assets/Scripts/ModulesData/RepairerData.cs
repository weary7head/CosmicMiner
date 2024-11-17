using UnityEngine;

[CreateAssetMenu(fileName = "Repairer", menuName = "Modules/Repairer")]
public class RepairerData : ModuleData
{
    public int StrengthRecoveryAmount;
    public int EnergyConsumptionPerRecovery;
    public int DurationInSeconds;
}