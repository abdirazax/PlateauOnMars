public class TurnRightCommand : MoveCommand
{
    public TurnRightCommand()
    {
    }
    public override void ExecuteCommand(Mover mover)
    {
        mover.TurnRight();
    }
}
