using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : PowerUpBase
{
    [Header("Speed Up PowerUp")]
    public touchControl touchControl;
    public float speedModifier;
    public override void StartPower()
    {
        base.StartPower();
        touchControl.SpeedUpPowerStart(speedModifier);
    }
    public override void EndPower()
    {
        base.EndPower();
        touchControl.SpeedUpPowerEnd(speedModifier);
    }
}
