public class TurnLeftCommand : MoveCommand
{
    public TurnLeftCommand(IMove mover)
    {
        Mover = mover;
    }
    public override void ExecuteCommand()
    {
        Mover.TurnLeft();
    }
}
