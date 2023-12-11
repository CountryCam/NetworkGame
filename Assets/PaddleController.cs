using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float paddleSpeed = 10.0f; // Adjust this to control paddle speed
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get player input (e.g., arrow keys or WASD)
        float moveInput = Input.GetAxis("Vertical"); // Change to match your input axis

        // Calculate movement vector
        Vector2 movement = new Vector2(0.0f, moveInput) * paddleSpeed * Time.deltaTime;

        // Apply movement to the paddle using Rigidbody2D
        rb.MovePosition(rb.position + movement);
    }
}
