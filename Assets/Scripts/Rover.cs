using System.Collections;
using UnityEngine;
public class Rover: IMove,IChangeOrientation
{
    Vector2Int _pos;
    OrientationManager _orientation;
    IRestrictMovement _movementRestrictor;

    public Rover(int posX, int posY, OrientationManager orientation, IRestrictMovement movementRestrictor)
    {
        _pos = new Vector2Int(posX, posY);
        _orientation = orientation;
        _movementRestrictor = movementRestrictor;
    }

    public Vector2Int Pos { get => _pos; }

    public void ChangeOrientation(int newOrientationIndex)
    {
        _orientation.CurrentOrientationIndex = newOrientationIndex;
    }

    public void Move()
    {
        Vector2Int newPos = Pos + _orientation.GetCurrentOrientation().GetMoveInstruction();

        if (_movementRestrictor.CanMoveTo(newPos))
            _pos = newPos;
    }

    public void TurnLeft()
    {
        _orientation.CurrentOrientationIndex--;
    }

    public void TurnRight()
    {
        _orientation.CurrentOrientationIndex++;
    }
}
