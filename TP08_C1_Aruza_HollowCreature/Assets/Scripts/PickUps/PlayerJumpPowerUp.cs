using UnityEngine;

public class PlayerJumpPowerUp : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource jumpUpSound;
    [SerializeField] private PlayerJump player;
    [SerializeField] private float jumpUpAmount = 5f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetJumpUp(jumpUpAmount);
            jumpUpSound.Play();
            animator.SetTrigger("PickedUp");
            Destroy(gameObject, 1f);
        }
    }
}
