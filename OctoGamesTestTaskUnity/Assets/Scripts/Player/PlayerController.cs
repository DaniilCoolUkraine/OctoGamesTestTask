using Opsive.UltimateCharacterController.Traits;
using QulisoftTestTask.ScriptableObjects;
using UnityEngine;

namespace QulisoftTestTask.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private EventSO _onEnemyKilled;
        [SerializeField] private EventSO _onPlayerDeath;
        
        [SerializeField] private PlayerEnemyKilledCounter _enemyKilledCounter;
        [SerializeField] private CharacterHealth _characterHealth;

        private void OnEnable()
        {
            _onEnemyKilled.OnInvoked += _enemyKilledCounter.EnemyKilled;
            _characterHealth.OnDeathEvent.AddListener(((arg0, vector3, o) => _onPlayerDeath.Invoke()));
        }

        private void OnDisable()
        {
            _onEnemyKilled.OnInvoked -= _enemyKilledCounter.EnemyKilled;
        }
    }
}