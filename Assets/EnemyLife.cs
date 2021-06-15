using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : LifeBehaviour
{
    private void Start()
    {
        lifeAmount = 200;
    }

    public override void TakeDamage(int damageAmount)
    {
        base.TakeDamage(damageAmount);
    }

    public override void Death()
    {
        Destroy(gameObject);
    }
}
