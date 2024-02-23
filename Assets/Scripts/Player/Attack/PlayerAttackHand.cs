using UnityEngine;

namespace Player.Attack
{
    public class PlayerAttackHand : IPlayerAttack
    {
        public void Attack()
        {
            Debug.Log("Atacando con la mano");
        }
    }
}