public class MoveCommand : Command
{
    IMove _forwardMover;

    public MoveCommand(IMove forwardMover)
    {
        _forwardMover = forwardMover;
    }

    public override void ExecuteCommand()
    {
        _forwardMover.Move();
    }
}
