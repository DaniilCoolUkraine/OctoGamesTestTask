using Opsive.UltimateCharacterController.Traits;
using QulisoftTestTask.Enemies;
using UnityEngine;

namespace QulisoftTestTask.Player
{
    public class PlayerGetDamage : MonoBehaviour
    {
        [SerializeField] private CharacterHealth _health;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Enemy"))
            {
                other.GetComponentInParent<EnemyDamager>().Damage(_health);
            }
        }
    }
}