public class MoveForwardCommand : MoveCommand
{
    public MoveForwardCommand(IMove mover)
    {
        Mover = mover;
    }
    public override void ExecuteCommand()
    {
        Mover.Move();
    }
}
