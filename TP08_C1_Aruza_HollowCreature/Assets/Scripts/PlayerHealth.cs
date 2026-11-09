using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private InvencibilityManager manager;
    [SerializeField] private GameObject player;
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float currentHealth = 0f;
    [SerializeField] private Image healthBar;
    [SerializeField] private GameObject invencibility;
    private bool isInmortal = false;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void InvicibilityOn(bool value)
    {
        isInmortal = value;
    }
    public bool GetInvencibility(float amount)
    {
        return isInmortal;
    }
    public void PlayerTakeDamage(float amount)
    {
        if (isInmortal != true)
        {
            currentHealth -= amount;
            healthBar.fillAmount = currentHealth / maxHealth;
            if (currentHealth <= 0f)
            {
                Die();
            }
        }

    }

    public void Die()
    {
        Destroy(player, 1f);
    }

    public void GetHealthUp(float amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        healthBar.fillAmount = currentHealth / maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Invencibility"))
        {
            manager.ActivateInvencibility();

            Destroy(invencibility, 1f);
        }
    }
}