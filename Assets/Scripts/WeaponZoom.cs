using Cinemachine;
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

    bool zoomedInToggle = false;

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if(zoomedInToggle == false)
            {
                zoomedInToggle = true;
                FPSCamera.m_Lens.FieldOfView = zoom;
            } 
            else
            {
                zoomedInToggle = false;
                FPSCamera.m_Lens.FieldOfView = fov;
            }
        }
    }
}
