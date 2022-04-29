using UnityEngine;

public class Orientation
{
    Vector2Int _destination; // where will object go locally if it is oriented that way
    string _orientationName;
    public string OrientationName
    {
        get { return _orientationName; }
    }

    public Orientation(Vector2Int destination, string orientationName)
    {
        _destination = destination;
        _orientationName = orientationName;
    }
    
    public Vector2Int GetMoveInstruction()
    {
        return _destination;
    }
}
