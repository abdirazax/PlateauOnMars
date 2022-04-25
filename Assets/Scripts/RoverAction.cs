using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RoverAction
{
    // 0 - do nothing
    // 1 - move forward
    // 2 - turn left
    // 3 - turn right
    private int _actionValue = 0;

    public int Action
    {
        get { return _actionValue; }
        set
        {
            if (value >= 0 && value <= 3)
                _actionValue = value;
        }
    }
    public Vector2Int ActionInVector2Int
    {
        get { return ConvertFromRoverActionToVector2Int(Action); }
        set { Action = ConvertFromVector2IntToRoverAction(value); }
    }
    public string ActionInString
    {
        set { Action = ConvertFromStringToRoverAction(value); }
    }

    public RoverAction(string action)
    {
        Action = ConvertFromStringToRoverAction(action);
    }
    public RoverAction(Vector2Int action)
    {
        Action = ConvertFromVector2IntToRoverAction(action);
    }
    public RoverAction(int action)
    {
        Action = action;
    }
    public RoverAction()
    {
    }

    public static int ConvertFromStringToRoverAction(string actionInString)
    {
        switch (actionInString)
        {
            case "M" or "m":
                return 1;
                break;
            case "L" or "l":
                return 2;
                break;
            case "R" or "r":
                return 3;
                break;
            default:
                return -1;
                break;
        }
    }
    public static int ConvertFromVector2IntToRoverAction(Vector2Int actionInVector2Int)
    {

        if (actionInVector2Int == Vector2Int.up)
            return 1;
        else if (actionInVector2Int == Vector2Int.left)
            return 2;
        else if (actionInVector2Int == Vector2Int.right)
            return 3;
        return -1;
    }
    public static Vector2Int ConvertFromRoverActionToVector2Int(int action)
    {
        if (action == 1)
            return Vector2Int.up;
        else if (action == 2)
            return Vector2Int.left;
        else if (action == 3)
            return Vector2Int.right;
        else
            return Vector2Int.zero;
    }

}