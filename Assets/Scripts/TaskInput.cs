using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskInput
{
    [SerializeField]
    int _plateauSizeX = 1;
    [SerializeField]
    int _plateauSizeY = 1;
    [SerializeField]
    List<Rover> _rovers = new List<Rover>();

    public TaskInput()
    {
    }

    public TaskInput(int plateauSizeX, int plateauSizeY,List<Rover> rovers)
    {
        _plateauSizeX = plateauSizeX;
        _plateauSizeY = plateauSizeY;
        _rovers = rovers;
    }

    

}
