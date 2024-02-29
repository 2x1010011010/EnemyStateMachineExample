using UnityEngine;
using EnemyAI.StateMachine;
using EnemyAI.StateMachine.States;

namespace EnemyAI
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private EnemyHealth _health;
        [SerializeField] private EnemyStateMachine _stateMachine;
        
        
        private void Start()
        {
            _health.OnHealthChanged += OnHealthChanged;
        }

        private void OnHealthChanged()
        {
            if (_health.Amount == 0)
            {
                _stateMachine.EnterState();
            }
        }
    }
}
