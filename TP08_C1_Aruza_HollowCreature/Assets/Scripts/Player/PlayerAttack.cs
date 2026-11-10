using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private UiPauseMenu pauseMenu;
    [SerializeField] private AudioSource attackSound;
    [SerializeField] private PlayerDataSo data;
    [SerializeField] private Transform attackPosition;
    [SerializeField] private EnemyHealth health;
    [SerializeField] private Animator animator;
    [SerializeField] private float attackDamage = 10f;
    [SerializeField] private float maxDamage = 30f;

    private void Start()
    {
        attackDamage = data.playerDamage;
    }
    private void Update()
    {
        if (pauseMenu.isPaused == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                MeleeAttack();
                attackSound.Play();
            }
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
                EnemyHealth health = collider.GetComponent<EnemyHealth>();

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
    public void GetDamageUp(float amount)
    {
        attackDamage += amount;
        if (attackDamage > maxDamage)
        {
            attackDamage = maxDamage;
        }
    }
}