using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private KeyManager keyManager;
    private int collectableValue = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            keyManager.GetCollectable(collectableValue);
            Destroy(gameObject, 1f);
        }
    }
}
