using UnityEngine;

namespace Player.Movement
{
    public class PlayerMovementSimple : IPlayerMovement
    {
        public void Move(Vector2 direction)
        {
            Debug.Log($"Caminando: {direction}");
        }
    }
}