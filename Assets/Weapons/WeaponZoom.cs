using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera camera;
    [SerializeField] float zoomedFOV = 50;
    [SerializeField] float zoomedOutFOV = 75;


    public void OnZoom(InputAction.CallbackContext ctx)
    {
        if(ctx.control.IsPressed())
        {
            camera.fieldOfView = zoomedFOV;
        } else
        {
            camera.fieldOfView = zoomedOutFOV;
        }
    } 
}
