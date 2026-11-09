using UnityEngine;

public class VictoryZone : MonoBehaviour
{
    [SerializeField] private AudioSource victorySound;
    [SerializeField] private GameObject victoryPanel;
    [SerializeField] private GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            victoryPanel.SetActive(true);
            Time.timeScale = 0f;
            victorySound.Play();
            Destroy(player, 1f);
        }
    }
}
