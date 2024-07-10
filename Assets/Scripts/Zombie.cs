using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class Zombie : HostileCreatures {
    private Rigidbody2D rb;
    
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate() {
        if (targetPlayer != null) {
            Vector2 direction = (targetPlayer.transform.position - transform.position).normalized;
            rb.velocity = direction * speed;
            // Rotate the zombie to face the direction of movement
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
        }
    }
    public override void reduceHealth() {

    }
}