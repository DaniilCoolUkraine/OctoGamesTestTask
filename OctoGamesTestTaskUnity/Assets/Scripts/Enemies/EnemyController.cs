using UnityEngine;
using UnityEngine.AI;

namespace QulisoftTestTask.Enemies
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent _agent;
        private Transform _target;

        private void Update()
        {
            _agent.SetDestination(_target.position);
        }

        public void SetTarget(Transform target)
        {
            _target = target;
        }
    }
}
