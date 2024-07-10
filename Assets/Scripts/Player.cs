using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : LivingEntity
{
    private Rigidbody2D rb;
    private Camera mainCam;
    private Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() {
        MovePlayer();
        DirectionPlayer();
    }
    private void MovePlayer() {
        // Get input from the user
        float moveX = Input.GetAxis("Horizontal");  // Left/Right arrow keys or A/D keys
        float moveY = Input.GetAxis("Vertical");    // Up/Down arrow keys or W/S keys

        // Create a new Vector2 with the input
        Vector2 movement = new Vector2(moveX, moveY);
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
    private void DirectionPlayer() {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;

        // rotation on z axis
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg; 

        transform.rotation = Quaternion.Euler(0, 0, rotZ + 90);
    }

    public override void reduceHealth() {

    }
}
