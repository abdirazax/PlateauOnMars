using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskInput : MonoBehaviour
{
    [SerializeField]
    protected int _plateauSizeX = 1;
    [SerializeField]
    protected int _plateauSizeY = 1;
    [SerializeField]
    public List<MoveCommand> commands = new List<MoveCommand>();
    


    public List<Rover> GetRoversAfterCommandsExecuted()
    {
        List<Rover> rovers = new List<Rover>();
        foreach (MoveCommand command in commands)
        {
            command.ExecuteCommand();
            if (!rovers.Contains((Rover)command.Mover))
                rovers.Add((Rover)command.Mover);
        }
        return rovers;
    }

    //debugging
    /*private void Awake()
    {
        List<Rover> initRovers = new List<Rover>();
        initRovers.Add(new Rover(
            0,
            1,
            new NESWOrientationManager(0),
            new RectangleMapRestrictor(_plateauSizeX, _plateauSizeY)));
        initRovers.Add(new Rover(
                    2,
                    1,
                    new NESWOrientationManager(0),
                    new RectangleMapRestrictor(_plateauSizeX, _plateauSizeY)));


        commands.Add(new MoveForwardCommand(initRovers[0]));
        commands.Add(new MoveForwardCommand(initRovers[1]));
        commands.Add(new MoveForwardCommand(initRovers[0]));
        commands.Add(new TurnLeftCommand(initRovers[0]));
    }*/
}

public class TaskInputVRKeys : TaskInput
{
    List<Rover> rovers = new List<Rover>();
    public void SetMapSize(int x, int y)
    {
        _plateauSizeX = x;
        _plateauSizeY = y;
    }

    public void SetLastRoverOrientation(string newOrientation)
    {
        if (rovers.Count > 0)
        {
            rovers[rovers.Count - 1].OrientationManager.CurrentOrientationString = newOrientation;
        }
    }
}
