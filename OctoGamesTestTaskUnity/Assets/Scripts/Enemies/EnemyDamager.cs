using Opsive.UltimateCharacterController.Traits;
using UnityEngine;

namespace QulisoftTestTask.Enemies
{
    public class EnemyDamager : MonoBehaviour
    {
        [SerializeField] private float _damage;
        
        public void Damage(Health health)
        {
            health.Damage(_damage);
        }
    }
}