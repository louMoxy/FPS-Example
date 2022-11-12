using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Michsky.MUIP;
using System;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] private ModalWindowManager myModalWindow;

    public void HandleDeath()
    {
        myModalWindow.Open();
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
