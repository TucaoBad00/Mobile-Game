using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpBase : ItemCollectable
{
    public float duration;

    public virtual void StartPower()
    {
        Invoke(nameof(EndPower), duration);
    }
    public virtual void EndPower()
    {

    }
    protected override void Collect()
    {
        base.Collect();
        StartPower();
    }

}
