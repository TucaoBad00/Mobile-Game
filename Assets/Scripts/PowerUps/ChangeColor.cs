using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : PowerUpBase
{
    public Color color;
    public Material material;
    private Color initialColor;

    void Start()
    {
        initialColor = material.color;
    }
    public override void StartPower()
    {
        base.StartPower();
        material.color = color;
    }
    public override void EndPower()
    {
        base.EndPower();
        material.color = initialColor;
    }
}
