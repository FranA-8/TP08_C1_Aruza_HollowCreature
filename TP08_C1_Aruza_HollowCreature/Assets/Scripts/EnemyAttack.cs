using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] PlayerHealth health;
    private float attackDamage = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (health != null)
            {
                health.PlayerTakeDamage(attackDamage);
            }
        }
    }
}
