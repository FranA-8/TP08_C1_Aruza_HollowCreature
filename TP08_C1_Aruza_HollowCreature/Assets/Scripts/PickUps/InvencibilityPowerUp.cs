using TMPro;
using UnityEngine;

public class InvencibilityPowerUp : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource invencibilityUpSound;
    [SerializeField] private PlayerHealth player;
    [SerializeField] private GameObject invencibilityCountDownPanel;
    [SerializeField] private TMP_Text invencibilityNumberText;
    [SerializeField] private float invencibilityTimer = 5;
    private float timer;
    private bool collected = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.InvicibilityOn(true);
            invencibilityUpSound.Play();
            animator.SetTrigger("PickedUp");
            timer = invencibilityTimer;
            collected = true;
        }
    }
    private void Update()
    {
        if (collected == true)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                player.InvicibilityOn(false);

                collected = false;

                timer = invencibilityTimer;
            }
        }
    }
}
