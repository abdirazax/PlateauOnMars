public class TurnRightCommand : MoveCommand
{
    public TurnRightCommand(IMove mover)
    {
        Mover = mover;
    }
    public override void ExecuteCommand()
    {
        Mover.TurnRight();
    }
}
