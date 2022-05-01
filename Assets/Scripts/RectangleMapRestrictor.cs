using UnityEngine;

public class RectangleMapRestrictor : IRestrictMovement
{
    int _x, _y;

    public int X
    {
        get => _x; 
        set
        {
            if (value >= 1) _x = value;
            else _x = 1;
        }
    }
    public int Y
    {
        get => _y;
        set
        {
            if (value >= 1) _y = value;
            else _y = 1;
        }
    }

    public RectangleMapRestrictor(int x, int y)
    {
        X = x;
        Y = y;
    }

    public IRestrictMovement DeepCopy() {
        return new RectangleMapRestrictor(X, Y);
    }

    public bool CanMoveTo(Vector2Int destination)
    {
        return destination.x < X && destination.y < Y && destination.x >= 0 && destination.y >= 0;
    }
}
