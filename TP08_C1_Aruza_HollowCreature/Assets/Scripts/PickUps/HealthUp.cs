using UnityEngine;

public class HealthUp : MonoBehaviour
{
    [SerializeField] private AudioSource healthUpSound;
    [SerializeField] private PlayerHealth player;
    [SerializeField] private float healthUpAmount = 20f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetHealthUp(healthUpAmount);
            healthUpSound.Play();
            Destroy(gameObject, 1f);
        }
    }
}
