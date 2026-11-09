using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource collectableSound;
    [SerializeField] private CollectableManager collectableManager;
    private int collectableValue = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            collectableManager.GetCollectable(collectableValue);
            collectableSound.Play();
            animator.SetTrigger("PickedUp");
            Destroy(gameObject, 1f);
        }
    }
}
