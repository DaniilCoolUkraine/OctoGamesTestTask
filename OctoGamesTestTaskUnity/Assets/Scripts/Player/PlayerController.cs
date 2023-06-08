using Opsive.Shared.Input;
using Opsive.UltimateCharacterController.Traits;
using QulisoftTestTask.ScriptableObjects;
using UnityEngine;

namespace QulisoftTestTask.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private EventSO _onEnemyKilled;
        [SerializeField] private EventSO _onPlayerDeath;

        [SerializeField] private CharacterHealth _characterHealth;
        [SerializeField] private UnityInput _unityInput;
        
        [SerializeField] private PlayerEnemyKilledCounter _enemyKilledCounter;

        private void OnEnable()
        {
            _onEnemyKilled.OnInvoked += _enemyKilledCounter.EnemyKilled;
            _characterHealth.OnDeathEvent.AddListener(((arg0, vector3, o) =>
            {
                _unityInput.DisableCursor = false;
                _onPlayerDeath.Invoke();
            }));
        }

        private void OnDisable()
        {
            _onEnemyKilled.OnInvoked -= _enemyKilledCounter.EnemyKilled;
        }
    }
}