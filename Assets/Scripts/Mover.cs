using UnityEngine;

public class Mover : IMove, IChangeOrientation
{
    protected Vector2Int _pos;
    protected OrientationManager _orientationManager;
    protected IRestrictMovement _movementRestrictor;

    public Vector2Int Pos { 
        get { return _pos; }
        set
        {
            if (_movementRestrictor.CanMoveTo(value))
            {
                _pos = value;
            }
            else if (_pos == null)
            {
                _pos = Vector2Int.zero;
            }
        }
    }
    public OrientationManager OrientationManager { get { return _orientationManager; } }
    public Mover DeepCopy
    {
        get
        {
            return new Mover(
          _pos.x,
          _pos.y,
          _orientationManager.DeepCopy,
          _movementRestrictor.DeepCopy());
        }
    }

    public Mover(int posX, int posY, OrientationManager orientation, IRestrictMovement movementRestrictor)
    {
        _movementRestrictor = movementRestrictor;
        _orientationManager = orientation;
        Pos = new Vector2Int(posX, posY);
    }


    public void ChangeOrientation(int newOrientationIndex)
    {
        _orientationManager.CurrentOrientationIndex = newOrientationIndex;
    }
    public void ChangeOrientation(string newOrientationString)
    {
        _orientationManager.CurrentOrientationString = newOrientationString;
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
