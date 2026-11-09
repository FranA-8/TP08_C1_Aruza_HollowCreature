using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Game/Player")]

public class PlayerDataSo : ScriptableObject
{
    [Header("Health")]
    public float playerMaxHealth = 100f;

    [Header("Damage")]
    public float playerDamage = 25f;

    [Header("Jump")]
    public float playerJumpForce = 15f;
}
