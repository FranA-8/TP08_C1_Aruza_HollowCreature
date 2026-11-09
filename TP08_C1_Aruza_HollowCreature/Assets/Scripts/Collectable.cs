using TMPro;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private TMP_Text cointText;
    private float coinAmaunt;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            coinAmaunt++;

            cointText.text = coinAmaunt.ToString("f0");

            Destroy(gameObject, 1f);
        }
    }
}
