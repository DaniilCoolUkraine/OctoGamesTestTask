using QulisoftTestTask.ScriptableObjects;
using UnityEngine;

namespace QulisoftTestTask.Enemies
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private EnemyMovement _enemyMovement;
        [SerializeField] private EnemyHealth _enemyHealth;
        
        public void Initialize(Transform target, EventSO onDie)
        {
            _enemyMovement.SetTarget(target);
            _enemyHealth.OnDeathEvent.AddListener(((arg0, vector3, o) => onDie.Invoke()));
        }
    }
}