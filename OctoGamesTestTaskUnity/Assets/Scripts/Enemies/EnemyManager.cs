using System.Collections;
using QulisoftTestTask.ScriptableObjects;
using UnityEngine;

namespace QulisoftTestTask.Enemies
{
    public class EnemyManager : MonoBehaviour
    {
        [SerializeField] private EventSO _onEnemyKilled;
        
        [SerializeField] private int _maxEnemiesCount = 40;
        [SerializeField] private GameObject _enemyPrefab;

        [SerializeField] private Transform[] _spawnPoints;
        [SerializeField] private float _timeBetweenSpawn;
        
        [SerializeField] private Transform _player;

        private void Start()
        {
            StartCoroutine(SpawnEnemies());
        }

        private IEnumerator SpawnEnemies()
        {
            for (int i = 0; i < _maxEnemiesCount; i++)
            {
                var lastEnemy = Instantiate(_enemyPrefab, _spawnPoints[Random.Range(0, _spawnPoints.Length)].position, Quaternion.identity);
                
                lastEnemy.GetComponent<EnemyController>().Initialize(_player, _onEnemyKilled);
                
                yield return new WaitForSeconds(_timeBetweenSpawn);
            }
        }
    }
}