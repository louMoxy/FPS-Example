using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammoAmount = 5;
    [SerializeField] AmmoType ammoType;

    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.GetComponent<PlayerHealth>())
            {
                GetComponent<Ammo>().IncreaseAmmo(ammoType, ammoAmount);
                Destroy(gameObject);
            }
        }
    }
}
