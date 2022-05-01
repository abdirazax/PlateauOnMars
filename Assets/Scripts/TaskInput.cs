using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskInput : MonoBehaviour
{
    [SerializeField]
    protected int PlateauSizeX
    {
        get { return _movementRestrictor.X; }
        set { _movementRestrictor.X = value;
            DisplayInput();
            DisplaySize();
        }
    }
    [SerializeField]
    protected int PlateauSizeY
    {
        get { return _movementRestrictor.Y; }
        set { _movementRestrictor.Y = value;
            DisplayInput();
            DisplaySize();
        }
    }
    protected RectangleMapRestrictor _movementRestrictor;
    [SerializeField]
    protected List<MoveCommandsManager> _moveCommandManagers;
    [SerializeField]
    protected TaskOutput output;


    private void Awake()
    {
        _movementRestrictor = new RectangleMapRestrictor(1, 1);
        _moveCommandManagers = new List<MoveCommandsManager>();
        DisplayInput();

    }

    public void DisplayInput()
    {
        string inputText = (PlateauSizeX ) + " " + (PlateauSizeY ) + "\n";
        foreach(MoveCommandsManager moveCommandsManager in _moveCommandManagers)
        {
            inputText += moveCommandsManager.Mover.Pos.x + " " +
                        moveCommandsManager.Mover.Pos.y + " " +
                        moveCommandsManager.Mover.OrientationManager.CurrentOrientationString + "\n";
            foreach(MoveCommand moveCommand in moveCommandsManager.Commands)
            {
                if (moveCommand is MoveForwardCommand)
                    inputText += "M";
                else if (moveCommand is TurnLeftCommand)
                    inputText += "L";
                else if (moveCommand is TurnRightCommand)
                    inputText += "R";
            }
            inputText += "\n";
        }
        output.DisplayText(inputText);
    }

    public void DisplayOutput()
    {
        output.DisplayMovers(GetTheoreticalMoversAfterCommandsExecuted());
    }

    public List<Mover> GetTheoreticalMoversAfterCommandsExecuted()
    {
        List<MoveCommandsManager> theoreticalMoveCmdManagers =
            _moveCommandManagers.ConvertAll(moveCmdManager => moveCmdManager.DeepCopy);
        List<Mover> theoreticalMovers = new List<Mover>();
        foreach (MoveCommandsManager theoreticalMoveCmdManager in theoreticalMoveCmdManagers)
        {
            theoreticalMoveCmdManager.ExecuteAllCommands();
            theoreticalMovers.Add(theoreticalMoveCmdManager.Mover);
        }
        return theoreticalMovers;
    }

    public void AddMLRCommandToLastMover(string commandName)
    {
        if (_moveCommandManagers.Count > 0)
        {
            switch (commandName)
            {
                case "M":
                    _moveCommandManagers[_moveCommandManagers.Count - 1].AddCommand(new MoveForwardCommand());
                    break;
                case "L":
                    _moveCommandManagers[_moveCommandManagers.Count - 1].AddCommand(new TurnLeftCommand());
                    break;
                case "R":
                    _moveCommandManagers[_moveCommandManagers.Count - 1].AddCommand(new TurnRightCommand());
                    break;
            }
        }

        DisplayInput();
    }

    public void SetMapSize(int x, int y)
    {
        PlateauSizeX = x;
        PlateauSizeY = y;
    }


    public void DisplaySize()
    {
        output.DisplayTextOnSmallScreen((PlateauSizeX) + " " + (PlateauSizeY));
    }

}
