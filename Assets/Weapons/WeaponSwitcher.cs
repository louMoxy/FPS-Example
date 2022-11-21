using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] int currentWeaponIndex = 0;

    void Start()
    {
        SetWeaponActive();
    }

    public void WeaponSwtich(CallbackContext cbx)
    {
        if(cbx.control.ToString().Contains("1"))
        {
            currentWeaponIndex = 0;
        } else if (cbx.control.ToString().Contains("2"))
        {
            currentWeaponIndex = 1;
        }
        SetWeaponActive();
    }

    private void SetWeaponActive()
    {
        int weaponIndex = 0;

        foreach (Transform weapon in transform)
        {
            weapon.gameObject.SetActive(weaponIndex == currentWeaponIndex);
            weaponIndex++;
        }
    }
}
