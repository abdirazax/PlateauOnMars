using System.Collections;
using System.Collections.Generic;

public abstract class OrientationManager
{
    protected List<Orientation> possibleOrientations;
    int _currentOrientationIndex = 0;

    public Orientation CurrentOrientation => possibleOrientations[CurrentOrientationIndex];
    public string CurrentOrientationString
    { get { return possibleOrientations[CurrentOrientationIndex].OrientationName; }
        set {
            for (int i = 0; i < possibleOrientations.Count; i++) 
            {
                if (possibleOrientations[i].OrientationName == value)
                    CurrentOrientationIndex = i;
            }
        }
    }

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

    private bool IsThereAtLeastTwoOrientations()
    {
        return (possibleOrientations.Count >= 2);
    }
}
