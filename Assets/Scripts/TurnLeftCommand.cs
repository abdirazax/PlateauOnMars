public class TurnLeftCommand : MoveCommand
{
    public TurnLeftCommand()
    {
    }
    public override void ExecuteCommand(Mover mover)
    {
        mover.TurnLeft();
    }
}
