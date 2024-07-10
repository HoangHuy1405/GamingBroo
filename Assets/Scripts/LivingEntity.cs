using UnityEngine;

public abstract class LivingEntity : MonoBehaviour,IDamageable {
    [SerializeField] protected string Name;
    [SerializeField] protected float health;
    [SerializeField] protected float speed;
    public abstract void reduceHealth();
    public float getSpeed() {
        return this.speed;
    }
}