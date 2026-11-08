using UnityEngine;

public class HealthUp : MonoBehaviour
{
    [SerializeField] private PlayerHealth player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetHealthUp(20);
            Destroy(gameObject, 1f);
        }
    }
}
