using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : LifeBehaviour
{
    private void Start()
    {
        lifeAmount = 100;
    }

    public override void TakeDamage(int damageAmount)
    {
        base.TakeDamage(damageAmount);
    }
}
