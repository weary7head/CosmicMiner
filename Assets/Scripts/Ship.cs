using UnityEngine;

public class Ship : MonoBehaviour
{
    private СommandСenter _сommandСenter;

    public int CalculateTotalDurability() => _сommandСenter.GetDurability();
}