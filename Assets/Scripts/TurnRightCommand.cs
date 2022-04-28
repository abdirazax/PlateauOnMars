public class TurnRightCommand : Command
{
    IChangeOrientation _orientationChanger;

    public TurnRightCommand(IChangeOrientation orientationChanger)
    {
        _orientationChanger = orientationChanger;
    }

    public override void ExecuteCommand()
    {
        _orientationChanger.TurnRight();
    }

}
