using System.Collections.Generic;
using UnityEngine;

public class RoverBehaviour: MonoBehaviour
{
    RectangleMapRestrictor mapRestrictor = new RectangleMapRestrictor(5, 5);
    List<Rover> rovers=new List<Rover>();
    List<MoveCommand> commands = new List<MoveCommand>();
    private void Start()
    {
        

    }
}
