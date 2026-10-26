using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] EnemyHealth health;
    private float attackDamage = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (health != null)
            {
                health.EnemyTakeDamage(attackDamage);
            }
        }
    }
}
