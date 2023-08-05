using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : PowerUpBase
{
    public touchControl speedControl;
    public float speed;
    public override void StartPower()
    {
        base.StartPower();
        PlayerController.position = new Vector3(PlayerController.position.x, PlayerController.position.y + 4, PlayerController.position.z);
        speedControl.speedOnLevel += 3;
    }
    public override void EndPower()
    {
        PlayerController.position = new Vector3(PlayerController.position.x, PlayerController.position.y - 4, PlayerController.position.z);
        speedControl.speedOnLevel -= 3;
        base.EndPower();
    }

}
