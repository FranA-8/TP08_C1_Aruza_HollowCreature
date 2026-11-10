using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private AudioSource attackSound;
    [SerializeField] PlayerHealth health;
    private float attackDamage = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (health != null)
            {
                attackSound.Play();
                health.PlayerTakeDamage(attackDamage);
            }
        }
    }
}
