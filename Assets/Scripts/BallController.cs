using UnityEngine;

public class BallController : MonoBehaviour
{
    public float jumpForce = 3f; // Adjust the force applied when jumping
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        // Get the Rigidbody component attached to the ball
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if the spacebar is pressed and if the ball is grounded
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // Apply an upward force to make the ball jump
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the ball is touching the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // When the ball leaves the ground, it's no longer grounded
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
