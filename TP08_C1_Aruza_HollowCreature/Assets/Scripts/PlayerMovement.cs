using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private Rigidbody2D rb;
    private float moveSpeed = 1000f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        animator.SetBool("IsRunning", false);
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("IsRunning", true);
            rb.AddForce(Vector2.right * (moveSpeed * Time.deltaTime), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("IsRunning", true);
            rb.AddForce(Vector2.left * (moveSpeed * Time.deltaTime), ForceMode2D.Force);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.right = Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.right = Vector3.left;
        }
    }
}
