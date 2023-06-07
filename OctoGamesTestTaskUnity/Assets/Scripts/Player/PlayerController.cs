using System;
using QulisoftTestTask.ScriptableObjects;
using UnityEngine;

namespace QulisoftTestTask.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private EventSO _onEnemyKilled;
        [SerializeField] private PlayerEnemyKilledCounter _enemyKilledCounter;

        private void OnEnable()
        {
            _onEnemyKilled.OnInvoked += _enemyKilledCounter.EnemyKilled;
        }

        private void OnDisable()
        {
            _onEnemyKilled.OnInvoked -= _enemyKilledCounter.EnemyKilled;
        }
    }
}