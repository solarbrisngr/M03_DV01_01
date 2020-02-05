using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker
{
    private command m_Command;
    public void SetCommand(command command)
    {
        m_Command = command;
    }
    public void ExecuteCommand()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    Debug.Log("Left");
        //}
        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    Debug.Log("Right");
        //}

        CommandLog.commands.Enqueue(m_Command);
        m_Command.execute();
    }
}

