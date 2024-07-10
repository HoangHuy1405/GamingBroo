using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// sealed preven inheritance
public sealed class Player : LivingEntity
{
    private void Awake() {
        Reference.thePlayer = this;
    }
    public override void reduceHealth() {

    }
}
