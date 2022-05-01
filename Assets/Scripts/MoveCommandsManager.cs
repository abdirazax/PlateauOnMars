using System.Collections.Generic;

public class MoveCommandsManager { 
    protected List<MoveCommand> _commands = new List<MoveCommand>();
    protected Mover _mover;

    public List<MoveCommand> Commands
    {
        get
        {
            return _commands;
        }
    }
    public int CommandsCount
    {
        get { return _commands.Count; }
    }
    public Mover Mover { get { return _mover; } }
    public MoveCommandsManager DeepCopy
    {
        get
        {
            MoveCommandsManager moveDeepCopy = new MoveCommandsManager(_mover.DeepCopy);
            moveDeepCopy._commands = _commands;
            return moveDeepCopy;
        }
    }

    public MoveCommandsManager(Mover mover)
    {
        _mover = mover;
    }
    public void AddCommand(MoveCommand moveCommand)
    {
        _commands.Add(moveCommand);
    }
    public void CancelLastCommand()
    {
        _commands.RemoveAt(_commands.Count - 1);
    }
    public void CancelThisCommand(MoveCommand command)
    {
        _commands.RemoveAll(cmd => cmd == command);
    }
    public void ExecuteAllCommands()
    {
        foreach(MoveCommand command in _commands)
        {
            command.ExecuteCommand(_mover);
        }
    }
}



