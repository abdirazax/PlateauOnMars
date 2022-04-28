using System.Collections;
using System.Collections.Generic;

public abstract class OrientationManager
{
    public List<IGiveMoveInstruction> possibleOrientations;
    int _currentOrientationIndex = 0;
    public int CurrentOrientationIndex
    {
        get { return _currentOrientationIndex; }
        set
        {
            if (IsThereAtLeastTwoOrientations())
            {
                // loop from another side of bounds if the new chosen orientation index exceeds bounds
                _currentOrientationIndex = 
                    Utilities.GetIndexLoopedFromOtherSideWhenOutOfBounds
                    (value, 0, possibleOrientations.Count - 1);
            }
        }
    }

    public IGiveMoveInstruction GetCurrentOrientation()
    {
        return possibleOrientations[CurrentOrientationIndex];
    }
    private bool IsThereAtLeastTwoOrientations()
    {
        return (possibleOrientations.Count >= 2);
    }
}
