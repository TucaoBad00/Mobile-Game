using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reduce : PowerUpBase
{
    public float sizeModifier;
    public override void StartPower()
    {
        base.StartPower();
        PlayerController.localScale -= new Vector3(sizeModifier, sizeModifier, sizeModifier);
    }
    public override void EndPower()
    {
        base.EndPower();
        PlayerController.localScale = new Vector3(1, 1, 1);
    }

}
