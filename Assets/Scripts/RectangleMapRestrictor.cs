using UnityEngine;

public class RectangleMapRestrictor : IRestrictMovement
{
    int _x, _y;

    public RectangleMapRestrictor(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public bool CanMoveTo(Vector2Int destination)
    {
        return destination.x <= _x && destination.y <= _y;
    }
}
