using UnityEngine;

[CreateAssetMenu(fileName = "Repairer", menuName = "Modules/Repairer")]
public class RepairerScriptableObject : ModuleData
{
    public int StrengthRecoveryAmount;
    public int EnergyConsumptionPerRecovery;
    public int DurationInSeconds;
}