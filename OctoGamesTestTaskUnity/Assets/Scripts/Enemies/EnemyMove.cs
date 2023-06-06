using UnityEngine;
using UnityEngine.AI;

namespace QulisoftTestTask.Enemies
{
    public class EnemyMove : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent _agent;
        private Transform _target;

        private void Update()
        {
            if (_agent.enabled)
            {
                _agent.SetDestination(_target.position);
            }
        }

        public void SetTarget(Transform target)
        {
            _target = target;
        }
    }
}
