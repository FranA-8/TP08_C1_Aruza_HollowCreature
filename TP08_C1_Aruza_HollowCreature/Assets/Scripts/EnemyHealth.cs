using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
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
        if (currentHealth <= 0f)
        {
            EnemyDie();
        }
    }

    private void EnemyDie()
    {
        Destroy(enemy, 1f);
    }
}
