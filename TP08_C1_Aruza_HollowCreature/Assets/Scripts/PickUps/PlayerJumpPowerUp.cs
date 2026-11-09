using UnityEngine;

public class PlayerJumpPowerUp : MonoBehaviour
{
    [SerializeField] private PlayerJump player;
    [SerializeField] private float jumpUpAmount = 5f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetJumpUp(jumpUpAmount);
            Destroy(gameObject, 1f);
        }
    }
}
