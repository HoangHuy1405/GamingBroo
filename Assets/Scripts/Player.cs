using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the user
        float moveX = Input.GetAxis("Horizontal");  // Left/Right arrow keys or A/D keys
        float moveY = Input.GetAxis("Vertical");    // Up/Down arrow keys or W/S keys

        // Create a new Vector2 with the input
        movement = new Vector2(moveX, moveY);
    }
    private void FixedUpdate() {
        rb.MovePosition(rb.position + movement*moveSpeed*Time.fixedDeltaTime);
    }
}
