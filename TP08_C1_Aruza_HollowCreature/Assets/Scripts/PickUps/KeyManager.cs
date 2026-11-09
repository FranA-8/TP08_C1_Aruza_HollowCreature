using TMPro;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    [SerializeField] private TMP_Text keyText;
    [SerializeField] private GameObject finalDoor;
    private int collectableAmaunt;
    private int neededKeys = 5;
    public void GetCollectable(int amount)
    {
        collectableAmaunt += amount;
        keyText.text = collectableAmaunt.ToString("f0");
    }

    public int ReturnCollectable(int value)
    {
        return collectableAmaunt;
    }
    private void Update()
    {
        if (collectableAmaunt == neededKeys)
        {
            Destroy(finalDoor, 2f);
        }
    }
}
