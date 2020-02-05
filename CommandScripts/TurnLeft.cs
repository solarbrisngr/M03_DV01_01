using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLeft : command
{
    Rigidbody slimShady;
    float standUp;

    public TurnLeft (Rigidbody player, float force)
    {
        slimShady = player;
        standUp = force;
    }
    public override void execute()
    {
        slimShady.AddForce(-standUp * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
