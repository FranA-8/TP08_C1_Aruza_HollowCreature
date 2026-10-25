using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 1000f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {

            rb.AddForce(Vector2.right * (moveSpeed * Time.deltaTime), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {

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
