using TMPro;
using UnityEngine;

public class InvencibilityPowerUp : MonoBehaviour
{
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
            timer = invencibilityTimer;
            collected = true;
        }
    }
    private void Update()
    {
        if (collected == true)
        {
            timer -= Time.deltaTime;

            invencibilityCountDownPanel.SetActive(true);

            invencibilityNumberText.text = timer.ToString("f0");

            if (timer <= 0)
            {
                invencibilityCountDownPanel.SetActive(false);

                player.InvicibilityOn(false);

                collected = false;

                timer = invencibilityTimer;
            }
        }
    }
}
