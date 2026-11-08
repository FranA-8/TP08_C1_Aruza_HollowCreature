using UnityEngine;

public class DamageUp : MonoBehaviour
{
    [SerializeField] private PlayerAttack player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetDamageUp(5);
            Destroy(gameObject, 1f);
        }
    }
}
