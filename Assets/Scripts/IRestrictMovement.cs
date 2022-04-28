using UnityEngine;

public interface IRestrictMovement
{
    public bool CanMoveTo(Vector2Int destination);
}