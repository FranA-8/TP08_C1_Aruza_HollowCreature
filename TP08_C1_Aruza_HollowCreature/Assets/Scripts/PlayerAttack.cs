using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Transform attackPosition;
    [SerializeField] private EnemyHealth health;
    [SerializeField] private Animator animator;
    private float attackDamage = 10f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            MeleeAttack();
        }
    }

    private void MeleeAttack()
    {
        animator.SetTrigger("IsAttacking");

        Collider2D[] colliders = Physics2D.OverlapCircleAll(attackPosition.position, 1f);
        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject.CompareTag("Enemy"))
            {
                if (health != null)
                {

                    health.EnemyTakeDamage(attackDamage);
                    animator.SetTrigger("IsAttacking");
                }
            }
        }

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPosition.position, 1f);
    }
}