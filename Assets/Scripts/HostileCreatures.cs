using UnityEngine;

public abstract class HostileCreatures : LivingEntity {
    protected int level;
    [SerializeField] protected Player target;
}