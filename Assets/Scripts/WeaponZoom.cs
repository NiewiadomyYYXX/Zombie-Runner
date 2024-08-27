using Cinemachine;
using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera FPSCamera;
    [SerializeField] FirstPersonController fpsControler;
    [SerializeField] float fov = 70f;
    [SerializeField] float zoom = 30f;
    [SerializeField] float sens = 2.5f;
    [SerializeField] float sensScope = .5f;

    bool zoomedInToggle = false;

    private void Update()
    {
        ZoomWeapon();
    }

    private void ZoomWeapon()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                zoomedInToggle = true;
                FPSCamera.m_Lens.FieldOfView = zoom;
                fpsControler.RotationSpeed = sensScope;
            }
            else
            {
                zoomedInToggle = false;
                FPSCamera.m_Lens.FieldOfView = fov;
                fpsControler.RotationSpeed = sens;
            }
        }
    }
}
