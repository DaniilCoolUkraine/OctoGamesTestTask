using System.Collections;
using UnityEngine;

namespace QulisoftTestTask.Enemies
{
    public class EnemyManager : MonoBehaviour
    {
        [SerializeField] private int _maxZombieCount = 40;
        [SerializeField] private GameObject _zombiePrefab;

        [SerializeField] private Transform[] _spawnPoints;
        [SerializeField] private float _timeBetweenSpawn;
        
        [SerializeField] private Transform _player;

        private void Start()
        {
            StartCoroutine(SpawnZombies());
        }

        private IEnumerator SpawnZombies()
        {
            GameObject lastZombie;
            for (int i = 0; i < _maxZombieCount; i++)
            {
                lastZombie = Instantiate(_zombiePrefab, _spawnPoints[Random.Range(0, _spawnPoints.Length)].position, Quaternion.identity);
                
                lastZombie.GetComponent<EnemyController>().SetTarget(_player);
                
                yield return new WaitForSeconds(_timeBetweenSpawn);
            }
        }
    }
}