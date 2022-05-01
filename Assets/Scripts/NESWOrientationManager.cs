using System.Collections.Generic;
using UnityEngine;

public class NESWOrientationManager : OrientationManager
{

    public NESWOrientationManager(List<Orientation> orientations,
                                  int currentOrientation) 
        : base(
            orientations,
            currentOrientation)
    {
    }
    public NESWOrientationManager(int currentOrientation)
        : base(
            orientations: new List<Orientation>(){
                new Orientation(Vector2Int.up, "N"),
                new Orientation(Vector2Int.right, "E"),
                new Orientation(Vector2Int.down, "S"),
                new Orientation(Vector2Int.left, "W")
            },
            currentOrientation)
    {
    }
}
