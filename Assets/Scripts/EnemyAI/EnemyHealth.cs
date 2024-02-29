using UnityEngine.Events;
using UnityEngine;

namespace EnemyAI
{
    public class EnemyHealth : MonoBehaviour
    {
        [SerializeField] private float _healthAmount = 100.0f;

        public event UnityAction OnHealthChanged; 

        public float Amount => _healthAmount;

        public void TakeDamage(float damage)
        {
            _healthAmount -= damage;
            OnHealthChanged?.Invoke();
        }
    }
}
