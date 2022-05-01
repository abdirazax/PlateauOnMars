public class MoveForwardCommand : MoveCommand
{
    public MoveForwardCommand()
    {
    }
    public override void ExecuteCommand(Mover mover)
    {
        mover.Move();
    }
}
