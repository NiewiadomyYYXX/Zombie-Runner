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
    [SerializeField] float fov = 70f;
    [SerializeField] float zoom = 30f;
    [SerializeField] float sens = .5f;
    [SerializeField] float sensScope = 2.5f;

    bool zoomedInToggle = false;

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if(zoomedInToggle == false)
            {
                zoomedInToggle = true;
                FPSCamera.m_Lens.FieldOfView = zoom;
                GetComponent<FirstPersonController>().RotationSpeed = sensScope;
            } 
            else
            {
                zoomedInToggle = false;
                FPSCamera.m_Lens.FieldOfView = fov;
                GetComponent<FirstPersonController>().RotationSpeed = sens;
            }
        }
    }
}
