using UnityEngine;

namespace Player.Attack
{
    public class PlayerAttackWeapon : IPlayerAttack
    {
        public void Attack()
        {
            Debug.Log("Atacando con mi arma");
        }
    }
}