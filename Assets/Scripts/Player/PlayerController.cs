using Player.Attack;
using Player.Movement;
using UnityEngine;

namespace Player
{
    public class PlayerController: MonoBehaviour
    {
        private IPlayerMovement _playerMovement;
        private IPlayerAttack _playerAttack;

        private void Awake()
        {

            _playerAttack = new PlayerAttackWeapon();
            _playerMovement = new PlayerMovementJumping();
        }

        private void Update()
        {
            // Cambiar estilo de ataque y movimiento
            if (Input.GetKeyDown(KeyCode.Y))
            {
                _playerAttack = new PlayerAttackHand();
            }

            if (Input.GetKeyDown(KeyCode.U))
            {
                _playerAttack = new PlayerAttackWeapon();
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                _playerMovement = new PlayerMovementSimple();
            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                _playerMovement = new PlayerMovementJumping();
            }
            
            // Moverse y atacar
            int horizontal = (int)Input.GetAxisRaw("Horizontal");
            int vertical = (int)Input.GetAxisRaw("Vertical");
            Vector2 direction = new Vector2(horizontal, vertical);
            if (direction != Vector2.zero)
            {
                _playerMovement.Move(direction);
                
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _playerAttack.Attack();
            }
        }
    }
}