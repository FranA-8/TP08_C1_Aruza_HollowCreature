using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private float jumpForce = 8.5f;
    private Rigidbody2D rb;
    bool canJump = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            canJump = true;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            canJump = false;
        }
    }
    private void Update()
    {
        if (canJump == true && (Input.GetKeyDown(KeyCode.Space)))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            canJump = false;
        }

    }
}
