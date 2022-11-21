using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    bool isDead = false;
    public bool IsDead()
    {
        return isDead;
    }

    public void TakeDamage(float damage)
    {
        if (isDead) { return; }
        hitPoints -= damage;
        BroadcastMessage("OnDamageTaken");
        if(hitPoints <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        GetComponent<Animator>().ResetTrigger("Hit");
        GetComponent<Animator>().SetBool("Death", true);
        isDead = true;
    }
    
}
