using System.Collections.Generic;
using UnityEngine;

public class TaskInputVRKeys : TaskInput
{

    public void AddNewStandardMover()
    {
        _moveCommandManagers.Add(
            new MoveCommandsManager(
                new Mover(0,
                          0,
                          new NESWOrientationManager(0),
                          _movementRestrictor)));
        _lastMoverPosX = "";
        _lastMoverPosY = "";
        DisplayInput();
    }


    protected string _lastMoverPosX="";
    protected string _lastMoverPosY="";
    public void AddCharToLastMoverPosXString(string letter)
    {
        _lastMoverPosX += letter;
        SetLastMoverPositionX(_lastMoverPosX);
        _lastMoverPosX = GetLastMoverPositionX();
    }
    public void AddCharToLastMoverPosYString(string letter)
    {
        _lastMoverPosY += letter;
        SetLastMoverPositionY(_lastMoverPosY);
        _lastMoverPosY = GetLastMoverPositionY();
    }
    protected void SetLastMoverPositionX(string positionX)
    {
        if (int.TryParse(positionX, out int n))
            SetLastMoverPositionX(n);
        if (positionX == "")
        {
            SetLastMoverPositionX(0);
            return;
        }
    }
    protected void SetLastMoverPositionY(string positionY)
    {
        if (positionY == "")
        {
            SetLastMoverPositionY(0);
            return;
        }
        if (int.TryParse(positionY, out int n))
            SetLastMoverPositionY(n);
        
    }
    protected void SetLastMoverPosition(int x, int y)
    {
        if (_moveCommandManagers.Count > 0)
        {
            _moveCommandManagers[_moveCommandManagers.Count - 1].
                Mover.Pos = new Vector2Int(x, y);
        }
        DisplayInput();
    }
    protected void SetLastMoverPositionX(int x)
    {
        SetLastMoverPosition(
            x,
            _moveCommandManagers[_moveCommandManagers.Count - 1].Mover.Pos.y);
    }
    protected void SetLastMoverPositionY(int y)
    {
        SetLastMoverPosition(
            _moveCommandManagers[_moveCommandManagers.Count - 1].Mover.Pos.x,
            y);
    }
    protected string GetLastMoverPositionX()
    {
        return _moveCommandManagers[_moveCommandManagers.Count - 1].Mover.Pos.x.ToString();
    }
    protected string GetLastMoverPositionY()
    {
        return _moveCommandManagers[_moveCommandManagers.Count - 1].Mover.Pos.y.ToString();
    }
    public void RemoveFromLastMoverPosXString()
    {
        _lastMoverPosX = _lastMoverPosX.Remove(_lastMoverPosX.Length - 1); 
        SetLastMoverPositionX(_lastMoverPosX);
    }
    public void RemoveFromLastMoverPosYString()
    {
        _lastMoverPosY = _lastMoverPosY.Remove(_lastMoverPosY.Length - 1);
        SetLastMoverPositionY(_lastMoverPosY);
    }



    public void SetLastMoverOrientation(string newOrientation)
    {
        if (_moveCommandManagers.Count > 0)
        {
            _moveCommandManagers[_moveCommandManagers.Count - 1].
                Mover.ChangeOrientation(newOrientation);
        }
        DisplayInput();
    }

    public void RemoveLastCommandFromLastMoverOrRemoveLastMoverIfNoCommandsLeft()
    {
        if (_moveCommandManagers.Count > 0)
        {
            if (_moveCommandManagers[_moveCommandManagers.Count - 1].CommandsCount > 0)
                _moveCommandManagers[_moveCommandManagers.Count - 1].CancelLastCommand();
            else
            {
                _moveCommandManagers.RemoveAt(_moveCommandManagers.Count - 1);
                _lastMoverPosX = "";
                _lastMoverPosY = "";
            }
        }
        DisplayInput();
    }
 

    public void IncreaseMapSizeX()
    {
        SetMapSize(PlateauSizeX + 1, PlateauSizeY);
    }
    public void IncreaseMapSizeY()
    {
        SetMapSize(PlateauSizeX, PlateauSizeY + 1);
    }
    public void DecreaseMapSizeX()
    {
        SetMapSize(PlateauSizeX - 1, PlateauSizeY);
    }
    public void DecreaseMapSizeY()
    {
        SetMapSize(PlateauSizeX, PlateauSizeY - 1);
    }




}
