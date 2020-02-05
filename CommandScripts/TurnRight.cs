using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRight : command
{
    Rigidbody slimShady;
    float standUp;

    public TurnRight(Rigidbody player, float force)
    {
        slimShady = player;
        standUp = force;
    }
    public override void execute()
    {
        slimShady.AddForce(standUp * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
