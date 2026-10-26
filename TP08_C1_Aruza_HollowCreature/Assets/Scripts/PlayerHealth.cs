using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private float maxHealth = 100f;
    private float currentHealth = 0f;
    [SerializeField] private Image healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void PlayerTakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.fillAmount = currentHealth / maxHealth;
        if (currentHealth <= 0f)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(player, 1f);
    }
}
