using System.Collections.Generic;
using UnityEngine;

public class RoverCommandsManager
{
    public List<Command> commands;

    public RoverCommandsManager(List<Command> commands)
    {
        this.commands = commands;
    }
    public void DebugAllCommands()
    {
        foreach(Command command in commands)
        {
            command.ExecuteCommand();
            Debug.Log(command);
        }
    }
}