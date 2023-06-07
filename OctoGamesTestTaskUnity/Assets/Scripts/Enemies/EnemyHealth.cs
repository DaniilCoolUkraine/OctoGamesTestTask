using Opsive.UltimateCharacterController.Traits;
using UnityEngine;
using UnityEngine.AI;

namespace QulisoftTestTask.Enemies
{
    public class EnemyHealth : CharacterHealth
    {
        private Animator _animator;
        private Rigidbody _rigidbody;
        private NavMeshAgent _agent;

        protected override void Awake()
        {
            base.Awake();

            _animator = GetComponent<Animator>();
            _rigidbody = GetComponent<Rigidbody>();
            _agent = GetComponent<NavMeshAgent>(); 
        }

        private void OnDisable()
        {
            SwitchRagdoll();
        }
        
        public override void Die(Vector3 position, Vector3 force, GameObject attacker)
        {
            base.Die(position, force, attacker);
            SwitchRagdoll();
            
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.AddForce(Vector3.up * 10000);
        }
        
        private void SwitchRagdoll()
        {
            if (_rigidbody.constraints == RigidbodyConstraints.FreezeAll)
                _rigidbody.constraints = RigidbodyConstraints.None;
            else
                _rigidbody.constraints = RigidbodyConstraints.FreezeAll;

            _animator.enabled = !_animator.enabled;
            _rigidbody.isKinematic = !_rigidbody.isKinematic;
            _agent.enabled = !_agent.enabled;
        }
    }
}