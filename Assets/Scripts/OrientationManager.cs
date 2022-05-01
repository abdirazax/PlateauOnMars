using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationManager
{
    protected List<Orientation> _possibleOrientations;
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
                    (value, 0, _possibleOrientations.Count - 1);
            }
        }
    }
    public Orientation CurrentOrientation => _possibleOrientations[CurrentOrientationIndex];
    public string CurrentOrientationString
    { get { return _possibleOrientations[CurrentOrientationIndex].OrientationName; }
        set {
            for (int i = 0; i < _possibleOrientations.Count; i++) 
            {
                if (_possibleOrientations[i].OrientationName == value)
                    CurrentOrientationIndex = i;
            }
        }
    }
    public OrientationManager DeepCopy
    {
        get
        {
            return new OrientationManager(_possibleOrientations,
                                          _currentOrientationIndex);
        }
    }

    public OrientationManager(List<Orientation> orientations, int currentOrientation)
    {
        _possibleOrientations = orientations;
        CurrentOrientationIndex = currentOrientation;
    }

    bool IsThereAtLeastTwoOrientations()
    {
        return (_possibleOrientations.Count >= 2);
    }
}
