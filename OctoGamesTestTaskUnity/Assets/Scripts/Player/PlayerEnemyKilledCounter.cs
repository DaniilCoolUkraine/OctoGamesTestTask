using QulisoftTestTask.ScriptableObjects;
using UnityEngine;

namespace QulisoftTestTask.Player
{
    public class PlayerEnemyKilledCounter : MonoBehaviour
    {
        [SerializeField] private IntEventSO _onCounterValueChanged;
        
        private int _killedEnemyCount;

        public int KilledEnemyCount
        {
            get => _killedEnemyCount;
            private set
            {
                _killedEnemyCount = value;
                _onCounterValueChanged.ChangeValue(_killedEnemyCount);
            }
        }
        private void Start()
        {
            KilledEnemyCount = 0;
        }
        public void EnemyKilled()
        {
            KilledEnemyCount++;
        }
    }
}