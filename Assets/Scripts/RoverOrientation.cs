using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RoverOrientation
{
    // 0 - North
    // 1 - East
    // 2 - South
    // 3 - West
    private int _orientationValue = 0;

    public int Orientation
    {
        get { return _orientationValue; }
        set
        {
            if (value >= 0 && value <= 3)
                _orientationValue = value;
        }
    }
    public Vector2Int OrientationInVector2Int
    {
        get { return ConvertFromRoverOrientationToVector2Int(Orientation); }
        set { Orientation = ConvertFromVector2IntToRoverOrientation(value); }
    } 
    public string OrientationInString
    {
        set { Orientation = ConvertFromStringToRoverOrientation(value); }
    }

    public RoverOrientation(string orientation)
    {
        Orientation = ConvertFromStringToRoverOrientation(orientation);
    }
    public RoverOrientation(Vector2Int orientation)
    {
        Orientation = ConvertFromVector2IntToRoverOrientation(orientation);
    }
    public RoverOrientation(int orientation)
    {
        Orientation = orientation;
    }

    public RoverOrientation()
    {
    }


    public static int ConvertFromStringToRoverOrientation(string orientationInString)
    {
        switch (orientationInString)
        {
            case "N" or "n":
                return 0;
                break;
            case "E" or "e":
                return 1;
                break;
            case "S" or "s":
                return 2;
                break;
            case "W" or "w":
                return 3;
                break;
            default:
                return -1;
                break;
        }
    }
    public static int ConvertFromVector2IntToRoverOrientation(Vector2Int orientationInVector2Int)
    {

        if (orientationInVector2Int == Vector2Int.up)
            return 0;
        else if (orientationInVector2Int == Vector2Int.right)
            return 1;
        else if (orientationInVector2Int == Vector2Int.down)
            return 2;
        else if (orientationInVector2Int == Vector2Int.left)
            return 3;
        return -1;
    }
    public static Vector2Int ConvertFromRoverOrientationToVector2Int(int orientation)
    {
        if (orientation == 0)
            return Vector2Int.up;
        else if (orientation == 1)
            return Vector2Int.right;
        else if (orientation == 2)
            return Vector2Int.down;
        else if (orientation == 3)
            return Vector2Int.left;
        else
            return Vector2Int.zero;
    }

}