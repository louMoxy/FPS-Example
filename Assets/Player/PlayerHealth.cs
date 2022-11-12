using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHealth = 50f;

    bool isDead = false;

    public void DamagePlayer(float damage)
    {
        if(!isDead)
        {
            playerHealth -= damage;
            if (playerHealth <= 0)
            {
                Death();
            }
        }
    }

    private void Death()
    {
        isDead = true;
        GetComponent<DeathHandler>().HandleDeath();
    }
}
