using UnityEngine;

namespace EnemyAI.StateMachine.States
{
    public abstract class State : IState
    {
        public virtual void Enter() {}
        public virtual void Exit() {}
    }
}
