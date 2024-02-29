using UnityEngine;

namespace EnemyAI
{
    public class AnimationPlayer : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private float _speedMultiplier;
        
        private static readonly int AttackAnimation = Animator.StringToHash("Attack");

        public void PlayMoveAnimation(float speed) =>
            _animator.SetFloat("speed", speed * _speedMultiplier);

        public void PlayAttackAnimation() =>
            _animator.SetTrigger(AttackAnimation);

        public void PlayDeadAnimation() =>
            _animator.SetBool("dead", true);
    }
}