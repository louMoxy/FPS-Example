using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        BroadcastMessage("OnDamageTaken");
        if(hitPoints <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Destroy(gameObject);
    }
    
}
