using UnityEngine;
using UnityEngine.AI;

[RequireComponent (typeof(Rigidbody2D))]
public class Zombie : HostileCreatures {
    private Rigidbody2D rb;
    private NavMeshAgent agent;
    
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }
    private void FixedUpdate() {
        // follow player
        //if (targetPlayer != null) {
        //    Vector2 direction = (targetPlayer.transform.position - transform.position).normalized;
        //    rb.velocity = direction * speed;
        //    // Rotate the zombie to face the direction of movement
        //    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //    rb.rotation = angle;
        //}

        agent.SetDestination(target.transform.position);

    }
    public override void reduceHealth() {

    }
}