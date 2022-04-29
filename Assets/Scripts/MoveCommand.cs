using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class MoveCommand
{
    IMove _mover;
    public IMove Mover
    {
        get { return _mover; }
        protected set { _mover = value; }
    }

    public abstract void ExecuteCommand();
}
