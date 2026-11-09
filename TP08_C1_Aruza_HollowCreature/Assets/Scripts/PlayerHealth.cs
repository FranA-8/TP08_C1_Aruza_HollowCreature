using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private AudioSource invencibilitySound;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource damageSound;
    [SerializeField] private AudioSource deathSound;
    [SerializeField] private PlayerDataSo data;
    [SerializeField] private InvencibilityManager manager;
    [SerializeField] private GameObject player;
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float currentHealth = 0f;
    [SerializeField] private Image healthBar;
    [SerializeField] private GameObject invencibility;
    private bool isInmortal = false;
    private bool isDead = false;
    private float timer;
    private float deathTimer = 2f;

    private void Start()
    {
        maxHealth = data.playerMaxHealth;
        currentHealth = maxHealth;
        healthBar.fillAmount = currentHealth / maxHealth;
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
            damageSound.Play();
            if (currentHealth <= 0f)
            {
                Die();
            }
        }

    }

    public void Die()
    {
        animator.SetTrigger("HasDied");
        deathSound.Play();
        Destroy(player, 2f);
    }
    private void Update()
    {
        if (isDead == true)
        {
            timer = deathTimer;
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                gameOverPanel.SetActive(true);
            }
        }

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