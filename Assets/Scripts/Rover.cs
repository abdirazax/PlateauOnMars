using System.Collections;
using UnityEngine;
public class Rover: IMove
{
    Vector2Int _pos;
    OrientationManager _orientationManager;
    IRestrictMovement _movementRestrictor;

    public Vector2Int Pos { get { return _pos; } }
    public OrientationManager OrientationManager { get { return _orientationManager; } }

    public Rover(int posX, int posY, OrientationManager orientation, IRestrictMovement movementRestrictor)
    {
        _pos = new Vector2Int(posX, posY);
        _orientationManager = orientation;
        _movementRestrictor = movementRestrictor;
    }

    public void ChangeOrientation(int newOrientationIndex)
    {
        _orientationManager.CurrentOrientationIndex = newOrientationIndex;
    }
    
    public void Move()
    {
        Vector2Int newPos = Pos + _orientationManager.CurrentOrientation.GetMoveInstruction();

        if (_movementRestrictor.CanMoveTo(newPos))
            _pos = newPos;
    }
    public void TurnLeft()
    {
        _orientationManager.CurrentOrientationIndex--;
    }
    public void TurnRight()
    {
        _orientationManager.CurrentOrientationIndex++;
    }
}
