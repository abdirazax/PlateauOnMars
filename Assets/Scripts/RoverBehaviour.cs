using System.Collections.Generic;
using UnityEngine;

public class RoverBehaviour: MonoBehaviour
{
    RectangleMapRestrictor mapRestrictor = new RectangleMapRestrictor(5, 5);
    List<Rover> rovers=new List<Rover>();
    List<Command> commands = new List<Command>();
    private void Start()
    {
        rovers.Add(new Rover(0, 1, new NESWOrientationManager(0), mapRestrictor));
        rovers.Add(new Rover(1, 1, new NESWOrientationManager(0), mapRestrictor));
        rovers.Add(new Rover(2, 1, new NESWOrientationManager(0), mapRestrictor));

        Debug.Log(rovers[0].Pos);
        commands.Add(new MoveCommand(rovers[0]));
        commands.Add(new TurnRightCommand(rovers[0]));
        commands.Add(new MoveCommand(rovers[0]));
        commands.Add(new TurnLeftCommand(rovers[0]));
        RoverCommandsManager commandManager = new RoverCommandsManager(commands);
        commandManager.DebugAllCommands();
        Debug.Log(rovers[0].Pos);

    }
}
