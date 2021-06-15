using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public abstract class LifeBehaviour : MonoBehaviour,ILife
{
    protected int lifeAmount;
    
    public virtual void TakeDamage(int damageAmount)
    {
        if (lifeAmount > 0 && damageAmount < lifeAmount)
        {
            lifeAmount -= damageAmount;
            Debug.Log(gameObject.name + " Tomou " + damageAmount + " de dano!" );
        }
        else
        {
            Death();
        }
    }

    public virtual void Death()
    {
        Debug.Log(gameObject.name + " " + "Morreu!");
    }
}
