using System.Collections.Generic;
using EnemyAI.StateMachine.States;
using UnityEngine;

namespace EnemyAI.StateMachine
{
    public class EnemyStateMachine : MonoBehaviour
    {
        [SerializeField] private List<IState> _states;
        private IState _currentState;
        
        public void EnterState(IState state)
        {
            ExitState();
            _currentState = state;
            _currentState.Enter();
        }

        private void ExitState()
        {
            _currentState.Exit();
        }
    }
}
