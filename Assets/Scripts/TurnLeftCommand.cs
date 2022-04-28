public class TurnLeftCommand : Command
{
    IChangeOrientation _orientationChanger;

    public TurnLeftCommand(IChangeOrientation orientationChanger)
    {
        _orientationChanger = orientationChanger;
    }

    public override void ExecuteCommand()
    {
        _orientationChanger.TurnLeft();
    }

}
