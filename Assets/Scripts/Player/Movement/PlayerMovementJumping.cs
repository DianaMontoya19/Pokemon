using UnityEngine;

namespace Player.Movement
{
    public class PlayerMovementJumping : IPlayerMovement
    {
        public void Move(Vector2 direction)
        {
            Debug.Log($"Salto: {direction}");
        }
    }
}