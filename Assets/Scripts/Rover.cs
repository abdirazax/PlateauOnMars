using System.Collections;
using UnityEngine;
public class Rover : Mover
{
    public Rover(int posX,
                 int posY,
                 OrientationManager orientation,
                 IRestrictMovement movementRestrictor) : base(posX,
                                                              posY,
                                                              orientation,
                                                              movementRestrictor)
    {
    }
}
