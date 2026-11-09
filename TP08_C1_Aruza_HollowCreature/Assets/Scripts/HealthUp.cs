using UnityEngine;

public class HealthUp : MonoBehaviour
{
    [SerializeField] private PlayerHealth player;
    [SerializeField] private float healthUpAmount = 20f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetHealthUp(healthUpAmount);
            Destroy(gameObject, 1f);
        }
    }
}
