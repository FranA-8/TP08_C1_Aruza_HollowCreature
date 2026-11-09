using TMPro;
using UnityEngine;

public class InvencibilityManager : MonoBehaviour
{
    [SerializeField] private PlayerHealth player;
    [SerializeField] private GameObject invencibilityCountDownPanel;
    [SerializeField] private TMP_Text invencibilityNumberText;

    [SerializeField] private float invencibilityTimer = 5f;

    private float timer;
    private bool collected = false;

    public void ActivateInvencibility()
    {
        player.InvicibilityOn(true);

        timer = invencibilityTimer;

        collected = true;
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
                player.InvicibilityOn(false);

                invencibilityCountDownPanel.SetActive(false);

                collected = false;

                timer = invencibilityTimer;
            }
        }
    }
}
