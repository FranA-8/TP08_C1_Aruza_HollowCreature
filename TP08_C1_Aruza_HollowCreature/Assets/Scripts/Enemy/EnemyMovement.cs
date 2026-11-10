using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private EnemyHealth enemyHealth;
    [SerializeField] private Animator animator;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private bool isFacingRight;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (enemyHealth.GetEnemyDead() == false)
        {
            animator.SetBool("IsMoving", true);
            rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Flip();
        }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 transformRotation = new Vector3(0f, transform.localRotation.y + 180f, 0f);
        moveSpeed *= -1;
    }
}
