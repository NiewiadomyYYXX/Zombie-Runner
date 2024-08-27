using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float Range = 100f;
    [SerializeField] float Damage = 30f;
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] GameObject hitEffect;
    [SerializeField] Ammo ammoSlot;
    [SerializeField] float timeBetweenShots = .5f;

    bool canShoot = true;

    private void OnEnable()
    {
        canShoot = true;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canShoot == true)
        {
            //StartCoroutine(Shoot());
        }
    }

    //IEnumerator Shoot()
    //{
    //    canShoot = false;
    //    if(ammoSlot.GetCurrentAmmo() > 0)
    //    {
    //        PlayMuzzleFlash();
    //        ProccessRaycast();
    //        ammoSlot.ReduceCurrentAmmo();
    //    }
    //    yield return new WaitForSeconds(timeBetweenShots);
    //    canShoot = true;
    //}

    private void PlayMuzzleFlash()
    {
        muzzleFlash.Play();
    }

    private void ProccessRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, Range))
        {
            CreateHitImpact(hit);
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target != null)
            {
                target.TakeDamage(Damage);
            }
        }
        else
        {
            return;
        }
    }

    void CreateHitImpact(RaycastHit hit)
    {
        GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, .5f);
    }


}
