using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public float rollSpeed = 5f;
    public float jumpForce = 25;
    public GameObject winText;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    void FixedUpdate()
    {
        if (rb.linearVelocity.x < rollSpeed)
        {
            rb.AddForce(Vector2.right * 70f); 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Hit an obstacle! Restarting...");

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            Debug.Log("YOU WIN!");
            winText.SetActive(true);
            rollSpeed = 0;
            rb.linearVelocity = Vector2.zero;
        }
    }
}
