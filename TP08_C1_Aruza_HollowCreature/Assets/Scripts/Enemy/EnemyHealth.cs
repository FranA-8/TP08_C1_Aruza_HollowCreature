using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private AudioSource enemyDeath;
    [SerializeField] private AudioSource enemyHitSound;
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject enemy;
    private float maxHealth = 50f;
    private float currentHealth = 0f;
    [SerializeField] private Image healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void EnemyTakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.fillAmount = currentHealth / maxHealth;
        EnemyHealth health = GetComponent<EnemyHealth>();
        enemyHitSound.Play();
        if (currentHealth <= 0f && health != null)
        {
            EnemyDie();
        }
    }

    private void EnemyDie()
    {
        enemyDeath.Play();
        animator.SetTrigger("HasDied");
        Destroy(gameObject, 1f);
    }

    public bool GetEnemyDead()
    {
        bool isDead = false;
        if (currentHealth <= 0f)
        {
            isDead = true;
        }
        return isDead;
    }
}
