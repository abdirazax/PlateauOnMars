using System.Collections.Generic;
using UnityEngine;

public class NESWOrientationManager : OrientationManager
{
    public NESWOrientationManager(int currentOrientationIndex)
    {
        possibleOrientations = new List<IGiveMoveInstruction>();
        possibleOrientations.Add(new Orientation(Vector2Int.up, "N"));
        possibleOrientations.Add(new Orientation(Vector2Int.right, "E"));
        possibleOrientations.Add(new Orientation(Vector2Int.down, "S"));
        possibleOrientations.Add(new Orientation(Vector2Int.left, "W"));
        CurrentOrientationIndex = currentOrientationIndex;
    }
}
