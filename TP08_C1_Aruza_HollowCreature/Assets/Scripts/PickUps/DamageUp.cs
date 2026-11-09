using System;
using UnityEngine;

public class DamageUp : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource damageUpSound;
    [SerializeField] private PlayerAttack player;
    [SerializeField] private float damageUpAmount = 5f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetDamageUp(damageUpAmount);
            damageUpSound.Play();
            animator.SetTrigger("PickedUp");
            Destroy(gameObject, 1f);
        }
    }
}
