using TMPro;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    [SerializeField] private TMP_Text collectableText;
    private int collectableAmaunt;
    public void GetCollectable(int amount)
    {
        collectableAmaunt += amount;
        collectableText.text = collectableAmaunt.ToString("f0");
    }

    public int ReturnCollectable(int value)
    {
        return collectableAmaunt;
    }
}
